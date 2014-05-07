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
    public partial class FormТД : Form
    {
        public FormТД()
        {
            InitializeComponent();
        }

        private void тест_драйвBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тест_драйвBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormТД_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Тест_драйв". При необходимости она может быть перемещена или удалена.
            this.тест_драйвTableAdapter.Fill(this.mimimi6DataSet.Тест_драйв);

        }
    }
}
