namespace ToyotaCenter
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.машиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.салонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.габаритыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двигательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестдрайвToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.link1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.продажиToolStripMenuItem,
            this.покупателиToolStripMenuItem,
            this.тестдрайвToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.AutoToolTip = true;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.clipboard_64px;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.ToolTipText = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.denied_64px;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeyDisplayString = "Alt+X";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.browser_64px;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeyDisplayString = "Alt+I";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.AutoSize = false;
            this.справочникиToolStripMenuItem.AutoToolTip = true;
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.машиныToolStripMenuItem,
            this.залыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.bookshelf_64px;
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.ToolTipText = "База данных";
            // 
            // машиныToolStripMenuItem
            // 
            this.машиныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.салонToolStripMenuItem,
            this.габаритыToolStripMenuItem,
            this.двигательToolStripMenuItem});
            this.машиныToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.car;
            this.машиныToolStripMenuItem.Name = "машиныToolStripMenuItem";
            this.машиныToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.машиныToolStripMenuItem.Text = "Машины";
            this.машиныToolStripMenuItem.Click += new System.EventHandler(this.машиныToolStripMenuItem_Click);
            // 
            // салонToolStripMenuItem
            // 
            this.салонToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.hotdog;
            this.салонToolStripMenuItem.Name = "салонToolStripMenuItem";
            this.салонToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.салонToolStripMenuItem.Text = "Салон";
            this.салонToolStripMenuItem.Click += new System.EventHandler(this.салонToolStripMenuItem_Click);
            // 
            // габаритыToolStripMenuItem
            // 
            this.габаритыToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.chalkboard;
            this.габаритыToolStripMenuItem.Name = "габаритыToolStripMenuItem";
            this.габаритыToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.габаритыToolStripMenuItem.Text = "Габариты";
            this.габаритыToolStripMenuItem.Click += new System.EventHandler(this.габаритыToolStripMenuItem_Click);
            // 
            // двигательToolStripMenuItem
            // 
            this.двигательToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.rocket;
            this.двигательToolStripMenuItem.Name = "двигательToolStripMenuItem";
            this.двигательToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.двигательToolStripMenuItem.Text = "Двигатель";
            this.двигательToolStripMenuItem.Click += new System.EventHandler(this.двигательToolStripMenuItem_Click);
            // 
            // залыToolStripMenuItem
            // 
            this.залыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem});
            this.залыToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.store;
            this.залыToolStripMenuItem.Name = "залыToolStripMenuItem";
            this.залыToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.залыToolStripMenuItem.Text = "Залы";
            this.залыToolStripMenuItem.Click += new System.EventHandler(this.залыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.bag_64px;
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.AutoToolTip = true;
            this.продажиToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources._;
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.ToolTipText = "сведения о продажах";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
            // 
            // покупателиToolStripMenuItem
            // 
            this.покупателиToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.skull;
            this.покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            this.покупателиToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.покупателиToolStripMenuItem.Text = "Покупатели";
            this.покупателиToolStripMenuItem.Click += new System.EventHandler(this.покупателиToolStripMenuItem_Click);
            // 
            // тестдрайвToolStripMenuItem
            // 
            this.тестдрайвToolStripMenuItem.Image = global::ToyotaCenter.Properties.Resources.mcfly;
            this.тестдрайвToolStripMenuItem.Name = "тестдрайвToolStripMenuItem";
            this.тестдрайвToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.тестдрайвToolStripMenuItem.Text = "Тест-драйв";
            this.тестдрайвToolStripMenuItem.Click += new System.EventHandler(this.тестдрайвToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
            this.файлToolStripMenuItem1.Image = global::ToyotaCenter.Properties.Resources.clipboard_64px;
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = global::ToyotaCenter.Properties.Resources.denied_64px;
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Image = global::ToyotaCenter.Properties.Resources.browser_64px;
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ToyotaCenter.Properties.Resources.denied_64px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Выход";
            this.toolStripButton1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::ToyotaCenter.Properties.Resources.browser_64px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "О программе";
            this.toolStripButton2.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // link1
            // 
            this.link1.ActiveLinkColor = System.Drawing.Color.ForestGreen;
            this.link1.AutoSize = true;
            this.link1.LinkColor = System.Drawing.Color.MidnightBlue;
            this.link1.Location = new System.Drawing.Point(288, 45);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(105, 13);
            this.link1.TabIndex = 3;
            this.link1.TabStop = true;
            this.link1.Tag = "http://www.toyota.ru/";
            this.link1.Text = "Официальный сайт";
            this.link1.VisitedLinkColor = System.Drawing.Color.SeaGreen;
            this.link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Данная база предоставлена \r\nв учебных целях и не является \r\nреальным отображением" +
                " \r\nдействительности.\r\nВсе совпадения с реальностью\r\nслучайны\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "Лабораторная работа №2\r\nБезопасность систем\r\nбаз данных\r\n2014 Томск";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ToyotaCenter.Properties.Resources.Toyota_novoct;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 170);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(447, 232);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.link1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::ToyotaCenter.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::ToyotaCenter.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Тойота Центр Томск";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem машиныToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem салонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem габаритыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двигательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестдрайвToolStripMenuItem;
    }
}

