using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 住户管理：登记业主档案，报修、收费、车位都要用到这里的数据
    public partial class HouseholdPage : ModulePage
    {
        public HouseholdPage()
        {
            InitializeComponent();
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            if (cboBuilding.Items.Count > 0) cboBuilding.SelectedIndex = 0;
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditHousehold(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectedId("HouseholdId");
            if (id == 0)
            {
                Info("请先在列表中选择一行。");
                return;
            }
            EditHousehold(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteHousehold();
        }

        protected override void LoadData()
        {
            LoadBuildingOptions();
            LoadHouseholds();
        }

        private void LoadBuildingOptions()
        {
            string current = cboBuilding.SelectedItem == null ? "全部" : cboBuilding.SelectedItem.ToString();

            DataTable table = DbHelper.Query("SELECT BuildingName FROM tb_Building ORDER BY BuildingId");
            var items = new List<string> { "全部" };
            foreach (DataRow row in table.Rows)
            {
                items.Add(Convert.ToString(row["BuildingName"]));
            }

            cboBuilding.Items.Clear();
            cboBuilding.Items.AddRange(items.ToArray());
            int index = cboBuilding.Items.IndexOf(current);
            cboBuilding.SelectedIndex = index < 0 ? 0 : index;
        }

        private void LoadHouseholds()
        {
            string keyword = txtKeyword.Text.Trim();
            string building = FilterValue(cboBuilding, "全部");

            var sql = new StringBuilder();
            sql.Append("SELECT h.HouseholdId, h.OwnerName, h.Gender, h.Phone, h.IdCard, b.BuildingName, h.RoomNo, ");
            sql.Append("       h.Area, h.FamilyCount, h.MoveInDate, h.Remark ");
            sql.Append("FROM tb_Household h LEFT JOIN tb_Building b ON h.BuildingId = b.BuildingId ");

            var conditions = new List<string>();
            var parameters = new List<SqlParameter>();

            if (keyword.Length > 0)
            {
                conditions.Add("(h.OwnerName LIKE @like OR h.Phone LIKE @like OR h.RoomNo LIKE @like OR h.IdCard LIKE @like)");
                parameters.Add(DbHelper.Like("@like", keyword));
            }
            if (building.Length > 0)
            {
                conditions.Add("b.BuildingName = @building");
                parameters.Add(DbHelper.P("@building", building));
            }
            if (conditions.Count > 0)
            {
                sql.Append("WHERE ").Append(string.Join(" AND ", conditions.ToArray())).Append(" ");
            }
            sql.Append("ORDER BY h.HouseholdId");

            DataTable table = DbHelper.Query(sql.ToString(), parameters.ToArray());

            Bind(table,
                new GridColumn("HouseholdId", "编号", 45, GridAlign.Center),
                new GridColumn("OwnerName", "业主姓名", 80),
                new GridColumn("Gender", "性别", 45, GridAlign.Center),
                new GridColumn("Phone", "联系电话", 95),
                new GridColumn("IdCard", "身份证号", 135),
                new GridColumn("BuildingName", "楼栋", 60, GridAlign.Center),
                new GridColumn("RoomNo", "门牌号", 105),
                new GridColumn("Area", "建筑面积", 80, GridAlign.Right, "0.00"),
                new GridColumn("FamilyCount", "家庭人数", 70, GridAlign.Center),
                new GridColumn("MoveInDate", "入住日期", 90, GridAlign.Right, "yyyy-MM-dd"),
                new GridColumn("Remark", "备注", 140));
        }

        protected override void OnDataBound(DataTable data)
        {
            SetFooterSummary("共 " + data.Rows.Count + " 户");
        }

        // ---- 增删改都在这下面 ----

        private void EditHousehold(int householdId)
        {
            DataRow row = null;
            if (householdId > 0)
            {
                DataTable table = DbHelper.Query("SELECT * FROM tb_Household WHERE HouseholdId = @id",
                    DbHelper.P("@id", householdId));
                if (table.Rows.Count == 0)
                {
                    Warn("该住户档案已不存在，请刷新后重试。");
                    return;
                }
                row = table.Rows[0];
            }

            DataTable buildings = DbHelper.Query("SELECT BuildingId, BuildingName FROM tb_Building ORDER BY BuildingId");
            if (buildings.Rows.Count == 0)
            {
                Warn("还没有楼栋资料，请先到“小区管理”里新增楼栋。");
                return;
            }

            var names = new string[buildings.Rows.Count];
            for (int i = 0; i < buildings.Rows.Count; i++)
            {
                names[i] = Convert.ToString(buildings.Rows[i]["BuildingName"]);
            }

            string currentBuilding = string.Empty;
            if (row != null && row["BuildingId"] != DBNull.Value)
            {
                int buildingId = Convert.ToInt32(row["BuildingId"]);
                foreach (DataRow b in buildings.Rows)
                {
                    if (Convert.ToInt32(b["BuildingId"]) == buildingId)
                    {
                        currentBuilding = Convert.ToString(b["BuildingName"]);
                        break;
                    }
                }
            }

            var dialog = new EditDialog(householdId > 0 ? "修改住户档案" : "新增住户档案",
                "带 * 的为必填项");
            dialog.AddText("OwnerName", "业主姓名", Value(row, "OwnerName"), true);
            dialog.AddCombo("Gender", "性别", new[] { "男", "女" }, Value(row, "Gender", "男"), true, 120);
            dialog.AddText("Phone", "联系电话", Value(row, "Phone"), true, 200);
            dialog.AddText("IdCard", "身份证号", Value(row, "IdCard"), false, 260);
            dialog.AddCombo("BuildingName", "所在楼栋", names, currentBuilding, true, 160);
            dialog.AddText("RoomNo", "门牌号", Value(row, "RoomNo"), true, 200);
            dialog.AddNumber("Area", "建筑面积(㎡)", Value(row, "Area"), false, 160);
            dialog.AddNumber("FamilyCount", "家庭人数", Value(row, "FamilyCount"), false, 160);
            dialog.AddDate("MoveInDate", "入住日期", Date(row, "MoveInDate"), false, 160);
            dialog.AddMultiline("Remark", "备注", Value(row, "Remark"), false, 60);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            int buildingId2 = FindBuildingId(buildings, dialog.Value("BuildingName"));

            Run(delegate
            {
                if (householdId > 0)
                {
                    DbHelper.Execute(
                        "UPDATE tb_Household SET OwnerName = @owner, Gender = @gender, Phone = @phone, IdCard = @idcard, " +
                        "BuildingId = @bid, RoomNo = @room, Area = @area, FamilyCount = @family, MoveInDate = @movein, " +
                        "Remark = @remark WHERE HouseholdId = @id",
                        HouseholdParameters(dialog, buildingId2, householdId));
                    LogHelper.Write("修改住户", "住户：" + dialog.Value("OwnerName") + " " + dialog.Value("RoomNo"));
                }
                else
                {
                    DbHelper.Execute(
                        "INSERT INTO tb_Household (OwnerName, Gender, Phone, IdCard, BuildingId, RoomNo, Area, " +
                        "FamilyCount, MoveInDate, Remark, CreateTime) " +
                        "VALUES (@owner, @gender, @phone, @idcard, @bid, @room, @area, @family, @movein, @remark, GETDATE())",
                        HouseholdParameters(dialog, buildingId2, 0));
                    LogHelper.Write("新增住户", "住户：" + dialog.Value("OwnerName") + " " + dialog.Value("RoomNo"));
                }
            }, householdId > 0 ? "住户档案已更新。" : "住户档案已新增。");
        }

        private static SqlParameter[] HouseholdParameters(EditDialog dialog, int buildingId, int householdId)
        {
            var list = new List<SqlParameter>
            {
                DbHelper.P("@owner", dialog.Value("OwnerName")),
                DbHelper.P("@gender", dialog.Value("Gender")),
                DbHelper.P("@phone", dialog.Value("Phone")),
                DbHelper.P("@idcard", dialog.Value("IdCard")),
                DbHelper.P("@bid", buildingId > 0 ? (object)buildingId : DBNull.Value),
                DbHelper.P("@room", dialog.Value("RoomNo")),
                DbHelper.P("@area", dialog.ValueDecimal("Area")),
                DbHelper.P("@family", dialog.ValueInt("FamilyCount")),
                DbHelper.P("@movein", dialog.ValueDate("MoveInDate")),
                DbHelper.P("@remark", dialog.Value("Remark"))
            };
            if (householdId > 0) list.Add(DbHelper.P("@id", householdId));
            return list.ToArray();
        }

        private static int FindBuildingId(DataTable buildings, string buildingName)
        {
            foreach (DataRow row in buildings.Rows)
            {
                if (Convert.ToString(row["BuildingName"]) == buildingName)
                {
                    return Convert.ToInt32(row["BuildingId"]);
                }
            }
            return 0;
        }

        private void DeleteHousehold()
        {
            int id = SelectedId("HouseholdId");
            if (id == 0)
            {
                Info("请先在列表中选择一行。");
                return;
            }

            int related = DbHelper.ScalarInt(
                "SELECT (SELECT COUNT(1) FROM tb_Repair WHERE HouseholdId = @id) " +
                "     + (SELECT COUNT(1) FROM tb_Fee WHERE HouseholdId = @id) " +
                "     + (SELECT COUNT(1) FROM tb_Parking WHERE HouseholdId = @id) " +
                "     + (SELECT COUNT(1) FROM tb_Feedback WHERE HouseholdId = @id) " +
                "     + (SELECT COUNT(1) FROM tb_SysUser WHERE HouseholdId = @id)",
                DbHelper.P("@id", id));

            if (related > 0)
            {
                Warn("该住户名下还有 " + related + " 条关联记录（报修 / 费用 / 车位 / 反馈 / 登录账号），\r\n" +
                     "需要先清理这些记录才能删除档案。");
                return;
            }

            string name = SelectedText("OwnerName");
            string room = SelectedText("RoomNo");
            if (!Confirm("确定要删除住户“" + name + "（" + room + "）”的档案吗？")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Household WHERE HouseholdId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除住户", "住户：" + name + " " + room);
            }, "住户档案已删除。");
        }

        // ---- 从这里往外取值 ----

        private static string Value(DataRow row, string column)
        {
            return Value(row, column, string.Empty);
        }

        private static string Value(DataRow row, string column, string fallback)
        {
            if (row == null) return fallback;
            object value = row[column];
            if (value == null || value == DBNull.Value) return fallback;
            string text = Convert.ToString(value).Trim();
            return text.Length == 0 ? fallback : text;
        }

        private static DateTime? Date(DataRow row, string column)
        {
            if (row == null) return null;
            object value = row[column];
            if (value == null || value == DBNull.Value) return null;
            return Convert.ToDateTime(value);
        }
    }
}
