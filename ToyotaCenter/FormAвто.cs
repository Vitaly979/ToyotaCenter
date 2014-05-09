using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToyotaCenter
{
    public partial class FormAвто : Form
    {
        public FormAвто()
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
                фотографияPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName);
            }
            else fileImage = "";
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private static FormAвто f;
        public static FormAвто fd
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAвто();
                return f;
            }
        }

        private void автоBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        int idCurrent = -1;
        public int ShowSelectForm(int idАвто, out decimal price)
        {
            idCurrent = idАвто;
            ShowDialog();
            price = (decimal)((DataRowView)автоBindingSource.Current)["цена"];
            return (int)((DataRowView)автоBindingSource.Current)["код_авто"];
        }

        public void ShowForm()
        {
            автоBindingSource.Position = 0;
            Show();
            Activate();
        }
        private void FormAвто_Shown(object sender, EventArgs e)
        {
            автоBindingSource.Position = автоBindingSource.Find("код_авто", idCurrent);
        }
    }
}
