using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace XiaoxinPropertyManager.Common
{
    // 编辑弹窗里一个字段能是什么类型
    public enum FieldKind
    {
        Text,
        Password,
        Multiline,
        Number,
        Combo,
        Date,
        ReadOnly,
        ReadOnlyMultiline
    }

    // 描述弹窗里的一个字段
    public class FieldDef
    {
        public string Key;
        public string Label;
        public string Value;
        public FieldKind Kind = FieldKind.Text;
        public string[] Items;
        public bool Required;
    }

    // 通用编辑弹窗，新增修改都用它
    // 用法：Add* 加字段 → ShowDialog() → Value("字段名") 取值
    public class EditDialog : Form
    {
        private const int LeftMargin = 24;
        private const int LabelWidth = 92;
        private const int ControlWidth = 340;
        private const int RowStep = 34;
        private const int FooterHeight = 58;

        private readonly List<FieldDef> _fields = new List<FieldDef>();
        private readonly Dictionary<string, Control> _controls = new Dictionary<string, Control>();
        private readonly int _headerHeight;
        private Button _extraButton;

        private int _cursorY;

        public EditDialog(string title, string subtitle = null)
        {
            Text = title;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            BackColor = UiTheme.Surface;
            Font = UiTheme.FontNormal;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(LeftMargin * 2 + LabelWidth + 6 + ControlWidth, 200);

            var titleLabel = new Label
            {
                Text = title,
                Font = UiTheme.FontTitle,
                ForeColor = UiTheme.TextPrimary,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(LeftMargin, 18)
            };
            Controls.Add(titleLabel);

            _headerHeight = 62;
            if (!string.IsNullOrEmpty(subtitle))
            {
                var sub = new Label
                {
                    Text = subtitle,
                    Font = UiTheme.FontNormal,
                    ForeColor = UiTheme.TextSecondary,
                    BackColor = Color.Transparent,
                    AutoSize = true,
                    Location = new Point(LeftMargin, 44)
                };
                Controls.Add(sub);
                _headerHeight = 86;
            }

            _cursorY = _headerHeight;

            // 取消和确定这两个按钮
            var btnCancel = Ui.NewButton("取消");
            btnCancel.Click += delegate { DialogResult = DialogResult.Cancel; };
            var btnOk = Ui.NewButton("确定", 0, true);
            btnOk.Click += BtnOkClick;

            // 位置要等窗口高度算出来才知道，先加进来，OnLoad 时再摆
            Controls.Add(btnCancel);
            Controls.Add(btnOk);

            AcceptButton = btnOk;
            CancelButton = btnCancel;
        }

        // ---- 下面这些方法都是往弹窗里加字段用的 ----

        // 普通的一段文字
        public EditDialog AddText(string key, string label, string value = "", bool required = false, int width = ControlWidth)
        {
            AddField(new FieldDef { Key = key, Label = label, Value = value, Kind = FieldKind.Text, Required = required }, width, 0);
            return this;
        }

        // 密码输入
        public EditDialog AddPassword(string key, string label, string value = "", bool required = false, int width = ControlWidth)
        {
            AddField(new FieldDef { Key = key, Label = label, Value = value, Kind = FieldKind.Password, Required = required }, width, 0);
            return this;
        }

        // 数字输入，提交时检查能不能转小数
        public EditDialog AddNumber(string key, string label, string value = "", bool required = false, int width = ControlWidth)
        {
            AddField(new FieldDef { Key = key, Label = label, Value = value, Kind = FieldKind.Number, Required = required }, width, 0);
            return this;
        }

        // 多行文本
        public EditDialog AddMultiline(string key, string label, string value = "", bool required = false, int height = 88)
        {
            AddField(new FieldDef { Key = key, Label = label, Value = value, Kind = FieldKind.Multiline, Required = required }, ControlWidth, height);
            return this;
        }

        // 下拉选择
        public EditDialog AddCombo(string key, string label, string[] items, string value = null, bool required = true, int width = ControlWidth)
        {
            AddField(new FieldDef { Key = key, Label = label, Value = value, Kind = FieldKind.Combo, Items = items, Required = required }, width, 0);
            return this;
        }

        // 选日期和时间
        public EditDialog AddDate(string key, string label, DateTime? value = null, bool required = false, int width = ControlWidth)
        {
            var def = new FieldDef { Key = key, Label = label, Kind = FieldKind.Date, Required = required };
            def.Value = (value ?? DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");
            AddField(def, width, 0);
            return this;
        }

        // 只读显示，不让改的内容
        public EditDialog AddReadOnly(string key, string label, string value = "", int width = ControlWidth)
        {
            AddField(new FieldDef { Key = key, Label = label, Value = value, Kind = FieldKind.ReadOnly }, width, 0);
            return this;
        }

        // 只读的多行文字，比如公告正文
        public EditDialog AddReadOnlyText(string key, string label, string value = "", int height = 140)
        {
            AddField(new FieldDef { Key = key, Label = label, Value = value, Kind = FieldKind.ReadOnlyMultiline }, ControlWidth, height);
            return this;
        }

        private void AddField(FieldDef def, int controlWidth, int multilineHeight)
        {
            Control ctl;
            switch (def.Kind)
            {
                case FieldKind.Password:
                    ctl = Ui.NewPassword(controlWidth, def.Value);
                    break;
                case FieldKind.Multiline:
                    ctl = Ui.NewInput(controlWidth, def.Value, true, multilineHeight > 0 ? multilineHeight : 88);
                    break;
                case FieldKind.Number:
                    ctl = Ui.NewInput(controlWidth, def.Value);
                    break;
                case FieldKind.Combo:
                    ctl = Ui.NewCombo(controlWidth, def.Items, def.Value);
                    break;
                case FieldKind.Date:
                    DateTime parsed;
                    DateTime dt = DateTime.TryParse(def.Value, out parsed) ? parsed : DateTime.Now;
                    ctl = Ui.NewDatePicker(controlWidth, dt);
                    break;
                case FieldKind.ReadOnly:
                    ctl = Ui.NewReadOnlyInput(controlWidth, def.Value);
                    break;
                case FieldKind.ReadOnlyMultiline:
                    var readOnlyBox = Ui.NewInput(controlWidth, def.Value, true, multilineHeight > 0 ? multilineHeight : 120);
                    readOnlyBox.ReadOnly = true;
                    readOnlyBox.BackColor = Color.FromArgb(248, 249, 251);
                    readOnlyBox.ForeColor = UiTheme.TextPrimary;
                    ctl = readOnlyBox;
                    break;
                default:
                    ctl = Ui.NewInput(controlWidth, def.Value);
                    break;
            }

            bool isMultiline = def.Kind == FieldKind.Multiline || def.Kind == FieldKind.ReadOnlyMultiline;

            // 必填标签用深色，非必填用浅灰
            var lb = new Label
            {
                Text = def.Label + (def.Required ? " *" : "") + "：",
                AutoSize = false,
                Font = def.Required ? UiTheme.FontNormal : UiTheme.FontNormal,
                ForeColor = def.Required ? UiTheme.TextPrimary : UiTheme.TextSecondary,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(LabelWidth, ctl.Height),
                Location = new Point(LeftMargin, _cursorY + (ctl.Height - UiTheme.RowHeight) / 2)
            };

            if (isMultiline)
            {
                lb.Location = new Point(LeftMargin, _cursorY + 2);
            }

            ctl.Location = new Point(LeftMargin + LabelWidth + 6, _cursorY);

            Controls.Add(lb);
            Controls.Add(ctl);

            _fields.Add(def);
            _controls[def.Key] = ctl;

            _cursorY += isMultiline ? ctl.Height + 12 : RowStep;
        }

        // ---- 下面这些是往外取值的 ----

        // 在左下角再单独放一个按钮，比如“详情”窗口里那个“修改”。
        // 要在 ShowDialog 之前调用才行
        public EditDialog AddExtraButton(Button button)
        {
            Controls.Add(button);
            _extraButton = button;
            return this;
        }

        // 取出某个字段里填的值
        public string Value(string key)
        {
            Control ctl;
            if (!_controls.TryGetValue(key, out ctl)) return string.Empty;

            var combo = ctl as ComboBox;
            if (combo != null) return combo.SelectedItem == null ? string.Empty : combo.SelectedItem.ToString();

            var picker = ctl as DateTimePicker;
            if (picker != null) return picker.Value.ToString("yyyy-MM-dd HH:mm:ss");

            return ctl.Text.Trim();
        }

        // 取数字，转不过来返回 0
        public decimal ValueDecimal(string key)
        {
            return DbHelper.ToDecimal(Value(key), 0m);
        }

        // 取整数，转不过来返回 0
        public int ValueInt(string key)
        {
            return DbHelper.ToInt(Value(key), 0);
        }

        // 取日期字段
        public DateTime ValueDate(string key)
        {
            DateTime dt;
            if (DateTime.TryParse(Value(key), out dt)) return dt;
            return DateTime.Now;
        }

        // ---- 下面是算控件位置和检查有没有填错的 ----

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            int height = _cursorY + 16 + FooterHeight;
            ClientSize = new Size(ClientSize.Width, height);
            LayoutButtons();
        }

        private void LayoutButtons()
        {
            // 加的顺序是取消在前、确定在后
            var buttons = new List<Button>();
            foreach (Control c in Controls)
            {
                var b = c as Button;
                if (b != null && b != _extraButton) buttons.Add(b);
            }
            if (buttons.Count < 2) return;

            Button cancel = buttons[0];
            Button ok = buttons[1];
            int top = ClientSize.Height - FooterHeight + 16;
            ok.Location = new Point(ClientSize.Width - LeftMargin - ok.Width, top);
            cancel.Location = new Point(ok.Left - 10 - cancel.Width, top);

            if (_extraButton != null)
            {
                _extraButton.Location = new Point(LeftMargin, top);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 头和底各画一条浅色分割线
            using (var pen = new Pen(UiTheme.BorderLight))
            {
                e.Graphics.DrawLine(pen, 0, _headerHeight - 12, Width, _headerHeight - 12);
                e.Graphics.DrawLine(pen, 0, ClientSize.Height - FooterHeight + 1, Width, ClientSize.Height - FooterHeight + 1);
            }
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            string error;
            Control focus;
            if (!ValidateInput(out error, out focus))
            {
                MessageBox.Show(this, error, "请检查填写内容", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (focus != null) focus.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private bool ValidateInput(out string error, out Control focus)
        {
            error = null;
            focus = null;

            foreach (var def in _fields)
            {
                string value = Value(def.Key);

                if (def.Required && string.IsNullOrEmpty(value))
                {
                    error = "“" + def.Label + "”不能为空。";
                    focus = _controls[def.Key];
                    return false;
                }

                if (string.IsNullOrEmpty(value)) continue;

                if (def.Kind == FieldKind.Number)
                {
                    decimal number;
                    if (!decimal.TryParse(value, out number))
                    {
                        error = "“" + def.Label + "”必须是数字。";
                        focus = _controls[def.Key];
                        return false;
                    }
                    if (number < 0)
                    {
                        error = "“" + def.Label + "”不能为负数。";
                        focus = _controls[def.Key];
                        return false;
                    }
                }

                // 电话只检查长度，太短就是填错了
                if (def.Label.IndexOf("电话", StringComparison.Ordinal) >= 0 ||
                    def.Label.IndexOf("手机", StringComparison.Ordinal) >= 0)
                {
                    string digits = value.Replace("-", string.Empty).Replace(" ", string.Empty);
                    if (digits.Length < 7)
                    {
                        error = "“" + def.Label + "”格式不正确。";
                        focus = _controls[def.Key];
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
