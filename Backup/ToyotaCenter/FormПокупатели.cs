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
    public partial class FormПокупатели : Form
    {
        public FormПокупатели()
        {
            InitializeComponent();
        }

        private void покупатель_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупатель_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void FormПокупатели_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet._Покупатель_". При необходимости она может быть перемещена или удалена.
            this.покупатель_TableAdapter.Fill(this.mimimi6DataSet._Покупатель_);

        }
    }
}
