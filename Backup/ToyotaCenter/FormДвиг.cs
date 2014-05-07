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
    public partial class FormДвиг : Form
    {
        public FormДвиг()
        {
            InitializeComponent();
        }

        private void двигательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.двигательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormДвиг_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Двигатель". При необходимости она может быть перемещена или удалена.
            this.двигательTableAdapter.Fill(this.mimimi6DataSet.Двигатель);

        }
    }
}
