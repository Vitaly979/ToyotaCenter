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
            LoadPhotoFromDb();
        }
        string fileImage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фотографияPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName);
                test(фотографияPictureBox.Image);
            }
            else fileImage = "";
        }

        private void test(Image img)
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vitaly\Downloads\ToyotaCenter\ToyotaCenter\mimimi6.mdf;Integrated Security=True;Connect Timeout=30"))
            //{
            //    con.Open();
            //    using (SqlCommand cmd = con.CreateCommand())
            //    {
            //        cmd.Parameters.AddWithValue("@Photo", imageToByteArray(img));
            //        cmd.Parameters.AddWithValue("@AutoCode", код_автоTextBox.Text);
            //        cmd.Parameters["@Photo"].SqlDbType = SqlDbType.Image;
            //        cmd.Parameters["@AutoCode"].SqlDbType = SqlDbType.Int;
            //        cmd.CommandText = @"UPDATE АВТО SET Фото=@Photo WHERE Код_авто = @AutoCode";
            //        cmd.ExecuteNonQuery();
            //    }
            //}
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

        private void LoadPhotoFromDb()
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vitaly\Downloads\ToyotaCenter\ToyotaCenter\mimimi6.mdf;Integrated Security=True;Connect Timeout=30"))
            //{
            //    con.Open();
            //    var dict = new Dictionary<string, Image>();
            //    using (SqlCommand cmd = con.CreateCommand())
            //    {
            //        cmd.Parameters.AddWithValue("@AutoCode", код_автоTextBox.Text);
            //        cmd.Parameters["@AutoCode"].SqlDbType = SqlDbType.Int;
            //        cmd.CommandText = @"SELECT Фото FROM АВТО WHERE Код_авто = @AutoCode";
            //        var reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            for (int i = 0; i < reader.FieldCount; i++)
            //            {
            //                var a = reader.GetName(i);
            //                var b = reader[i];
            //                dict.Add(a, byteArrayToImage((byte[])b));
            //            }
            //        }
            //    }
            //    фотографияPictureBox.Image = dict.First().Value;
            //}
        }

        private void код_автоTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadPhotoFromDb();
        }  
    }
}
