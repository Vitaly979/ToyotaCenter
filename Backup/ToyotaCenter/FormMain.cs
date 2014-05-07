using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToyotaCenter.Properties;

namespace ToyotaCenter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС\nБардамова Марина\nКовалёв Виталий\nСоболинский Антон\nгруппа 722, 2014", "О программе",
MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void машиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.fd.Show();
        }

        
        private void салонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormСалон fd = new FormСалон();
            fd.Show();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormПродажи fd = new FormПродажи();
            fd.Show();
        }

        private void link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.toyota.ru/");
        }

        private void габаритыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormГабариты fd = new FormГабариты();
            fd.Show();
        }

        private void двигательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormДвиг fd = new FormДвиг();
            fd.Show();
        }

        private void залыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormЗалы fd = new FormЗалы();
            fd.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormСотрудники fd = new FormСотрудники();
            fd.Show();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormПокупатели fd = new FormПокупатели();
            fd.Show();
        }

        private void тестдрайвToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormТД fd = new FormТД();
            fd.Show();
        }
        
        

        

        

       
    }
}
