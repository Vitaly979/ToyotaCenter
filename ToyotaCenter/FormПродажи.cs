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
    public partial class FormПродажи : Form
    {
        public FormПродажи()
        {
            InitializeComponent();
        }

        private void продажиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продажиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormПродажи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.mimimi6DataSet.Продажи);

        }
    }
}
