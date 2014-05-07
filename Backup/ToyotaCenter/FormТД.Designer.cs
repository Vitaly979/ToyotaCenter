namespace ToyotaCenter
{
    partial class FormТД
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
            System.Windows.Forms.Label запись_на_тест_драйвLabel;
            System.Windows.Forms.Label код_покупательLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label модельLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormТД));
            this.mimimi6DataSet = new ToyotaCenter.mimimi6DataSet();
            this.тест_драйвBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тест_драйвTableAdapter = new ToyotaCenter.mimimi6DataSetTableAdapters.Тест_драйвTableAdapter();
            this.tableAdapterManager = new ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager();
            this.тест_драйвBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.запись_на_тест_драйвTextBox = new System.Windows.Forms.TextBox();
            this.код_покупательTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.модельTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.тест_драйвBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            запись_на_тест_драйвLabel = new System.Windows.Forms.Label();
            код_покупательLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            модельLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тест_драйвBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тест_драйвBindingNavigator)).BeginInit();
            this.тест_драйвBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mimimi6DataSet
            // 
            this.mimimi6DataSet.DataSetName = "mimimi6DataSet";
            this.mimimi6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тест_драйвBindingSource
            // 
            this.тест_драйвBindingSource.DataMember = "Тест_драйв";
            this.тест_драйвBindingSource.DataSource = this.mimimi6DataSet;
            // 
            // тест_драйвTableAdapter
            // 
            this.тест_драйвTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СалонTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тест_драйвTableAdapter = this.тест_драйвTableAdapter;
            // 
            // тест_драйвBindingNavigator
            // 
            this.тест_драйвBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тест_драйвBindingNavigator.BindingSource = this.тест_драйвBindingSource;
            this.тест_драйвBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тест_драйвBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тест_драйвBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.тест_драйвBindingNavigatorSaveItem});
            this.тест_драйвBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тест_драйвBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тест_драйвBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тест_драйвBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тест_драйвBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тест_драйвBindingNavigator.Name = "тест_драйвBindingNavigator";
            this.тест_драйвBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тест_драйвBindingNavigator.Size = new System.Drawing.Size(393, 25);
            this.тест_драйвBindingNavigator.TabIndex = 0;
            this.тест_драйвBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // запись_на_тест_драйвLabel
            // 
            запись_на_тест_драйвLabel.AutoSize = true;
            запись_на_тест_драйвLabel.Location = new System.Drawing.Point(27, 46);
            запись_на_тест_драйвLabel.Name = "запись_на_тест_драйвLabel";
            запись_на_тест_драйвLabel.Size = new System.Drawing.Size(120, 13);
            запись_на_тест_драйвLabel.TabIndex = 1;
            запись_на_тест_драйвLabel.Text = "Запись на тест драйв:";
            // 
            // запись_на_тест_драйвTextBox
            // 
            this.запись_на_тест_драйвTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тест_драйвBindingSource, "Запись_на_тест_драйв", true));
            this.запись_на_тест_драйвTextBox.Location = new System.Drawing.Point(153, 43);
            this.запись_на_тест_драйвTextBox.Name = "запись_на_тест_драйвTextBox";
            this.запись_на_тест_драйвTextBox.Size = new System.Drawing.Size(200, 20);
            this.запись_на_тест_драйвTextBox.TabIndex = 2;
            // 
            // код_покупательLabel
            // 
            код_покупательLabel.AutoSize = true;
            код_покупательLabel.Location = new System.Drawing.Point(27, 72);
            код_покупательLabel.Name = "код_покупательLabel";
            код_покупательLabel.Size = new System.Drawing.Size(90, 13);
            код_покупательLabel.TabIndex = 3;
            код_покупательLabel.Text = "Код покупатель:";
            // 
            // код_покупательTextBox
            // 
            this.код_покупательTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тест_драйвBindingSource, "Код_покупатель", true));
            this.код_покупательTextBox.Location = new System.Drawing.Point(153, 69);
            this.код_покупательTextBox.Name = "код_покупательTextBox";
            this.код_покупательTextBox.Size = new System.Drawing.Size(200, 20);
            this.код_покупательTextBox.TabIndex = 4;
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(27, 98);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 5;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тест_драйвBindingSource, "Код_сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(153, 95);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.код_сотрудникаTextBox.TabIndex = 6;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(27, 125);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 7;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.тест_драйвBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(153, 121);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 8;
            // 
            // модельLabel
            // 
            модельLabel.AutoSize = true;
            модельLabel.Location = new System.Drawing.Point(27, 150);
            модельLabel.Name = "модельLabel";
            модельLabel.Size = new System.Drawing.Size(49, 13);
            модельLabel.TabIndex = 9;
            модельLabel.Text = "Модель:";
            // 
            // модельTextBox
            // 
            this.модельTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тест_драйвBindingSource, "Модель", true));
            this.модельTextBox.Location = new System.Drawing.Point(153, 147);
            this.модельTextBox.Name = "модельTextBox";
            this.модельTextBox.Size = new System.Drawing.Size(200, 20);
            this.модельTextBox.TabIndex = 10;
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
            // тест_драйвBindingNavigatorSaveItem
            // 
            this.тест_драйвBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тест_драйвBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тест_драйвBindingNavigatorSaveItem.Image")));
            this.тест_драйвBindingNavigatorSaveItem.Name = "тест_драйвBindingNavigatorSaveItem";
            this.тест_драйвBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.тест_драйвBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.тест_драйвBindingNavigatorSaveItem.Click += new System.EventHandler(this.тест_драйвBindingNavigatorSaveItem_Click);
            // 
            // FormТД
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(393, 186);
            this.Controls.Add(запись_на_тест_драйвLabel);
            this.Controls.Add(this.запись_на_тест_драйвTextBox);
            this.Controls.Add(код_покупательLabel);
            this.Controls.Add(this.код_покупательTextBox);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(модельLabel);
            this.Controls.Add(this.модельTextBox);
            this.Controls.Add(this.тест_драйвBindingNavigator);
            this.Name = "FormТД";
            this.Text = "Тест-драйв";
            this.Load += new System.EventHandler(this.FormТД_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тест_драйвBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тест_драйвBindingNavigator)).EndInit();
            this.тест_драйвBindingNavigator.ResumeLayout(false);
            this.тест_драйвBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mimimi6DataSet mimimi6DataSet;
        private System.Windows.Forms.BindingSource тест_драйвBindingSource;
        private ToyotaCenter.mimimi6DataSetTableAdapters.Тест_драйвTableAdapter тест_драйвTableAdapter;
        private ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тест_драйвBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton тест_драйвBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox запись_на_тест_драйвTextBox;
        private System.Windows.Forms.TextBox код_покупательTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox модельTextBox;
    }
}