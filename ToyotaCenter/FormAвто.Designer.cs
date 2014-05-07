namespace ToyotaCenter
{
    partial class FormAвто
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_автоLabel;
            System.Windows.Forms.Label производительLabel;
            System.Windows.Forms.Label модельLabel;
            System.Windows.Forms.Label типLabel;
            System.Windows.Forms.Label год_выпускаLabel;
            System.Windows.Forms.Label цвет_кузоваLabel;
            System.Windows.Forms.Label кППLabel;
            System.Windows.Forms.Label приводLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label код_двигателяLabel;
            System.Windows.Forms.Label фотографияLabel;
            System.Windows.Forms.Label дискиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAвто));
            this.автоBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.автоBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_автоTextBox = new System.Windows.Forms.TextBox();
            this.производительTextBox = new System.Windows.Forms.TextBox();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.год_выпускаTextBox = new System.Windows.Forms.TextBox();
            this.цвет_кузоваTextBox = new System.Windows.Forms.TextBox();
            this.кППTextBox = new System.Windows.Forms.TextBox();
            this.приводTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.код_двигателяTextBox = new System.Windows.Forms.TextBox();
            this.фотографияPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.дискиTextBox = new System.Windows.Forms.TextBox();
            this.автоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mimimi6DataSet = new ToyotaCenter.mimimi6DataSet();
            this.автоTableAdapter = new ToyotaCenter.mimimi6DataSetTableAdapters.АвтоTableAdapter();
            this.tableAdapterManager = new ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager();
            this.автоBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            код_автоLabel = new System.Windows.Forms.Label();
            производительLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            год_выпускаLabel = new System.Windows.Forms.Label();
            цвет_кузоваLabel = new System.Windows.Forms.Label();
            кППLabel = new System.Windows.Forms.Label();
            приводLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            код_двигателяLabel = new System.Windows.Forms.Label();
            фотографияLabel = new System.Windows.Forms.Label();
            дискиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingNavigator)).BeginInit();
            this.автоBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_автоLabel
            // 
            код_автоLabel.AutoSize = true;
            код_автоLabel.Location = new System.Drawing.Point(25, 42);
            код_автоLabel.Name = "код_автоLabel";
            код_автоLabel.Size = new System.Drawing.Size(55, 13);
            код_автоLabel.TabIndex = 1;
            код_автоLabel.Text = "Код авто:";
            // 
            // производительLabel
            // 
            производительLabel.AutoSize = true;
            производительLabel.Location = new System.Drawing.Point(25, 68);
            производительLabel.Name = "производительLabel";
            производительLabel.Size = new System.Drawing.Size(89, 13);
            производительLabel.TabIndex = 3;
            производительLabel.Text = "Производитель:";
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.Location = new System.Drawing.Point(25, 94);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(49, 13);
            модельLabel.TabIndex = 5;
            модельLabel.Text = "Модель:";
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Location = new System.Drawing.Point(25, 120);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(29, 13);
            типLabel.TabIndex = 7;
            типLabel.Text = "Тип:";
            // 
            // год_выпускаLabel
            // 
            год_выпускаLabel.AutoSize = true;
            год_выпускаLabel.Location = new System.Drawing.Point(25, 146);
            год_выпускаLabel.Name = "год_выпускаLabel";
            год_выпускаLabel.Size = new System.Drawing.Size(74, 13);
            год_выпускаLabel.TabIndex = 9;
            год_выпускаLabel.Text = "Год выпуска:";
            // 
            // цвет_кузоваLabel
            // 
            цвет_кузоваLabel.AutoSize = true;
            цвет_кузоваLabel.Location = new System.Drawing.Point(25, 172);
            цвет_кузоваLabel.Name = "цвет_кузоваLabel";
            цвет_кузоваLabel.Size = new System.Drawing.Size(73, 13);
            цвет_кузоваLabel.TabIndex = 11;
            цвет_кузоваLabel.Text = "Цвет кузова:";
            // 
            // кППLabel
            // 
            кППLabel.AutoSize = true;
            кППLabel.Location = new System.Drawing.Point(25, 198);
            кППLabel.Name = "кППLabel";
            кППLabel.Size = new System.Drawing.Size(33, 13);
            кППLabel.TabIndex = 13;
            кППLabel.Text = "КПП:";
            // 
            // приводLabel
            // 
            приводLabel.AutoSize = true;
            приводLabel.Location = new System.Drawing.Point(25, 224);
            приводLabel.Name = "приводLabel";
            приводLabel.Size = new System.Drawing.Size(48, 13);
            приводLabel.TabIndex = 15;
            приводLabel.Text = "Привод:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(25, 250);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 19;
            ценаLabel.Text = "Цена:";
            // 
            // код_двигателяLabel
            // 
            код_двигателяLabel.AutoSize = true;
            код_двигателяLabel.Location = new System.Drawing.Point(25, 276);
            код_двигателяLabel.Name = "код_двигателяLabel";
            код_двигателяLabel.Size = new System.Drawing.Size(84, 13);
            код_двигателяLabel.TabIndex = 21;
            код_двигателяLabel.Text = "Код двигателя:";
            // 
            // фотографияLabel
            // 
            фотографияLabel.AutoSize = true;
            фотографияLabel.Location = new System.Drawing.Point(234, 77);
            фотографияLabel.Name = "фотографияLabel";
            фотографияLabel.Size = new System.Drawing.Size(75, 13);
            фотографияLabel.TabIndex = 23;
            фотографияLabel.Text = "Фотография:";
            // 
            // дискиLabel
            // 
            дискиLabel.AutoSize = true;
            дискиLabel.Location = new System.Drawing.Point(25, 303);
            дискиLabel.Name = "дискиLabel";
            дискиLabel.Size = new System.Drawing.Size(43, 13);
            дискиLabel.TabIndex = 25;
            дискиLabel.Text = "Диски:";
            // 
            // автоBindingNavigator
            // 
            this.автоBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.автоBindingNavigator.BindingSource = this.автоBindingSource;
            this.автоBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.автоBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.автоBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.автоBindingNavigatorSaveItem});
            this.автоBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.автоBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.автоBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.автоBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.автоBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.автоBindingNavigator.Name = "автоBindingNavigator";
            this.автоBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.автоBindingNavigator.Size = new System.Drawing.Size(379, 25);
            this.автоBindingNavigator.TabIndex = 0;
            this.автоBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // автоBindingNavigatorSaveItem
            // 
            this.автоBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.автоBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("автоBindingNavigatorSaveItem.Image")));
            this.автоBindingNavigatorSaveItem.Name = "автоBindingNavigatorSaveItem";
            this.автоBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.автоBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.автоBindingNavigatorSaveItem.Click += new System.EventHandler(this.автоBindingNavigatorSaveItem_Click);
            // 
            // код_автоTextBox
            // 
            this.код_автоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Код_авто", true));
            this.код_автоTextBox.Location = new System.Drawing.Point(120, 39);
            this.код_автоTextBox.Name = "код_автоTextBox";
            this.код_автоTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_автоTextBox.TabIndex = 2;
            this.код_автоTextBox.TextChanged += new System.EventHandler(this.код_автоTextBox_TextChanged);
            // 
            // производительTextBox
            // 
            this.производительTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Производитель", true));
            this.производительTextBox.Location = new System.Drawing.Point(120, 65);
            this.производительTextBox.Name = "производительTextBox";
            this.производительTextBox.Size = new System.Drawing.Size(100, 20);
            this.производительTextBox.TabIndex = 4;
            // 
            // модельTextBox
            // 
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(120, 91);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(100, 20);
            this.модельTextBox.TabIndex = 6;
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(120, 117);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(100, 20);
            this.типTextBox.TabIndex = 8;
            // 
            // год_выпускаTextBox
            // 
            this.год_выпускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Год_выпуска", true));
            this.год_выпускаTextBox.Location = new System.Drawing.Point(120, 143);
            this.год_выпускаTextBox.Name = "год_выпускаTextBox";
            this.год_выпускаTextBox.Size = new System.Drawing.Size(100, 20);
            this.год_выпускаTextBox.TabIndex = 10;
            // 
            // цвет_кузоваTextBox
            // 
            this.цвет_кузоваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Цвет_кузова", true));
            this.цвет_кузоваTextBox.Location = new System.Drawing.Point(120, 169);
            this.цвет_кузоваTextBox.Name = "цвет_кузоваTextBox";
            this.цвет_кузоваTextBox.Size = new System.Drawing.Size(100, 20);
            this.цвет_кузоваTextBox.TabIndex = 12;
            // 
            // кППTextBox
            // 
            this.кППTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "КПП", true));
            this.кППTextBox.Location = new System.Drawing.Point(120, 195);
            this.кППTextBox.Name = "кППTextBox";
            this.кППTextBox.Size = new System.Drawing.Size(100, 20);
            this.кППTextBox.TabIndex = 14;
            // 
            // приводTextBox
            // 
            this.приводTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Привод", true));
            this.приводTextBox.Location = new System.Drawing.Point(120, 221);
            this.приводTextBox.Name = "приводTextBox";
            this.приводTextBox.Size = new System.Drawing.Size(100, 20);
            this.приводTextBox.TabIndex = 16;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Цена", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.ценаTextBox.Location = new System.Drawing.Point(120, 247);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 20;
            // 
            // код_двигателяTextBox
            // 
            this.код_двигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Код_двигателя", true));
            this.код_двигателяTextBox.Location = new System.Drawing.Point(120, 273);
            this.код_двигателяTextBox.Name = "код_двигателяTextBox";
            this.код_двигателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_двигателяTextBox.TabIndex = 22;
            // 
            // фотографияPictureBox
            // 
            this.фотографияPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.автоBindingSource, "Фото", true));
            this.фотографияPictureBox.Location = new System.Drawing.Point(241, 98);
            this.фотографияPictureBox.Name = "фотографияPictureBox";
            this.фотографияPictureBox.Size = new System.Drawing.Size(130, 117);
            this.фотографияPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотографияPictureBox.TabIndex = 24;
            this.фотографияPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Загрузить фото";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialogPhoto";
            // 
            // дискиTextBox
            // 
            this.дискиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автоBindingSource, "Диски", true));
            this.дискиTextBox.Location = new System.Drawing.Point(120, 300);
            this.дискиTextBox.Name = "дискиTextBox";
            this.дискиTextBox.Size = new System.Drawing.Size(100, 20);
            this.дискиTextBox.TabIndex = 26;
            // 
            // автоBindingSource
            // 
            this.автоBindingSource.DataMember = "Авто";
            this.автоBindingSource.DataSource = this.mimimi6DataSet;
            // 
            // mimimi6DataSet
            // 
            this.mimimi6DataSet.DataSetName = "mimimi6DataSet";
            this.mimimi6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автоTableAdapter
            // 
            this.автоTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = this.автоTableAdapter;
            this.tableAdapterManager.ГабаритыTableAdapter = null;
            this.tableAdapterManager.ДвигательTableAdapter = null;
            this.tableAdapterManager.залыTableAdapter = null;
            this.tableAdapterManager.Покупатель_TableAdapter = null;
            this.tableAdapterManager.ПродажиTableAdapter = null;
            this.tableAdapterManager.ПроданоTableAdapter = null;
            this.tableAdapterManager.СалонTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тест_драйвTableAdapter = null;
            // 
            // автоBindingSource1
            // 
            this.автоBindingSource1.DataMember = "Авто";
            this.автоBindingSource1.DataSource = this.mimimi6DataSet;
            // 
            // FormAвто
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(379, 332);
            this.Controls.Add(дискиLabel);
            this.Controls.Add(this.дискиTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(фотографияLabel);
            this.Controls.Add(this.фотографияPictureBox);
            this.Controls.Add(код_автоLabel);
            this.Controls.Add(this.код_автоTextBox);
            this.Controls.Add(производительLabel);
            this.Controls.Add(this.производительTextBox);
            this.Controls.Add(модельLabel);
            this.Controls.Add(this.модельTextBox);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(год_выпускаLabel);
            this.Controls.Add(this.год_выпускаTextBox);
            this.Controls.Add(цвет_кузоваLabel);
            this.Controls.Add(this.цвет_кузоваTextBox);
            this.Controls.Add(кППLabel);
            this.Controls.Add(this.кППTextBox);
            this.Controls.Add(приводLabel);
            this.Controls.Add(this.приводTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(код_двигателяLabel);
            this.Controls.Add(this.код_двигателяTextBox);
            this.Controls.Add(this.автоBindingNavigator);
            this.Name = "FormAвто";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingNavigator)).EndInit();
            this.автоBindingNavigator.ResumeLayout(false);
            this.автоBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автоBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mimimi6DataSet mimimi6DataSet;
        private System.Windows.Forms.BindingSource автоBindingSource;
        private ToyotaCenter.mimimi6DataSetTableAdapters.АвтоTableAdapter автоTableAdapter;
        private ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator автоBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton автоBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_автоTextBox;
        private System.Windows.Forms.TextBox производительTextBox;
        private System.Windows.Forms.TextBox модельTextBox;
        private System.Windows.Forms.TextBox типTextBox;
        private System.Windows.Forms.TextBox год_выпускаTextBox;
        private System.Windows.Forms.TextBox цвет_кузоваTextBox;
        private System.Windows.Forms.TextBox кППTextBox;
        private System.Windows.Forms.TextBox приводTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox код_двигателяTextBox;
        private System.Windows.Forms.PictureBox фотографияPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.BindingSource автоBindingSource1;
        private System.Windows.Forms.TextBox дискиTextBox;
    }
}