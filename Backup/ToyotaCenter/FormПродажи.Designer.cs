namespace ToyotaCenter
{
    partial class FormПродажи
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
            System.Windows.Forms.Label номер_продажиLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label номер_залаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormПродажи));
            this.продажиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.номер_продажиTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.номер_залаTextBox = new System.Windows.Forms.TextBox();
            this.продажиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mimimi6DataSet = new ToyotaCenter.mimimi6DataSet();
            this.продажиTableAdapter = new ToyotaCenter.mimimi6DataSetTableAdapters.ПродажиTableAdapter();
            this.tableAdapterManager = new ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.продажиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            номер_продажиLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            номер_залаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingNavigator)).BeginInit();
            this.продажиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // продажиBindingNavigator
            // 
            this.продажиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.продажиBindingNavigator.BindingSource = this.продажиBindingSource;
            this.продажиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.продажиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.продажиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.продажиBindingNavigatorSaveItem});
            this.продажиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.продажиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.продажиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.продажиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.продажиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.продажиBindingNavigator.Name = "продажиBindingNavigator";
            this.продажиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.продажиBindingNavigator.Size = new System.Drawing.Size(322, 25);
            this.продажиBindingNavigator.TabIndex = 0;
            this.продажиBindingNavigator.Text = "bindingNavigator1";
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
            // номер_продажиLabel
            // 
            номер_продажиLabel.AutoSize = true;
            номер_продажиLabel.Location = new System.Drawing.Point(12, 47);
            номер_продажиLabel.Name = "номер_продажиLabel";
            номер_продажиLabel.Size = new System.Drawing.Size(91, 13);
            номер_продажиLabel.TabIndex = 1;
            номер_продажиLabel.Text = "Номер продажи:";
            // 
            // номер_продажиTextBox
            // 
            this.номер_продажиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажиBindingSource, "Номер_продажи", true));
            this.номер_продажиTextBox.Location = new System.Drawing.Point(109, 44);
            this.номер_продажиTextBox.Name = "номер_продажиTextBox";
            this.номер_продажиTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_продажиTextBox.TabIndex = 2;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(12, 74);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.продажиBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(109, 70);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(12, 99);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(90, 13);
            код_сотрудникаLabel.TabIndex = 5;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажиBindingSource, "Код_сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(109, 96);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(200, 20);
            this.код_сотрудникаTextBox.TabIndex = 6;
            // 
            // номер_залаLabel
            // 
            номер_залаLabel.AutoSize = true;
            номер_залаLabel.Location = new System.Drawing.Point(12, 125);
            номер_залаLabel.Name = "номер_залаLabel";
            номер_залаLabel.Size = new System.Drawing.Size(71, 13);
            номер_залаLabel.TabIndex = 7;
            номер_залаLabel.Text = "Номер зала:";
            // 
            // номер_залаTextBox
            // 
            this.номер_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.продажиBindingSource, "Номер_зала", true));
            this.номер_залаTextBox.Location = new System.Drawing.Point(109, 122);
            this.номер_залаTextBox.Name = "номер_залаTextBox";
            this.номер_залаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_залаTextBox.TabIndex = 8;
            // 
            // продажиBindingSource
            // 
            this.продажиBindingSource.DataMember = "Продажи";
            this.продажиBindingSource.DataSource = this.mimimi6DataSet;
            // 
            // mimimi6DataSet
            // 
            this.mimimi6DataSet.DataSetName = "mimimi6DataSet";
            this.mimimi6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажиTableAdapter
            // 
            this.продажиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПродажиTableAdapter = this.продажиTableAdapter;
            this.tableAdapterManager.ПроданоTableAdapter = null;
            this.tableAdapterManager.СалонTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тест_драйвTableAdapter = null;
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
            // продажиBindingNavigatorSaveItem
            // 
            this.продажиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.продажиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("продажиBindingNavigatorSaveItem.Image")));
            this.продажиBindingNavigatorSaveItem.Name = "продажиBindingNavigatorSaveItem";
            this.продажиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.продажиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.продажиBindingNavigatorSaveItem.Click += new System.EventHandler(this.продажиBindingNavigatorSaveItem_Click);
            // 
            // FormПродажи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(322, 159);
            this.Controls.Add(номер_продажиLabel);
            this.Controls.Add(this.номер_продажиTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(номер_залаLabel);
            this.Controls.Add(this.номер_залаTextBox);
            this.Controls.Add(this.продажиBindingNavigator);
            this.Name = "FormПродажи";
            this.Text = "Продажи";
            this.Load += new System.EventHandler(this.FormПродажи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingNavigator)).EndInit();
            this.продажиBindingNavigator.ResumeLayout(false);
            this.продажиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.продажиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mimimi6DataSet mimimi6DataSet;
        private System.Windows.Forms.BindingSource продажиBindingSource;
        private ToyotaCenter.mimimi6DataSetTableAdapters.ПродажиTableAdapter продажиTableAdapter;
        private ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator продажиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton продажиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_продажиTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox номер_залаTextBox;
    }
}