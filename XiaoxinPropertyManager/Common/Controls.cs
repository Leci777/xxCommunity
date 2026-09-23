using System;
using System.Drawing;
using System.Windows.Forms;

namespace XiaoxinPropertyManager.Common
{
    // 页面底部的状态栏，自己画一条顶部分隔线
    public class FooterPanel : Panel
    {
        public FooterPanel()
        {
            BackColor = Color.White;
            Margin = new Padding(0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(UiTheme.Border))
            {
                e.Graphics.DrawLine(pen, 0, 0, Width, 0);
            }
        }
    }

    // 白底灰边框的卡片，信息区、表格区都用它装
    public class CardPanel : Panel
    {        public Label CaptionLabel;

        public CardPanel()
        {
            InitCard();
        }

        public CardPanel(string caption)
        {
            InitCard();
            Caption = caption;
        }

        private void InitCard()
        {
            BackColor = UiTheme.Surface;
            Padding = new Padding(1);
        }

        // 卡片左上角的标题文字
        public string Caption
        {
            get { return CaptionLabel == null ? string.Empty : CaptionLabel.Text; }
            set
            {
                if (CaptionLabel == null)
                {
                    CaptionLabel = new Label
                    {
                        Font = UiTheme.FontBold,
                        ForeColor = UiTheme.TextPrimary,
                        BackColor = Color.Transparent,
                        AutoSize = true,
                        Location = new Point(20, 14)
                    };
                    Controls.Add(CaptionLabel);
                }
                CaptionLabel.Text = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(UiTheme.Border))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }
    }

    // 首页那排数字卡片：上面小标题，下面大数字
    public class StatCard : Panel
    {
        private Label _caption;
        private Label _value;
        private Label _unit;
        private readonly Color _valueColor;

        public StatCard()
            : this(null, "-", string.Empty)
        {
        }

        public StatCard(string caption, string value, string unit, Color? valueColor = null)
        {
            BackColor = UiTheme.Surface;
            _valueColor = valueColor ?? UiTheme.TextPrimary;

            _caption = new Label
            {
                Text = caption,
                Font = UiTheme.FontNormal,
                ForeColor = UiTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(20, 16)
            };

            _value = new Label
            {
                Text = value,
                Font = UiTheme.FontMetric,
                ForeColor = _valueColor,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(18, 40)
            };

            _unit = new Label
            {
                Text = unit,
                Font = UiTheme.FontNormal,
                ForeColor = UiTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(20, 56)
            };

            Controls.Add(_caption);
            Controls.Add(_value);
            Controls.Add(_unit);
            LayoutUnit();
        }

        // 卡片小标题
        public string Caption
        {
            get { return _caption.Text; }
            set { SetCaption(value); }
        }

        // 中间那个大数字
        public string Value
        {
            get { return _value.Text; }
            set { SetValue(value); }
        }

        // 数字后面的单位
        public string Unit
        {
            get { return _unit.Text; }
            set { SetUnit(value); }
        }

        public void SetValue(string value)
        {
            _value.Text = value;
            LayoutUnit();
        }

        // 换一下卡片的标题
        public void SetCaption(string caption)
        {
            _caption.Text = caption;
        }

        // 换数字后面的单位
        public void SetUnit(string unit)
        {
            _unit.Text = unit;
            LayoutUnit();
        }

        private void LayoutUnit()
        {
            _unit.Location = new Point(20 + _value.PreferredWidth + 4, 56);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var pen = new Pen(UiTheme.Border))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }
    }

    // 左边菜单的一项，选中时浅蓝底 + 蓝色竖条（竖条直接画，不用图片）
    public class NavItem : Button
    {
        private bool _selected;

        public NavItem(string text) : this()
        {
            Text = text;
        }

        // 给 VS 设计器用的无参构造
        public NavItem()
        {
            Text = "菜单项";
            Height = 42;
            Width = 190;
            Margin = new Padding(0);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = UiTheme.NavHoverBack;
            FlatAppearance.MouseDownBackColor = UiTheme.NavSelectedBack;
            TextAlign = ContentAlignment.MiddleLeft;
            Padding = new Padding(22, 0, 0, 0);
            Font = UiTheme.FontNormal;
            ForeColor = UiTheme.TextPrimary;
            BackColor = Color.White;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                BackColor = value ? UiTheme.NavSelectedBack : Color.White;
                ForeColor = value ? UiTheme.Primary : UiTheme.TextPrimary;
                Font = value ? UiTheme.FontBold : UiTheme.FontNormal;
                FlatAppearance.MouseOverBackColor = value ? UiTheme.NavSelectedBack : UiTheme.NavHoverBack;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (_selected)
            {
                using (var brush = new SolidBrush(UiTheme.Primary))
                {
                    pevent.Graphics.FillRectangle(brush, 0, 0, 3, Height);
                }
            }
        }
    }
}
