using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToyotaCenter
{
    public partial class FormСотрудники : Form
    {
        public FormСотрудники()
        {
            InitializeComponent();
            toolStripButtonOK.Visible = false;
            сотрудникиBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormСотрудники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.mimimi6DataSet.Сотрудники);

        }
        
        private void сотрудникиDataGridView_CellFormatting(object sender,
DataGridViewCellFormattingEventArgs e)
{
if
((сотрудникиDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value == null) ||
(сотрудникиDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() == ""))
    e.CellStyle.BackColor = Color.LightGreen;
else
{
if
(сотрудникиDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumnPol"].Value.ToString() == "М")
    e.CellStyle.BackColor = Color.SkyBlue;
else
    e.CellStyle.BackColor = Color.Pink;
}
}
        string GetSelectedFieldName()
        {
            return сотрудникиDataGridView.Columns[сотрудникиDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = сотрудникиBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                сотрудникиBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                сотрудникиBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        сотрудникиBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                    }
            }
            else
                сотрудникиBindingSource.Filter = "";
            if (сотрудникиBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                сотрудникиBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }


        private void сотрудникиBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //переменная для текущего(выбранного) кода сотрудника
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return (int)((DataRowView)сотрудникиBindingSource.Current)["код_сотрудника"];
            else
                return -1;
        }
        private void FormСотрудники_Shown(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Position = сотрудникиBindingSource.Find("код_сотрудника", idCurrent);
        }

        private static FormСотрудники f;
        public static FormСотрудники fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormСотрудники();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
