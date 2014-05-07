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
    public partial class FormЗалы : Form
    {
        public FormЗалы()
        {
            InitializeComponent();
        }

        private void залыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.залыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormЗалы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.mimimi6DataSet.залы);

        }
    }
}
