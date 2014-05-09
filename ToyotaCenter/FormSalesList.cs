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
    public partial class FormSalesList : Form
    {
        public FormSalesList()
        {
            InitializeComponent();
        }
        private void buttonWorker_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)продажиBindingSource.Current)["код_сотрудника"].ToString() != "")
            {
                id = (int)(((DataRowView)продажиBindingSource.Current)["код_сотрудника"]);
            }
            id = FormСотрудники.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)продажиBindingSource.Current)["код_сотрудника"] = id;
                продажиBindingSource.EndEdit();
                сотрудникиTableAdapter.Fill(this.mimimi6DataSet.Сотрудники);
            }
        }

        private void продажиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    this.Validate();
                    this.продажиBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка при заполнении продажи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //this.Validate();
                //this.продажиBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

            }
        }
        private void проданоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.проданоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);
        }

        private void FormSalesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.mimimi6DataSet.Авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.mimimi6DataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Продано". При необходимости она может быть перемещена или удалена.
            this.проданоTableAdapter.Fill(this.mimimi6DataSet.Продано);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.mimimi6DataSet.Продажи);
            mimimi6DataSet.Продажи.Columns["Дата"].DefaultValue = DateTime.Now;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        static FormSalesList f;
        static public FormSalesList fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSalesList();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return проданоDataGridView.Columns[проданоDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void проданоDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.Compare(GetSelectedFieldName(), "Об_авто", false) == 0)
            {
                decimal price = 0;
                int idАвтоCurrent = -1;
                int.TryParse((((DataRowView)проданоBindingSource.Current)["код_авто"]).ToString(), out idАвтоCurrent);
                int idАвто = FormAвто.fd.ShowSelectForm(idАвтоCurrent, out price);
                //MessageBox.Show("Код авто=" + idАвто.ToString());
                ((DataRowView)проданоBindingSource.Current)["код_авто"] = idАвто;
                ((DataRowView)проданоBindingSource.Current)["цена"] = price;
                проданоBindingSource.EndEdit();
                проданоTableAdapter.Update(this.mimimi6DataSet);
                автоTableAdapter.Fill(this.mimimi6DataSet.Авто);
            }
        }

        //private void buttonWorker_Click(object sender, EventArgs e)
        //{
        //    FormСотрудники fd = new FormСотрудники();
        //    fd.Show();
        //}
    }
}
