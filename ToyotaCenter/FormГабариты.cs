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
    public partial class FormГабариты : Form
    {
        public FormГабариты()
        {
            InitializeComponent();
        }

        private void габаритыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.габаритыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormГабариты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Габариты". При необходимости она может быть перемещена или удалена.
            this.габаритыTableAdapter.Fill(this.mimimi6DataSet.Габариты);

        }
    }
}
