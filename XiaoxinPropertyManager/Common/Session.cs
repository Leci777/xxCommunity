namespace XiaoxinPropertyManager.Common
{
    // 记录当前登录的用户，退出时清空
    public static class Session
    {
        public const string RoleAdmin = "管理员";
        public const string RoleOwner = "业主";

        public static int UserId { get; set; }
        public static string LoginName { get; set; }
        public static string RealName { get; set; }
        public static string Role { get; set; }

        // 业主的住户档案编号，管理员为 0
        public static int HouseholdId { get; set; }

        public static bool IsAdmin
        {
            get { return Role == RoleAdmin; }
        }

        public static bool IsOwner
        {
            get { return Role == RoleOwner; }
        }

        // 打招呼用的名字，优先真实姓名，没有就用账号
        public static string DisplayName
        {
            get
            {
                if (!string.IsNullOrEmpty(RealName)) return RealName;
                return LoginName;
            }
        }

        public static void Clear()
        {
            UserId = 0;
            LoginName = null;
            RealName = null;
            Role = null;
            HouseholdId = 0;
        }
    }
}
