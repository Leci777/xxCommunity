using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 车位管理：管理员维护车位并分给住户，业主看自己的车位和车牌
    public partial class ParkingPage : ModulePage
    {
        private static readonly string[] StatusList = { "空闲", "已租", "已售" };
        private static readonly string[] TypeList = { "地下", "地上" };
        private const string Unassigned = "（未分配）";

        public ParkingPage()
        {
            InitializeComponent();
            ApplyRole();
        }

        // 车位只有管理员能维护，业主只看自己绑定的那一个
        private void ApplyRole()
        {
            if (DesignMode) return;

            bool admin = Session.IsAdmin;
            lblPageTitle.Text = admin ? "车位管理" : "我的车位";
            lblPageDescription.Text = admin ? "维护车位档案与使用情况" : "查看绑定的车位与车牌信息";
            lblKeyword.Visible = admin;
            txtKeyword.Visible = admin;
            lblStatus.Visible = admin;
            cboStatus.Visible = admin;
            btnSearch.Visible = admin;
            btnReset.Visible = admin;
            btnAdd.Visible = admin;
            btnEdit.Visible = admin;
            btnDelete.Visible = admin;
            btnRefresh.Visible = !admin;
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditParking(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectedId("ParkId");
            if (id == 0)
            {
                Info("请先在列表中选择一个车位。");
                return;
            }
            EditParking(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteParking();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        protected override void LoadData()
        {
            var sql = new StringBuilder();
            sql.Append("SELECT p.ParkId, p.HouseholdId, p.ParkNo, p.ParkArea, p.ParkType, ");
            sql.Append("       h.OwnerName, h.RoomNo, p.CarNo, p.Status, p.RentFee, p.Remark ");
            sql.Append("FROM tb_Parking p LEFT JOIN tb_Household h ON p.HouseholdId = h.HouseholdId ");

            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            if (Session.IsAdmin)
            {
                string keyword = txtKeyword.Text.Trim();
                if (keyword.Length > 0)
                {
                    conditions.Add("(p.ParkNo LIKE @like OR p.CarNo LIKE @like OR h.OwnerName LIKE @like OR h.RoomNo LIKE @like)");
                    parameters.Add(DbHelper.Like("@like", keyword));
                }

                string status = FilterValue(cboStatus, "全部");
                if (status.Length > 0)
                {
                    conditions.Add("p.Status = @status");
                    parameters.Add(DbHelper.P("@status", status));
                }
            }
            else
            {
                conditions.Add("p.HouseholdId = @hid");
                parameters.Add(DbHelper.P("@hid", Session.HouseholdId));
            }

            if (conditions.Count > 0)
            {
                sql.Append("WHERE ").Append(string.Join(" AND ", conditions.ToArray())).Append(" ");
            }
            sql.Append("ORDER BY p.ParkNo");

            DataTable table = DbHelper.Query(sql.ToString(), parameters.ToArray());

            var columns = new List<GridColumn>();
            columns.Add(new GridColumn("ParkNo", "车位编号", 80, GridAlign.Center));
            columns.Add(new GridColumn("ParkArea", "所在区域", 110));
            columns.Add(new GridColumn("ParkType", "类型", 60, GridAlign.Center));
            if (Session.IsAdmin)
            {
                columns.Add(new GridColumn("OwnerName", "使用住户", 80));
                columns.Add(new GridColumn("RoomNo", "门牌号", 105));
            }
            columns.Add(new GridColumn("CarNo", "车牌号", 100, GridAlign.Center));
            columns.Add(new GridColumn("Status", "状态", 65, GridAlign.Center));
            columns.Add(new GridColumn("RentFee", "月租金(元)", 85, GridAlign.Right, "0.00"));
            columns.Add(new GridColumn("Remark", "备注", 150));

            Bind(table, columns.ToArray());
        }

        protected override void OnDataBound(DataTable data)
        {
            if (!Session.IsAdmin)
            {
                SetFooterSummary(data.Rows.Count == 0 ? "当前没有绑定车位" : "共 " + data.Rows.Count + " 个车位");
                return;
            }

            int free = 0, used = 0;
            foreach (DataRow row in data.Rows)
            {
                if (Convert.ToString(row["Status"]) == "空闲") free++;
                else used++;
            }
            SetFooterSummary("共 " + data.Rows.Count + " 个车位　空闲 " + free + " 个　已使用 " + used + " 个");
        }

        protected override void OnDoubleClickRow()
        {
            if (!Session.IsAdmin) return;
            int id = SelectedId("ParkId");
            if (id > 0) EditParking(id);
        }

        // ---- 增删改都在这下面 ----

        private void EditParking(int parkId)
        {
            DataTable households = DbHelper.Query(
                "SELECT HouseholdId, OwnerName, RoomNo FROM tb_Household ORDER BY HouseholdId");

            var labels = new string[households.Rows.Count + 1];
            labels[0] = Unassigned;
            for (int i = 0; i < households.Rows.Count; i++)
            {
                labels[i + 1] = Convert.ToString(households.Rows[i]["OwnerName"])
                    + "　" + Convert.ToString(households.Rows[i]["RoomNo"]);
            }

            DataRow row = null;
            if (parkId > 0)
            {
                DataTable table = DbHelper.Query(
                    "SELECT p.*, h.OwnerName, h.RoomNo FROM tb_Parking p " +
                    "LEFT JOIN tb_Household h ON p.HouseholdId = h.HouseholdId WHERE p.ParkId = @id",
                    DbHelper.P("@id", parkId));
                if (table.Rows.Count == 0)
                {
                    Warn("该车位已不存在，请刷新后重试。");
                    return;
                }
                row = table.Rows[0];
            }

            string currentLabel = Unassigned;
            if (row != null && row["HouseholdId"] != DBNull.Value)
            {
                currentLabel = Convert.ToString(row["OwnerName"]) + "　" + Convert.ToString(row["RoomNo"]);
            }

            var dialog = new EditDialog(parkId > 0 ? "修改车位" : "新增车位", "车位可以分配给住户，也可以保持空闲");
            dialog.AddText("ParkNo", "车位编号", Str(row, "ParkNo"), true, 150);
            dialog.AddText("ParkArea", "所在区域", Str(row, "ParkArea"), false, 180);
            dialog.AddCombo("ParkType", "车位类型", TypeList, Str(row, "ParkType", TypeList[0]), true, 110);
            dialog.AddCombo("Household", "使用住户", labels, currentLabel, false, 240);
            dialog.AddText("CarNo", "车牌号", Str(row, "CarNo"), false, 150);
            dialog.AddCombo("Status", "车位状态", StatusList, Str(row, "Status", StatusList[0]), true, 110);
            dialog.AddNumber("RentFee", "月租金(元)", Str(row, "RentFee"), false, 150);
            dialog.AddText("Remark", "备注", Str(row, "Remark"), false, 260);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            string householdLabel = dialog.Value("Household");
            int householdId = 0;
            if (householdLabel != Unassigned)
            {
                int index = Array.IndexOf(labels, householdLabel);
                if (index > 0) householdId = Convert.ToInt32(households.Rows[index - 1]["HouseholdId"]);
            }

            string status = dialog.Value("Status");
            if (householdId == 0 && status != "空闲")
            {
                Warn("车位没有分配使用住户时，状态应为“空闲”。");
                return;
            }
            if (householdId > 0 && status == "空闲")
            {
                Warn("车位已经分配给住户，状态请选择“已租”或“已售”。");
                return;
            }

            Run(delegate
            {
                var list = new List<SqlParameter>
                {
                    DbHelper.P("@no", dialog.Value("ParkNo")),
                    DbHelper.P("@area", dialog.Value("ParkArea")),
                    DbHelper.P("@type", dialog.Value("ParkType")),
                    DbHelper.P("@hid", householdId > 0 ? (object)householdId : DBNull.Value),
                    DbHelper.P("@car", dialog.Value("CarNo")),
                    DbHelper.P("@status", status),
                    DbHelper.P("@fee", dialog.ValueDecimal("RentFee")),
                    DbHelper.P("@remark", dialog.Value("Remark"))
                };

                if (parkId > 0)
                {
                    list.Add(DbHelper.P("@id", parkId));
                    DbHelper.Execute(
                        "UPDATE tb_Parking SET ParkNo = @no, ParkArea = @area, ParkType = @type, HouseholdId = @hid, " +
                        "CarNo = @car, Status = @status, RentFee = @fee, Remark = @remark WHERE ParkId = @id",
                        list.ToArray());
                    LogHelper.Write("修改车位", "车位：" + dialog.Value("ParkNo"));
                }
                else
                {
                    DbHelper.Execute(
                        "INSERT INTO tb_Parking (ParkNo, ParkArea, ParkType, HouseholdId, CarNo, Status, RentFee, Remark, CreateTime) " +
                        "VALUES (@no, @area, @type, @hid, @car, @status, @fee, @remark, GETDATE())",
                        list.ToArray());
                    LogHelper.Write("新增车位", "车位：" + dialog.Value("ParkNo"));
                }
            }, parkId > 0 ? "车位信息已更新。" : "车位已新增。");
        }

        private void DeleteParking()
        {
            int id = SelectedId("ParkId");
            if (id == 0)
            {
                Info("请先在列表中选择一个车位。");
                return;
            }

            string parkNo = SelectedText("ParkNo");
            if (!Confirm("确定要删除车位“" + parkNo + "”吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Parking WHERE ParkId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除车位", "车位：" + parkNo);
            }, "车位已删除。");
        }

        private static string Str(DataRow row, string column)
        {
            return Str(row, column, string.Empty);
        }

        private static string Str(DataRow row, string column, string fallback)
        {
            if (row == null) return fallback;
            object value = row[column];
            if (value == null || value == DBNull.Value) return fallback;
            string text = Convert.ToString(value).Trim();
            return text.Length == 0 ? fallback : text;
        }
    }
}
