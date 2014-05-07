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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void автоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mimimi6DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mimimi6DataSet.Авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.mimimi6DataSet.Авто);

        }
        string fileImage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фотографияPictureBox.Image = new
                Bitmap(openFileDialogPhoto.FileName);
            }
            else fileImage = "";
        }
        private static Form1 f;
        public static Form1 fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Form1();
                return f;
            }
        }

       
    }
}
