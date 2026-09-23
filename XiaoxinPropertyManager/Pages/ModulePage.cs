using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using XiaoxinPropertyManager.Common;

namespace XiaoxinPropertyManager.Pages
{
    // 所有功能页面的公共逻辑：数据加载、表格绑定、提示框都放在这里
    // 界面骨架在各个页面自己的 Designer 文件里，这里按控件名去找着用
    public partial class ModulePage : UserControl
    {
        private bool _uiReady;
        private bool _gridHooked;
        private DataGridView _grid;

        // 界面由页面自己的 Designer 负责，基类不用再画什么
        public ModulePage()
        {
        }

        // 按名字在页面里找控件（Designer 里每个控件都设了 Name）
        private Control FindByName(string name)
        {
            Control[] found = Controls.Find(name, true);
            return found.Length > 0 ? found[0] : null;
        }

        // 页面的数据表格，按名字找到后记下来
        protected DataGridView Grid
        {
            get
            {
                if (_grid == null && !IsDisposed)
                    _grid = FindByName("gridMain") as DataGridView;
                return _grid;
            }
        }

        // ---- 页面加载的大致流程 ----

        // 重新加载页面数据，主窗体显示页面后调用
        public void Reload()
        {
            if (IsDisposed || DesignMode) return;

            try
            {
                BuildOnce();
                LoadData();
            }
            catch (Exception ex)
            {
                SetStatus("数据加载失败");
                ShowError(ex);
            }
        }

        private void BuildOnce()
        {
            if (_uiReady) return;
            _uiReady = true;

            if (Grid != null && !_gridHooked)
            {
                _gridHooked = true;
                Ui.StyleGrid(Grid);
                Grid.CellDoubleClick += delegate(object s, DataGridViewCellEventArgs e)
                {
                    if (e.RowIndex >= 0) OnDoubleClickRow();
                };
            }
        }

        // 子类在这里查数据，查完调一下 Bind
        protected virtual void LoadData()
        {
        }

        // 表格双击行的动作，子类可重写
        protected virtual void OnDoubleClickRow()
        {
        }

        // ---- 把数据填到表格里 ----

        // 把数据填到表格里
        protected void Bind(DataTable data, params GridColumn[] columns)
        {
            Ui.BindGrid(Grid, data, columns);
            SetStatus("共 " + data.Rows.Count + " 条记录");
            OnDataBound(data);
        }

        // 数据填完后可在这里更新合计
        protected virtual void OnDataBound(DataTable data)
        {
        }

        protected void SetStatus(string text)
        {
            var lbl = FindByName("StatusLabel") as Label;
            if (lbl != null) lbl.Text = text;
        }

        // 把状态栏右边的字换掉
        protected void SetFooterSummary(string text, Color? color = null)
        {
            var footer = FindByName("FooterRight") as FlowLayoutPanel;
            if (footer == null) return;

            footer.Controls.Clear();
            footer.Controls.Add(new Label
            {
                Text = text,
                Font = UiTheme.FontSmall,
                ForeColor = color ?? UiTheme.TextSecondary,
                BackColor = Color.Transparent,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 0)
            });

            // 这块是贴着右边的，宽度要按文字实算，不然右边的字会被切掉
            footer.Width = TextRenderer.MeasureText(text, UiTheme.FontSmall).Width
                                + footer.Padding.Left + footer.Padding.Right;
        }

        // ---- 当前选中的那一行 ----

        // 当前行的 DataRowView，没选就是 null
        protected DataRowView CurrentRow
        {
            get
            {
                if (Grid == null || Grid.CurrentRow == null) return null;
                return Grid.CurrentRow.DataBoundItem as DataRowView;
            }
        }

        // 取当前行某一列的整数
        protected int SelectedId(string columnName)
        {
            var row = CurrentRow;
            if (row == null || !row.DataView.Table.Columns.Contains(columnName)) return 0;
            object value = row[columnName];
            if (value == null || value == DBNull.Value) return 0;
            return Convert.ToInt32(value);
        }

        // 取当前行某一列的文字
        protected string SelectedText(string columnName)
        {
            var row = CurrentRow;
            if (row == null || !row.DataView.Table.Columns.Contains(columnName)) return string.Empty;
            object value = row[columnName];
            if (value == null || value == DBNull.Value) return Convert.ToString(value);
            return Convert.ToString(value);
        }

        // 要求选中一行，没选就提示
        protected bool RequireSelection(out DataRowView row)
        {
            row = CurrentRow;
            if (row == null)
            {
                MessageBox.Show(this, "请先在列表中选择一条记录。", "操作提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        // ---- 几个常用的小操作 ----

        protected void ShowError(Exception ex)
        {
            MessageBox.Show(this, DbHelper.FriendlyMessage(ex), "操作失败",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void Info(string message)
        {
            MessageBox.Show(this, message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void Warn(string message)
        {
            MessageBox.Show(this, message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool Confirm(string message)
        {
            return MessageBox.Show(this, message, "请确认",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        // 统一处理增删改：执行完提示，再刷新列表
        protected bool Run(Action action, string successMessage = null)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                ShowError(ex);
                return false;
            }

            if (!string.IsNullOrEmpty(successMessage)) Info(successMessage);
            Reload();
            return true;
        }

        // 下拉框选项，最前面加“全部”
        protected static string[] WithAll(string allText, params string[] items)
        {
            var result = new string[items.Length + 1];
            result[0] = allText;
            Array.Copy(items, 0, result, 1, items.Length);
            return result;
        }

        // 选“全部”就返回空字符串，等于不过滤
        protected static string FilterValue(ComboBox combo, string allText)
        {
            if (combo == null || combo.SelectedItem == null) return string.Empty;
            string value = combo.SelectedItem.ToString();
            return value == allText ? string.Empty : value;
        }
    }
}
