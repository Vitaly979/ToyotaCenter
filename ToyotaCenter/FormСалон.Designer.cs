namespace ToyotaCenter
{
    partial class FormСалон
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
            System.Windows.Forms.Label салонLabel;
            System.Windows.Forms.Label обивкаLabel;
            System.Windows.Forms.Label количество_подушек_бLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormСалон));
            System.Windows.Forms.Label мультимедиаLabel;
            System.Windows.Forms.Label подлокотникиLabel;
            System.Windows.Forms.Label стеклоподъемникиLabel;
            System.Windows.Forms.Label подогрев_сиденийLabel;
            System.Windows.Forms.Label люкLabel;
            this.салонBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.салонBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mimimi6DataSet = new ToyotaCenter.mimimi6DataSet();
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
            this.салонBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.салонTextBox = new System.Windows.Forms.TextBox();
            this.обивкаComboBox = new System.Windows.Forms.ComboBox();
            this.количество_подушек_бNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.салонTableAdapter = new ToyotaCenter.mimimi6DataSetTableAdapters.СалонTableAdapter();
            this.tableAdapterManager = new ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager();
            this.мультимедиаComboBox = new System.Windows.Forms.ComboBox();
            this.подлокотникиComboBox = new System.Windows.Forms.ComboBox();
            this.стеклоподъемникиComboBox = new System.Windows.Forms.ComboBox();
            this.подогрев_сиденийComboBox = new System.Windows.Forms.ComboBox();
            this.люкComboBox = new System.Windows.Forms.ComboBox();
            салонLabel = new System.Windows.Forms.Label();
            обивкаLabel = new System.Windows.Forms.Label();
            количество_подушек_бLabel = new System.Windows.Forms.Label();
            мультимедиаLabel = new System.Windows.Forms.Label();
            подлокотникиLabel = new System.Windows.Forms.Label();
            стеклоподъемникиLabel = new System.Windows.Forms.Label();
            подогрев_сиденийLabel = new System.Windows.Forms.Label();
            люкLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.салонBindingNavigator)).BeginInit();
            this.салонBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.салонBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.количество_подушек_бNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // салонLabel
            // 
            салонLabel.AutoSize = true;
            салонLabel.Location = new System.Drawing.Point(17, 43);
            салонLabel.Name = "салонLabel";
            салонLabel.Size = new System.Drawing.Size(41, 13);
            салонLabel.TabIndex = 1;
            салонLabel.Text = "Салон:";
            // 
            // обивкаLabel
            // 
            обивкаLabel.AutoSize = true;
            обивкаLabel.Location = new System.Drawing.Point(17, 79);
            обивкаLabel.Name = "обивкаLabel";
            обивкаLabel.Size = new System.Drawing.Size(48, 13);
            обивкаLabel.TabIndex = 3;
            обивкаLabel.Text = "Обивка:";
            // 
            // количество_подушек_бLabel
            // 
            количество_подушек_бLabel.AutoSize = true;
            количество_подушек_бLabel.Location = new System.Drawing.Point(17, 271);
            количество_подушек_бLabel.Name = "количество_подушек_бLabel";
            количество_подушек_бLabel.Size = new System.Drawing.Size(124, 13);
            количество_подушек_бLabel.TabIndex = 15;
            количество_подушек_бLabel.Text = "Количество подушек б:";
            // 
            // салонBindingNavigator
            // 
            this.салонBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.салонBindingNavigator.BindingSource = this.салонBindingSource;
            this.салонBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.салонBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.салонBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.салонBindingNavigatorSaveItem});
            this.салонBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.салонBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.салонBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.салонBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.салонBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.салонBindingNavigator.Name = "салонBindingNavigator";
            this.салонBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.салонBindingNavigator.Size = new System.Drawing.Size(341, 25);
            this.салонBindingNavigator.TabIndex = 0;
            this.салонBindingNavigator.Text = "bindingNavigator1";
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
            // салонBindingSource
            // 
            this.салонBindingSource.DataMember = "Салон";
            this.салонBindingSource.DataSource = this.mimimi6DataSet;
            // 
            // mimimi6DataSet
            // 
            this.mimimi6DataSet.DataSetName = "mimimi6DataSet";
            this.mimimi6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // салонBindingNavigatorSaveItem
            // 
            this.салонBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.салонBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("салонBindingNavigatorSaveItem.Image")));
            this.салонBindingNavigatorSaveItem.Name = "салонBindingNavigatorSaveItem";
            this.салонBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.салонBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.салонBindingNavigatorSaveItem.Click += new System.EventHandler(this.салонBindingNavigatorSaveItem_Click);
            // 
            // салонTextBox
            // 
            this.салонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.салонBindingSource, "Салон", true));
            this.салонTextBox.Location = new System.Drawing.Point(147, 40);
            this.салонTextBox.Name = "салонTextBox";
            this.салонTextBox.Size = new System.Drawing.Size(100, 20);
            this.салонTextBox.TabIndex = 2;
            // 
            // обивкаComboBox
            // 
            this.обивкаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.салонBindingSource, "Обивка", true));
            this.обивкаComboBox.FormattingEnabled = true;
            this.обивкаComboBox.Items.AddRange(new object[] {
            "Кожа",
            "Ткань"});
            this.обивкаComboBox.Location = new System.Drawing.Point(147, 76);
            this.обивкаComboBox.Name = "обивкаComboBox";
            this.обивкаComboBox.Size = new System.Drawing.Size(121, 21);
            this.обивкаComboBox.TabIndex = 4;
            // 
            // количество_подушек_бNumericUpDown
            // 
            this.количество_подушек_бNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.салонBindingSource, "Количество_подушек_б", true));
            this.количество_подушек_бNumericUpDown.Location = new System.Drawing.Point(147, 271);
            this.количество_подушек_бNumericUpDown.Name = "количество_подушек_бNumericUpDown";
            this.количество_подушек_бNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.количество_подушек_бNumericUpDown.TabIndex = 16;
            // 
            // салонTableAdapter
            // 
            this.салонTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ГабаритыTableAdapter = null;
            this.tableAdapterManager.ДвигательTableAdapter = null;
            this.tableAdapterManager.залыTableAdapter = null;
            this.tableAdapterManager.Покупатель_TableAdapter = null;
            this.tableAdapterManager.ПродажиTableAdapter = null;
            this.tableAdapterManager.ПроданоTableAdapter = null;
            this.tableAdapterManager.СалонTableAdapter = this.салонTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тест_драйвTableAdapter = null;
            // 
            // мультимедиаLabel
            // 
            мультимедиаLabel.AutoSize = true;
            мультимедиаLabel.Location = new System.Drawing.Point(17, 110);
            мультимедиаLabel.Name = "мультимедиаLabel";
            мультимедиаLabel.Size = new System.Drawing.Size(79, 13);
            мультимедиаLabel.TabIndex = 16;
            мультимедиаLabel.Text = "Мультимедиа:";
            // 
            // мультимедиаComboBox
            // 
            this.мультимедиаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.салонBindingSource, "Мультимедиа", true));
            this.мультимедиаComboBox.FormattingEnabled = true;
            this.мультимедиаComboBox.Items.AddRange(new object[] {
            "есть",
            "нет"});
            this.мультимедиаComboBox.Location = new System.Drawing.Point(146, 107);
            this.мультимедиаComboBox.Name = "мультимедиаComboBox";
            this.мультимедиаComboBox.Size = new System.Drawing.Size(121, 21);
            this.мультимедиаComboBox.TabIndex = 17;
            // 
            // подлокотникиLabel
            // 
            подлокотникиLabel.AutoSize = true;
            подлокотникиLabel.Location = new System.Drawing.Point(17, 146);
            подлокотникиLabel.Name = "подлокотникиLabel";
            подлокотникиLabel.Size = new System.Drawing.Size(83, 13);
            подлокотникиLabel.TabIndex = 17;
            подлокотникиLabel.Text = "Подлокотники:";
            // 
            // подлокотникиComboBox
            // 
            this.подлокотникиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.салонBindingSource, "Подлокотники", true));
            this.подлокотникиComboBox.FormattingEnabled = true;
            this.подлокотникиComboBox.Items.AddRange(new object[] {
            "есть",
            "нет"});
            this.подлокотникиComboBox.Location = new System.Drawing.Point(146, 143);
            this.подлокотникиComboBox.Name = "подлокотникиComboBox";
            this.подлокотникиComboBox.Size = new System.Drawing.Size(121, 21);
            this.подлокотникиComboBox.TabIndex = 18;
            // 
            // стеклоподъемникиLabel
            // 
            стеклоподъемникиLabel.AutoSize = true;
            стеклоподъемникиLabel.Location = new System.Drawing.Point(17, 205);
            стеклоподъемникиLabel.Name = "стеклоподъемникиLabel";
            стеклоподъемникиLabel.Size = new System.Drawing.Size(109, 13);
            стеклоподъемникиLabel.TabIndex = 19;
            стеклоподъемникиLabel.Text = "Стеклоподъемники:";
            // 
            // стеклоподъемникиComboBox
            // 
            this.стеклоподъемникиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.салонBindingSource, "Стеклоподъемники", true));
            this.стеклоподъемникиComboBox.FormattingEnabled = true;
            this.стеклоподъемникиComboBox.Items.AddRange(new object[] {
            "есть",
            "нет"});
            this.стеклоподъемникиComboBox.Location = new System.Drawing.Point(147, 202);
            this.стеклоподъемникиComboBox.Name = "стеклоподъемникиComboBox";
            this.стеклоподъемникиComboBox.Size = new System.Drawing.Size(121, 21);
            this.стеклоподъемникиComboBox.TabIndex = 20;
            // 
            // подогрев_сиденийLabel
            // 
            подогрев_сиденийLabel.AutoSize = true;
            подогрев_сиденийLabel.Location = new System.Drawing.Point(17, 236);
            подогрев_сиденийLabel.Name = "подогрев_сиденийLabel";
            подогрев_сиденийLabel.Size = new System.Drawing.Size(104, 13);
            подогрев_сиденийLabel.TabIndex = 20;
            подогрев_сиденийLabel.Text = "Подогрев сидений:";
            // 
            // подогрев_сиденийComboBox
            // 
            this.подогрев_сиденийComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.салонBindingSource, "Подогрев_сидений", true));
            this.подогрев_сиденийComboBox.FormattingEnabled = true;
            this.подогрев_сиденийComboBox.Items.AddRange(new object[] {
            "есть",
            "нет"});
            this.подогрев_сиденийComboBox.Location = new System.Drawing.Point(147, 233);
            this.подогрев_сиденийComboBox.Name = "подогрев_сиденийComboBox";
            this.подогрев_сиденийComboBox.Size = new System.Drawing.Size(121, 21);
            this.подогрев_сиденийComboBox.TabIndex = 21;
            // 
            // люкLabel
            // 
            люкLabel.AutoSize = true;
            люкLabel.Location = new System.Drawing.Point(17, 175);
            люкLabel.Name = "люкLabel";
            люкLabel.Size = new System.Drawing.Size(32, 13);
            люкLabel.TabIndex = 21;
            люкLabel.Text = "Люк:";
            // 
            // люкComboBox
            // 
            this.люкComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.салонBindingSource, "Люк", true));
            this.люкComboBox.FormattingEnabled = true;
            this.люкComboBox.Items.AddRange(new object[] {
            "есть",
            "нет"});
            this.люкComboBox.Location = new System.Drawing.Point(147, 172);
            this.люкComboBox.Name = "люкComboBox";
            this.люкComboBox.Size = new System.Drawing.Size(121, 21);
            this.люкComboBox.TabIndex = 22;
            // 
            // FormСалон
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 320);
            this.Controls.Add(люкLabel);
            this.Controls.Add(this.люкComboBox);
            this.Controls.Add(подогрев_сиденийLabel);
            this.Controls.Add(this.подогрев_сиденийComboBox);
            this.Controls.Add(стеклоподъемникиLabel);
            this.Controls.Add(this.стеклоподъемникиComboBox);
            this.Controls.Add(подлокотникиLabel);
            this.Controls.Add(this.подлокотникиComboBox);
            this.Controls.Add(мультимедиаLabel);
            this.Controls.Add(this.мультимедиаComboBox);
            this.Controls.Add(количество_подушек_бLabel);
            this.Controls.Add(this.количество_подушек_бNumericUpDown);
            this.Controls.Add(обивкаLabel);
            this.Controls.Add(this.обивкаComboBox);
            this.Controls.Add(салонLabel);
            this.Controls.Add(this.салонTextBox);
            this.Controls.Add(this.салонBindingNavigator);
            this.Name = "FormСалон";
            this.Text = "FormСалон";
            this.Load += new System.EventHandler(this.FormСалон_Load);
            ((System.ComponentModel.ISupportInitialize)(this.салонBindingNavigator)).EndInit();
            this.салонBindingNavigator.ResumeLayout(false);
            this.салонBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.салонBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.количество_подушек_бNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mimimi6DataSet mimimi6DataSet;
        private System.Windows.Forms.BindingSource салонBindingSource;
        private ToyotaCenter.mimimi6DataSetTableAdapters.СалонTableAdapter салонTableAdapter;
        private ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator салонBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton салонBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox салонTextBox;
        private System.Windows.Forms.ComboBox обивкаComboBox;
        private System.Windows.Forms.NumericUpDown количество_подушек_бNumericUpDown;
        private System.Windows.Forms.ComboBox мультимедиаComboBox;
        private System.Windows.Forms.ComboBox подлокотникиComboBox;
        private System.Windows.Forms.ComboBox стеклоподъемникиComboBox;
        private System.Windows.Forms.ComboBox подогрев_сиденийComboBox;
        private System.Windows.Forms.ComboBox люкComboBox;
    }
}