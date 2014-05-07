namespace ToyotaCenter
{
    partial class FormЗалы
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
            System.Windows.Forms.Label номер_залаLabel;
            System.Windows.Forms.Label количество_сотрудниковLabel;
            System.Windows.Forms.Label количество_автомобилейLabel;
            System.Windows.Forms.Label типLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormЗалы));
            this.mimimi6DataSet = new ToyotaCenter.mimimi6DataSet();
            this.залыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.залыTableAdapter = new ToyotaCenter.mimimi6DataSetTableAdapters.залыTableAdapter();
            this.tableAdapterManager = new ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager();
            this.залыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.номер_залаTextBox = new System.Windows.Forms.TextBox();
            this.количество_сотрудниковNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.количество_автомобилейNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.типTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.залыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            номер_залаLabel = new System.Windows.Forms.Label();
            количество_сотрудниковLabel = new System.Windows.Forms.Label();
            количество_автомобилейLabel = new System.Windows.Forms.Label();
            типLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingNavigator)).BeginInit();
            this.залыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.количество_сотрудниковNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.количество_автомобилейNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mimimi6DataSet
            // 
            this.mimimi6DataSet.DataSetName = "mimimi6DataSet";
            this.mimimi6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залыBindingSource
            // 
            this.залыBindingSource.DataMember = "залы";
            this.залыBindingSource.DataSource = this.mimimi6DataSet;
            // 
            // залыTableAdapter
            // 
            this.залыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ГабаритыTableAdapter = null;
            this.tableAdapterManager.ДвигательTableAdapter = null;
            this.tableAdapterManager.залыTableAdapter = this.залыTableAdapter;
            this.tableAdapterManager.Покупатель_TableAdapter = null;
            this.tableAdapterManager.ПродажиTableAdapter = null;
            this.tableAdapterManager.ПроданоTableAdapter = null;
            this.tableAdapterManager.СалонTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тест_драйвTableAdapter = null;
            // 
            // залыBindingNavigator
            // 
            this.залыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.залыBindingNavigator.BindingSource = this.залыBindingSource;
            this.залыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.залыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.залыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.залыBindingNavigatorSaveItem});
            this.залыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.залыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.залыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.залыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.залыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.залыBindingNavigator.Name = "залыBindingNavigator";
            this.залыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.залыBindingNavigator.Size = new System.Drawing.Size(312, 25);
            this.залыBindingNavigator.TabIndex = 0;
            this.залыBindingNavigator.Text = "bindingNavigator1";
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
            // номер_залаLabel
            // 
            номер_залаLabel.AutoSize = true;
            номер_залаLabel.Location = new System.Drawing.Point(25, 43);
            номер_залаLabel.Name = "номер_залаLabel";
            номер_залаLabel.Size = new System.Drawing.Size(71, 13);
            номер_залаLabel.TabIndex = 1;
            номер_залаLabel.Text = "Номер зала:";
            // 
            // номер_залаTextBox
            // 
            this.номер_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залыBindingSource, "Номер_зала", true));
            this.номер_залаTextBox.Location = new System.Drawing.Point(170, 40);
            this.номер_залаTextBox.Name = "номер_залаTextBox";
            this.номер_залаTextBox.Size = new System.Drawing.Size(120, 20);
            this.номер_залаTextBox.TabIndex = 2;
            // 
            // количество_сотрудниковLabel
            // 
            количество_сотрудниковLabel.AutoSize = true;
            количество_сотрудниковLabel.Location = new System.Drawing.Point(25, 66);
            количество_сотрудниковLabel.Name = "количество_сотрудниковLabel";
            количество_сотрудниковLabel.Size = new System.Drawing.Size(136, 13);
            количество_сотрудниковLabel.TabIndex = 3;
            количество_сотрудниковLabel.Text = "Количество сотрудников:";
            // 
            // количество_сотрудниковNumericUpDown
            // 
            this.количество_сотрудниковNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.залыBindingSource, "Количество_сотрудников", true));
            this.количество_сотрудниковNumericUpDown.Location = new System.Drawing.Point(170, 66);
            this.количество_сотрудниковNumericUpDown.Name = "количество_сотрудниковNumericUpDown";
            this.количество_сотрудниковNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.количество_сотрудниковNumericUpDown.TabIndex = 4;
            // 
            // количество_автомобилейLabel
            // 
            количество_автомобилейLabel.AutoSize = true;
            количество_автомобилейLabel.Location = new System.Drawing.Point(25, 92);
            количество_автомобилейLabel.Name = "количество_автомобилейLabel";
            количество_автомобилейLabel.Size = new System.Drawing.Size(139, 13);
            количество_автомобилейLabel.TabIndex = 5;
            количество_автомобилейLabel.Text = "Количество автомобилей:";
            // 
            // количество_автомобилейNumericUpDown
            // 
            this.количество_автомобилейNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.залыBindingSource, "Количество_автомобилей", true));
            this.количество_автомобилейNumericUpDown.Location = new System.Drawing.Point(170, 92);
            this.количество_автомобилейNumericUpDown.Name = "количество_автомобилейNumericUpDown";
            this.количество_автомобилейNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.количество_автомобилейNumericUpDown.TabIndex = 6;
            // 
            // типLabel
            // 
            типLabel.AutoSize = true;
            типLabel.Location = new System.Drawing.Point(25, 121);
            типLabel.Name = "типLabel";
            типLabel.Size = new System.Drawing.Size(29, 13);
            типLabel.TabIndex = 7;
            типLabel.Text = "Тип:";
            // 
            // типTextBox
            // 
            this.типTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залыBindingSource, "Тип", true));
            this.типTextBox.Location = new System.Drawing.Point(170, 118);
            this.типTextBox.Name = "типTextBox";
            this.типTextBox.Size = new System.Drawing.Size(120, 20);
            this.типTextBox.TabIndex = 8;
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
            // залыBindingNavigatorSaveItem
            // 
            this.залыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.залыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("залыBindingNavigatorSaveItem.Image")));
            this.залыBindingNavigatorSaveItem.Name = "залыBindingNavigatorSaveItem";
            this.залыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.залыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.залыBindingNavigatorSaveItem.Click += new System.EventHandler(this.залыBindingNavigatorSaveItem_Click);
            // 
            // FormЗалы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(312, 159);
            this.Controls.Add(номер_залаLabel);
            this.Controls.Add(this.номер_залаTextBox);
            this.Controls.Add(количество_сотрудниковLabel);
            this.Controls.Add(this.количество_сотрудниковNumericUpDown);
            this.Controls.Add(количество_автомобилейLabel);
            this.Controls.Add(this.количество_автомобилейNumericUpDown);
            this.Controls.Add(типLabel);
            this.Controls.Add(this.типTextBox);
            this.Controls.Add(this.залыBindingNavigator);
            this.Name = "FormЗалы";
            this.Text = "Залы";
            this.Load += new System.EventHandler(this.FormЗалы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingNavigator)).EndInit();
            this.залыBindingNavigator.ResumeLayout(false);
            this.залыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.количество_сотрудниковNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.количество_автомобилейNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mimimi6DataSet mimimi6DataSet;
        private System.Windows.Forms.BindingSource залыBindingSource;
        private ToyotaCenter.mimimi6DataSetTableAdapters.залыTableAdapter залыTableAdapter;
        private ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator залыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton залыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_залаTextBox;
        private System.Windows.Forms.NumericUpDown количество_сотрудниковNumericUpDown;
        private System.Windows.Forms.NumericUpDown количество_автомобилейNumericUpDown;
        private System.Windows.Forms.TextBox типTextBox;
    }
}