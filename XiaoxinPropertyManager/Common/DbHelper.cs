using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace XiaoxinPropertyManager.Common
{
    // 数据库操作类
    public static class DbHelper
    {
        public const string ConnectionName = "XiaoxinDb";

        private static string _connString;

        // 当前连接字符串，先读 App.config，读不到用默认值
        public static string ConnString
        {
            get
            {
                if (string.IsNullOrEmpty(_connString))
                {
                    _connString = ReadConfigConnectionString();
                }
                return _connString;
            }
            set { _connString = value; }
        }

        private static string ReadConfigConnectionString()
        {
            try
            {
                var setting = ConfigurationManager.ConnectionStrings[ConnectionName];
                if (setting != null && !string.IsNullOrEmpty(setting.ConnectionString))
                {
                    return setting.ConnectionString;
                }
            }
            catch
            {
                // 配置坏了就用默认值，别让程序启动不了
            }
            return @"Data Source=.;Initial Catalog=XiaoxinCommunityDB;Integrated Security=True;Connect Timeout=15;";
        }

        // 存回 App.config，下次打开还是这个地址
        public static void SaveConnString(string connString)
        {
            ConnString = connString;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var item = config.ConnectionStrings.ConnectionStrings[ConnectionName];
            if (item == null)
            {
                config.ConnectionStrings.ConnectionStrings.Add(
                    new ConnectionStringSettings(ConnectionName, connString, "System.Data.SqlClient"));
            }
            else
            {
                item.ConnectionString = connString;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        // 从连接字符串里拆出来的服务器地址，只在界面显示用
        public static string ServerName
        {
            get
            {
                try { return new SqlConnectionStringBuilder(ConnString).DataSource; }
                catch { return "(未识别)"; }
            }
        }

        // 数据库名，只在界面显示用
        public static string DatabaseName
        {
            get
            {
                try { return new SqlConnectionStringBuilder(ConnString).InitialCatalog; }
                catch { return "(未识别)"; }
            }
        }

        // ---- 下面是跟参数有关的几个小方法 ----

        // 建 SQL 参数，值为 null 要换成 DBNull，否则插入会报错
        public static SqlParameter P(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        // 模糊查询参数，前后各补一个 %
        public static SqlParameter Like(string name, string keyword)
        {
            string k = (keyword ?? string.Empty).Trim();
            return new SqlParameter(name, "%" + k + "%");
        }

        // 文字转小数，转不了就用默认值
        public static decimal ToDecimal(string text, decimal fallback)
        {
            decimal v;
            if (decimal.TryParse((text ?? string.Empty).Trim(), out v)) return v;
            return fallback;
        }

        // 文字转整数，转不了就用默认值
        public static int ToInt(string text, int fallback)
        {
            int v;
            if (int.TryParse((text ?? string.Empty).Trim(), out v)) return v;
            return fallback;
        }

        // ---- 下面是真正去执行 SQL 的方法 ----

        private static SqlConnection OpenConnection()
        {
            var conn = new SqlConnection(ConnString);
            conn.Open();
            return conn;
        }

        // 查询，返回 DataTable
        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var conn = OpenConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        // 查询，返回 DataSet
        public static DataSet QueryDataSet(string sql, params SqlParameter[] parameters)
        {
            using (var conn = OpenConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                using (var adapter = new SqlDataAdapter(cmd))
                {
                    var ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }

        // 取第一行第一列的值
        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var conn = OpenConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        // 取整数，没查到返回 0
        public static int ScalarInt(string sql, params SqlParameter[] parameters)
        {
            object v = Scalar(sql, parameters);
            if (v == null || v == DBNull.Value) return 0;
            return Convert.ToInt32(v);
        }

        // 取金额，没查到返回 0
        public static decimal ScalarDecimal(string sql, params SqlParameter[] parameters)
        {
            object v = Scalar(sql, parameters);
            if (v == null || v == DBNull.Value) return 0m;
            return Convert.ToDecimal(v);
        }

        // 取文字，没查到返回空字符串
        public static string ScalarString(string sql, params SqlParameter[] parameters)
        {
            object v = Scalar(sql, parameters);
            if (v == null || v == DBNull.Value) return string.Empty;
            return Convert.ToString(v);
        }

        // 增删改都走这个方法
        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var conn = OpenConnection())
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        // 插入记录，返回刚生成的编号
        public static int InsertReturnId(string sql, params SqlParameter[] parameters)
        {
            using (var conn = OpenConnection())
            using (var cmd = new SqlCommand(sql + "; SELECT CAST(SCOPE_IDENTITY() AS INT);", conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                object v = cmd.ExecuteScalar();
                if (v == null || v == DBNull.Value) return 0;
                return Convert.ToInt32(v);
            }
        }

        // 试一下连接字符串能不能连上数据库
        public static bool TestConnection(string connString, out string message)
        {
            try
            {
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    message = "连接成功，数据库版本：" + conn.ServerVersion;
                    return true;
                }
            }
            catch (Exception ex)
            {
                message = FriendlyMessage(ex);
                return false;
            }
        }

        // 把数据库的错误翻成中文，用户看完知道下一步干什么
        public static string FriendlyMessage(Exception ex)
        {
            var se = ex as SqlException;
            if (se != null)
            {
                switch (se.Number)
                {
                    case 4060:
                        return "无法打开数据库 " + DatabaseName + "。\r\n请先执行 database 目录下的建库脚本。";
                    case 208:
                        return "数据表不存在，说明数据库还没初始化。\r\n请先执行 database 目录下的建库脚本。";
                    case 18456:
                    case 18452:
                        return "登录名或密码不正确。\r\n可在登录页点击“数据库设置”修改连接信息，或改用 Windows 身份验证。";
                    case 4064:
                        return "无法打开连接字符串中指定的默认数据库，请检查数据库名是否正确。";
                    case 53:
                    case -1:
                    case 2:
                        return "找不到数据库服务器，或 SQL Server 服务没有启动。\r\n请检查连接字符串中的服务器地址。";
                    case 40615:
                        return "该客户端 IP 未获得服务器授权，请检查 SQL Server 的防火墙 / 远程访问设置。";
                }
                return "数据库操作失败（错误号 " + se.Number + "）：" + se.Message;
            }

            var ioe = ex as InvalidOperationException;
            if (ioe != null) return "连接字符串格式不正确：" + ioe.Message;

            return ex.Message;
        }
    }
}
