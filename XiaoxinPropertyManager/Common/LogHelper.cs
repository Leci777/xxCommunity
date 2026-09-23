using System;

namespace XiaoxinPropertyManager.Common
{
    // 写操作日志，出错就忽略，不影响用户操作
    public static class LogHelper
    {
        public static void Write(string action, string detail)
        {
            try
            {
                DbHelper.Execute(
                    "INSERT INTO tb_SysLog (UserName, Action, Detail, LogTime) VALUES (@u, @a, @d, GETDATE())",
                    DbHelper.P("@u", Session.LoginName),
                    DbHelper.P("@a", action),
                    DbHelper.P("@d", detail));
            }
            catch
            {
                // 忽略，不能因为日志写不进去影响用户
            }
        }
    }
}
