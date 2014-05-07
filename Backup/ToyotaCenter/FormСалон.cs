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
    public partial class FormСалон : Form
    {
        public FormСалон()
        {
            InitializeComponent();
        }

        private void салонBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.салонBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormСалон_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Салон". При необходимости она может быть перемещена или удалена.
            this.салонTableAdapter.Fill(this.mimimi6DataSet.Салон);

        }
    }
}
