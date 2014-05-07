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
    }
}
