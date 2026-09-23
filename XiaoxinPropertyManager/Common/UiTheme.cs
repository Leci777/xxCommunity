using System.Drawing;
using System.Windows.Forms;

namespace XiaoxinPropertyManager.Common
{
    // 全局配色和字体，浅灰背景 + 白卡片 + 蓝色点缀
    public static class UiTheme
    {
        // ---- 颜色 ----
        public static readonly Color AppBackground = Color.FromArgb(244, 246, 249); // 页面背景色
        public static readonly Color Surface = Color.White;                          // 卡片里的白色背景
        public static readonly Color Border = Color.FromArgb(222, 226, 232);        // 边框颜色
        public static readonly Color BorderLight = Color.FromArgb(235, 238, 242);

        public static readonly Color TextPrimary = Color.FromArgb(31, 35, 41);      // 主要文字
        public static readonly Color TextSecondary = Color.FromArgb(122, 130, 143);// 次要文字
        public static readonly Color TextDisabled = Color.FromArgb(160, 167, 176);

        public static readonly Color Primary = Color.FromArgb(41, 106, 197);        // 主色调，蓝色
        public static readonly Color PrimaryDark = Color.FromArgb(33, 88, 166);     // 鼠标放上去/按下去的颜色
        public static readonly Color PrimarySoft = Color.FromArgb(236, 243, 252);   // 淡淡的蓝色底

        public static readonly Color Danger = Color.FromArgb(192, 62, 51);
        public static readonly Color Success = Color.FromArgb(45, 138, 88);
        public static readonly Color Warning = Color.FromArgb(184, 128, 22);

        public static readonly Color GridHeaderBack = Color.FromArgb(246, 247, 249);
        public static readonly Color GridAltRow = Color.FromArgb(251, 252, 253);
        public static readonly Color GridLine = Color.FromArgb(234, 237, 241);

        public static readonly Color NavHoverBack = Color.FromArgb(246, 248, 251);
        public static readonly Color NavSelectedBack = Color.FromArgb(235, 242, 252);

        // ---- 字体 ----
        public const string FontFamily = "微软雅黑";

        public static readonly Font FontNormal = new Font(FontFamily, 9F, FontStyle.Regular);
        public static readonly Font FontBold = new Font(FontFamily, 9F, FontStyle.Bold);
        public static readonly Font FontSmall = new Font(FontFamily, 8.5F, FontStyle.Regular);
        public static readonly Font FontSubTitle = new Font(FontFamily, 10.5F, FontStyle.Bold);
        public static readonly Font FontTitle = new Font(FontFamily, 11.5F, FontStyle.Bold);
        public static readonly Font FontBrand = new Font(FontFamily, 14F, FontStyle.Bold);
        public static readonly Font FontMetric = new Font(FontFamily, 19F, FontStyle.Bold);

        // ---- 尺寸 ----
        public const int RowHeight = 25;      // 一行输入框的高度
        public const int ButtonHeight = 26;   // 按钮高度
        public const int Margin = 24;         // 页面左右两边留出来的空白
        public const int Gap = 12;            // 控件之间的间距
    }
}
