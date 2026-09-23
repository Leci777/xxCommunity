using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 小区管理：上面小区信息，下面楼栋列表
    public partial class CommunityPage : ModulePage
    {
        public CommunityPage()
        {
            InitializeComponent();
        }

        // ---- 工具栏按钮的点击方法 ----

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditBuilding(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SelectedId("BuildingId");
            if (id == 0)
            {
                Info("请先在楼栋列表中选择一行。");
                return;
            }
            EditBuilding(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBuilding();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnEditCommunity_Click(object sender, EventArgs e)
        {
            EditCommunity();
        }

        // ---- 查数据 ----

        protected override void LoadData()
        {
            LoadCommunityInfo();
            LoadBuildings();
        }

        private void LoadCommunityInfo()
        {
            DataTable table = DbHelper.Query(
                "SELECT TOP 1 CommunityName, Address, Area, BuildingCount, HouseholdCount, GreenRate, " +
                "ParkingCount, PropertyCompany, PropertyFeeRate, Manager, ContactPhone " +
                "FROM tb_Community ORDER BY CommunityId");

            if (table.Rows.Count == 0)
            {
                lblName.Text = "还没有录入，请点击右侧“修改小区信息”";
                return;
            }

            DataRow row = table.Rows[0];
            lblName.Text = Str(row, "CommunityName", "—");
            lblAddress.Text = Str(row, "Address", "—");
            lblArea.Text = row["Area"] == DBNull.Value
                ? "—"
                : Convert.ToDecimal(row["Area"]).ToString("0.00") + " 平方米";
            lblBuildings.Text = Str(row, "BuildingCount", "—") + " 栋";
            lblHouseholds.Text = Str(row, "HouseholdCount", "—") + " 户";
            lblCompany.Text = Str(row, "PropertyCompany", "—");
            lblFee.Text = Str(row, "PropertyFeeRate", "—");
            lblPhone.Text = Str(row, "ContactPhone", "—");
            lblGreen.Text = Str(row, "GreenRate", "—");
            lblParking.Text = Str(row, "ParkingCount", "—") + " 个";
        }

        private void LoadBuildings()
        {
            DataTable table = DbHelper.Query(
                "SELECT b.BuildingId, b.BuildingName, b.UnitCount, b.FloorCount, b.Remark, " +
                "       (SELECT COUNT(1) FROM tb_Household h WHERE h.BuildingId = b.BuildingId) AS HouseholdCount " +
                "FROM tb_Building b ORDER BY b.BuildingId");

            Bind(table,
                new GridColumn("BuildingId", "编号", 45, GridAlign.Center),
                new GridColumn("BuildingName", "楼栋名称", 90),
                new GridColumn("UnitCount", "单元数", 70, GridAlign.Center),
                new GridColumn("FloorCount", "层数", 70, GridAlign.Center),
                new GridColumn("HouseholdCount", "已登记住户", 90, GridAlign.Center),
                new GridColumn("Remark", "备注", 260));
        }

        protected override void OnDataBound(DataTable data)
        {
            SetFooterSummary("共 " + data.Rows.Count + " 栋楼");
        }

        // ---- 小区信息的新增和修改 ----

        private void EditCommunity()
        {
            DataTable table = DbHelper.Query("SELECT TOP 1 * FROM tb_Community ORDER BY CommunityId");
            DataRow row = table.Rows.Count > 0 ? table.Rows[0] : null;
            bool isNew = row == null;

            var dialog = new EditDialog("小区基本信息", "这些信息会显示在首页和本页顶部");
            dialog.AddText("CommunityName", "小区名称", Str(row, "CommunityName"), true);
            dialog.AddText("Address", "小区地址", Str(row, "Address"));
            dialog.AddNumber("Area", "占地面积(㎡)", Str(row, "Area"));
            dialog.AddNumber("BuildingCount", "楼栋数量", Str(row, "BuildingCount"));
            dialog.AddNumber("HouseholdCount", "住户数量", Str(row, "HouseholdCount"));
            dialog.AddText("GreenRate", "绿化率", Str(row, "GreenRate"));
            dialog.AddNumber("ParkingCount", "车位数量", Str(row, "ParkingCount"));
            dialog.AddText("PropertyCompany", "物业公司", Str(row, "PropertyCompany"));
            dialog.AddText("PropertyFeeRate", "物业费标准", Str(row, "PropertyFeeRate"));
            dialog.AddText("Manager", "物业负责人", Str(row, "Manager"));
            dialog.AddText("ContactPhone", "联系电话", Str(row, "ContactPhone"));
            dialog.AddText("Email", "电子邮箱", Str(row, "Email"));
            dialog.AddMultiline("Remark", "备注", Str(row, "Remark"), false, 70);

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            List<SqlParameter> parameters = BuildCommunityParameters(dialog);
            if (!isNew)
            {
                parameters.Add(DbHelper.P("@id", Convert.ToInt32(row["CommunityId"])));
            }

            string sql = isNew
                ? "INSERT INTO tb_Community (CommunityName, Address, Area, BuildingCount, HouseholdCount, GreenRate, " +
                  "ParkingCount, PropertyCompany, PropertyFeeRate, Manager, ContactPhone, Email, Remark, UpdateTime) " +
                  "VALUES (@name, @addr, @area, @bc, @hc, @green, @pc, @company, @fee, @manager, @phone, @email, @remark, GETDATE())"
                : "UPDATE tb_Community SET CommunityName = @name, Address = @addr, Area = @area, BuildingCount = @bc, " +
                  "HouseholdCount = @hc, GreenRate = @green, ParkingCount = @pc, PropertyCompany = @company, " +
                  "PropertyFeeRate = @fee, Manager = @manager, ContactPhone = @phone, Email = @email, Remark = @remark, " +
                  "UpdateTime = GETDATE() WHERE CommunityId = @id";

            Run(delegate
            {
                DbHelper.Execute(sql, parameters.ToArray());
                LogHelper.Write("维护小区信息", "小区名称：" + dialog.Value("CommunityName"));
            }, "小区信息已保存。");
        }

        private static List<SqlParameter> BuildCommunityParameters(EditDialog dialog)
        {
            return new List<SqlParameter>
            {
                DbHelper.P("@name", dialog.Value("CommunityName")),
                DbHelper.P("@addr", dialog.Value("Address")),
                DbHelper.P("@area", dialog.ValueDecimal("Area")),
                DbHelper.P("@bc", dialog.ValueInt("BuildingCount")),
                DbHelper.P("@hc", dialog.ValueInt("HouseholdCount")),
                DbHelper.P("@green", dialog.Value("GreenRate")),
                DbHelper.P("@pc", dialog.ValueInt("ParkingCount")),
                DbHelper.P("@company", dialog.Value("PropertyCompany")),
                DbHelper.P("@fee", dialog.Value("PropertyFeeRate")),
                DbHelper.P("@manager", dialog.Value("Manager")),
                DbHelper.P("@phone", dialog.Value("ContactPhone")),
                DbHelper.P("@email", dialog.Value("Email")),
                DbHelper.P("@remark", dialog.Value("Remark"))
            };
        }

        // ---- 楼栋的新增和修改 ----

        private void EditBuilding(int buildingId)
        {
            DataRow row = null;
            if (buildingId > 0)
            {
                DataTable table = DbHelper.Query("SELECT * FROM tb_Building WHERE BuildingId = @id",
                    DbHelper.P("@id", buildingId));
                if (table.Rows.Count == 0)
                {
                    Warn("该楼栋已不存在，请刷新后重试。");
                    return;
                }
                row = table.Rows[0];
            }

            var dialog = new EditDialog(buildingId > 0 ? "修改楼栋" : "新增楼栋", "楼栋是住户档案的关联依据");
            dialog.AddText("BuildingName", "楼栋名称", Str(row, "BuildingName"), true);
            dialog.AddNumber("UnitCount", "单元数", Str(row, "UnitCount"));
            dialog.AddNumber("FloorCount", "层数", Str(row, "FloorCount"));
            dialog.AddText("Remark", "备注", Str(row, "Remark"));

            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            Run(delegate
            {
                string name = dialog.Value("BuildingName");
                if (buildingId > 0)
                {
                    DbHelper.Execute(
                        "UPDATE tb_Building SET BuildingName = @name, UnitCount = @unit, FloorCount = @floor, " +
                        "Remark = @remark WHERE BuildingId = @id",
                        DbHelper.P("@name", name),
                        DbHelper.P("@unit", dialog.ValueInt("UnitCount")),
                        DbHelper.P("@floor", dialog.ValueInt("FloorCount")),
                        DbHelper.P("@remark", dialog.Value("Remark")),
                        DbHelper.P("@id", buildingId));
                    LogHelper.Write("修改楼栋", "楼栋：" + name);
                }
                else
                {
                    DbHelper.Execute(
                        "INSERT INTO tb_Building (BuildingName, UnitCount, FloorCount, Remark, CreateTime) " +
                        "VALUES (@name, @unit, @floor, @remark, GETDATE())",
                        DbHelper.P("@name", name),
                        DbHelper.P("@unit", dialog.ValueInt("UnitCount")),
                        DbHelper.P("@floor", dialog.ValueInt("FloorCount")),
                        DbHelper.P("@remark", dialog.Value("Remark")));
                    LogHelper.Write("新增楼栋", "楼栋：" + name);
                }
            }, buildingId > 0 ? "楼栋信息已更新。" : "楼栋已新增。");
        }

        private void DeleteBuilding()
        {
            int id = SelectedId("BuildingId");
            if (id == 0)
            {
                Info("请先在楼栋列表中选择一行。");
                return;
            }

            int used = DbHelper.ScalarInt("SELECT COUNT(1) FROM tb_Household WHERE BuildingId = @id",
                DbHelper.P("@id", id));
            if (used > 0)
            {
                Warn("该楼栋下已经登记了 " + used + " 户住户，需要先处理这些住户档案才能删除楼栋。");
                return;
            }

            string name = SelectedText("BuildingName");
            if (!Confirm("确定要删除楼栋“" + name + "”吗？删除后不可恢复。")) return;

            Run(delegate
            {
                DbHelper.Execute("DELETE FROM tb_Building WHERE BuildingId = @id", DbHelper.P("@id", id));
                LogHelper.Write("删除楼栋", "楼栋：" + name);
            }, "楼栋已删除。");
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
