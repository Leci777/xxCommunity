using System;
using System.Drawing;
using System.Windows.Forms;

namespace XiaoxinPropertyManager.Common
{
    // 控件工厂，样式在这里统一定，页面只管调用
    // 注意：窗体都是 AutoScaleMode.None，控件宽度先用 TextRenderer 量出来再定
    public static class Ui
    {
        // 量出文字按指定字体显示大概多少像素宽
        public static int TextWidth(string text, Font font)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            return TextRenderer.MeasureText(text, font).Width;
        }

        // ---- 下面这些都是基础控件 ----

        // 普通的说明文字
        public static Label NewLabel(string text, Font font = null, Color? color = null)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = font ?? UiTheme.FontNormal,
                ForeColor = color ?? UiTheme.TextPrimary,
                BackColor = Color.Transparent
            };
        }

        // 输入框，multiline 为 true 是多行
        public static TextBox NewInput(int width = 160, string value = "", bool multiline = false, int height = 0)
        {
            var tb = new TextBox
            {
                Font = UiTheme.FontNormal,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = UiTheme.Surface,
                ForeColor = UiTheme.TextPrimary,
                Text = value ?? string.Empty
            };
            if (multiline)
            {
                tb.Multiline = true;
                tb.ScrollBars = ScrollBars.Vertical;
                tb.Size = new Size(width, height > 0 ? height : 84);
            }
            else
            {
                tb.Size = new Size(width, UiTheme.RowHeight);
            }
            return tb;
        }

        // 密码框，输入显示成小圆点
        public static TextBox NewPassword(int width = 160, string value = "")
        {
            var tb = NewInput(width, value);
            tb.UseSystemPasswordChar = true;
            return tb;
        }

        // 只读输入框，显示不让改的信息
        public static TextBox NewReadOnlyInput(int width = 160, string value = "")
        {
            var tb = NewInput(width, value);
            tb.ReadOnly = true;
            tb.BackColor = Color.FromArgb(248, 249, 251);
            tb.ForeColor = UiTheme.TextSecondary;
            return tb;
        }

        // 下拉框，只能选不能打字
        public static ComboBox NewCombo(int width = 160, string[] items = null, string selected = null)
        {
            var cb = new ComboBox
            {
                Font = UiTheme.FontNormal,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                BackColor = UiTheme.Surface,
                ForeColor = UiTheme.TextPrimary,
                Size = new Size(width, UiTheme.RowHeight + 2)
            };
            if (items != null) cb.Items.AddRange(items);
            if (!string.IsNullOrEmpty(selected))
            {
                int idx = cb.Items.IndexOf(selected);
                if (idx >= 0) cb.SelectedIndex = idx;
            }
            if (cb.SelectedIndex < 0 && cb.Items.Count > 0) cb.SelectedIndex = 0;
            return cb;
        }

        // 选日期和时间的控件
        public static DateTimePicker NewDatePicker(int width = 160, DateTime? value = null, bool withTime = true)
        {
            var dp = new DateTimePicker
            {
                Font = UiTheme.FontNormal,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = withTime ? "yyyy-MM-dd HH:mm" : "yyyy-MM-dd",
                ShowUpDown = false,
                Size = new Size(width, UiTheme.RowHeight)
            };
            dp.Value = value ?? DateTime.Now;
            return dp;
        }

        // 按钮，primary 为 true 是蓝底白字
        public static Button NewButton(string text, int width = 0, bool primary = false, int height = 0)
        {
            int w = width > 0 ? width : TextWidth(text, UiTheme.FontNormal) + 30;
            if (w < 74) w = 74;

            var btn = new Button
            {
                Text = text,
                Font = UiTheme.FontNormal,
                Size = new Size(w, height > 0 ? height : UiTheme.ButtonHeight),
                FlatStyle = FlatStyle.Flat,
                UseVisualStyleBackColor = false,
                Cursor = Cursors.Hand,
                BackColor = primary ? UiTheme.Primary : UiTheme.Surface,
                ForeColor = primary ? Color.White : UiTheme.TextPrimary
            };
            btn.FlatAppearance.BorderSize = primary ? 0 : 1;
            btn.FlatAppearance.BorderColor = UiTheme.Border;
            btn.FlatAppearance.MouseOverBackColor = primary ? UiTheme.PrimaryDark : UiTheme.PrimarySoft;
            btn.FlatAppearance.MouseDownBackColor = primary ? UiTheme.PrimaryDark : UiTheme.PrimarySoft;
            return btn;
        }

        // 危险按钮，字是红色的
        public static Button NewDangerButton(string text, int width = 0)
        {
            var btn = NewButton(text, width);
            btn.ForeColor = UiTheme.Danger;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 242, 241);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(253, 242, 241);
            return btn;
        }

        // 文字链接，鼠标放上去才有下划线
        public static LinkLabel NewLink(string text)
        {
            return new LinkLabel
            {
                Text = text,
                AutoSize = true,
                Font = UiTheme.FontNormal,
                LinkColor = UiTheme.Primary,
                ActiveLinkColor = UiTheme.PrimaryDark,
                VisitedLinkColor = UiTheme.Primary,
                LinkBehavior = LinkBehavior.HoverUnderline,
                BackColor = Color.Transparent
            };
        }

        // ---- 下面这些是跟数据表格有关的 ----

        // 建表格，列由页面传 GridColumn 数组进来
        public static DataGridView NewGrid()
        {
            var g = new DataGridView();
            StyleGrid(g);
            return g;
        }

        // 把一个表格调成项目里统一的样式，设计器里拖出来的表格运行时也调这个
        public static void StyleGrid(DataGridView g)
        {
            if (g == null) return;
            g.Dock = DockStyle.Fill;
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = UiTheme.Surface;
            g.Font = UiTheme.FontNormal;
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.AllowUserToOrderColumns = false;
            g.ReadOnly = true;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.RowHeadersVisible = false;
            g.EnableHeadersVisualStyles = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 36;
            g.RowTemplate.Height = 30;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            g.GridColor = UiTheme.GridLine;

            g.ColumnHeadersDefaultCellStyle.BackColor = UiTheme.GridHeaderBack;
            g.ColumnHeadersDefaultCellStyle.ForeColor = UiTheme.TextSecondary;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = UiTheme.GridHeaderBack;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = UiTheme.TextSecondary;
            g.ColumnHeadersDefaultCellStyle.Font = UiTheme.FontBold;
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            g.DefaultCellStyle.BackColor = UiTheme.Surface;
            g.DefaultCellStyle.ForeColor = UiTheme.TextPrimary;
            g.DefaultCellStyle.SelectionBackColor = UiTheme.PrimarySoft;
            g.DefaultCellStyle.SelectionForeColor = UiTheme.TextPrimary;
            g.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            g.AlternatingRowsDefaultCellStyle.BackColor = UiTheme.GridAltRow;
            g.AlternatingRowsDefaultCellStyle.SelectionBackColor = UiTheme.PrimarySoft;
            g.AlternatingRowsDefaultCellStyle.SelectionForeColor = UiTheme.TextPrimary;
        }

        // 按定义的列把数据填进表格
        public static void BindGrid(DataGridView grid, System.Data.DataTable data, params GridColumn[] columns)
        {
            // 页面上还没有表格时就不绑，免得空引用报错
            if (grid == null) return;
            grid.DataSource = null;
            grid.Columns.Clear();

            foreach (var c in columns)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    Name = c.Property,
                    DataPropertyName = c.Property,
                    HeaderText = c.Header,
                    FillWeight = c.Weight,
                    MinimumWidth = 60,
                    SortMode = DataGridViewColumnSortMode.Automatic
                };
                if (c.Align == GridAlign.Right) col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (c.Align == GridAlign.Center) col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (!string.IsNullOrEmpty(c.Format)) col.DefaultCellStyle.Format = c.Format;
                grid.Columns.Add(col);
            }

            grid.DataSource = data;
            grid.ClearSelection();
        }

        // ---- 下面几个是帮忙摆控件位置的小助手 ----

        // 标签 + 控件成一组放上工具栏，放完 x 右移
        public static void AddFilter(Panel host, ref int x, int y, string label, Control ctl, int ctlWidth = 130)
        {
            int labelWidth = TextWidth(label, UiTheme.FontNormal) + 8;
            if (labelWidth < 40) labelWidth = 40;

            var lb = new Label
            {
                Text = label,
                AutoSize = false,
                Font = UiTheme.FontNormal,
                ForeColor = UiTheme.TextSecondary,
                TextAlign = ContentAlignment.MiddleRight,
                BackColor = Color.Transparent,
                Size = new Size(labelWidth, ctl.Height),
                Location = new Point(x, y)
            };

            ctl.Size = new Size(ctlWidth, ctl.Height);
            ctl.Location = new Point(x + labelWidth + 6, y);

            host.Controls.Add(lb);
            host.Controls.Add(ctl);
            x = x + labelWidth + 6 + ctlWidth + 16;
        }

        // 控件放上工具栏，放完 x 右移
        public static void AddToolbarControl(Panel host, ref int x, int y, Control ctl)
        {
            ctl.Location = new Point(x, y);
            host.Controls.Add(ctl);
            x += ctl.Width + 10;
        }

        // 卡片里的一个字段：左边标签右边输入框
        public static void AddField(Panel host, int x, int y, string label, Control ctl, int ctlWidth = 170)
        {
            string text = label + "：";
            int labelWidth = TextWidth(text, UiTheme.FontNormal) + 8;

            var lb = new Label
            {
                Text = text,
                AutoSize = false,
                Font = UiTheme.FontNormal,
                ForeColor = UiTheme.TextSecondary,
                TextAlign = ContentAlignment.MiddleRight,
                BackColor = Color.Transparent,
                Size = new Size(labelWidth, ctl.Height),
                Location = new Point(x, y)
            };

            ctl.Size = new Size(ctlWidth, ctl.Height);
            ctl.Location = new Point(x + labelWidth + 6, y);

            host.Controls.Add(lb);
            host.Controls.Add(ctl);
        }
    }

    // 表格里的某一列是靠左、居中还是靠右
    public enum GridAlign
    {
        Left,
        Center,
        Right
    }

    // 表格一列的定义：字段、表头、宽度、对齐
    public class GridColumn
    {
        public string Property;
        public string Header;
        public int Weight = 100;
        public GridAlign Align = GridAlign.Left;
        public string Format;

        public GridColumn(string property, string header, int weight = 100,
                          GridAlign align = GridAlign.Left, string format = null)
        {
            Property = property;
            Header = header;
            Weight = weight;
            Align = align;
            Format = format;
        }
    }
}
