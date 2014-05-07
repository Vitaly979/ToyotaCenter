namespace ToyotaCenter
{
    partial class FormГабариты
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
            System.Windows.Forms.Label длинаLabel;
            System.Windows.Forms.Label высотаLabel;
            System.Windows.Forms.Label ширинаLabel;
            System.Windows.Forms.Label весLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormГабариты));
            this.mimimi6DataSet = new ToyotaCenter.mimimi6DataSet();
            this.габаритыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.габаритыTableAdapter = new ToyotaCenter.mimimi6DataSetTableAdapters.ГабаритыTableAdapter();
            this.tableAdapterManager = new ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager();
            this.габаритыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.код_автоTextBox = new System.Windows.Forms.TextBox();
            this.длинаTextBox = new System.Windows.Forms.TextBox();
            this.высотаTextBox = new System.Windows.Forms.TextBox();
            this.ширинаTextBox = new System.Windows.Forms.TextBox();
            this.весTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.габаритыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            код_автоLabel = new System.Windows.Forms.Label();
            длинаLabel = new System.Windows.Forms.Label();
            высотаLabel = new System.Windows.Forms.Label();
            ширинаLabel = new System.Windows.Forms.Label();
            весLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.габаритыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.габаритыBindingNavigator)).BeginInit();
            this.габаритыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mimimi6DataSet
            // 
            this.mimimi6DataSet.DataSetName = "mimimi6DataSet";
            this.mimimi6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // габаритыBindingSource
            // 
            this.габаритыBindingSource.DataMember = "Габариты";
            this.габаритыBindingSource.DataSource = this.mimimi6DataSet;
            // 
            // габаритыTableAdapter
            // 
            this.габаритыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ГабаритыTableAdapter = this.габаритыTableAdapter;
            this.tableAdapterManager.ДвигательTableAdapter = null;
            this.tableAdapterManager.залыTableAdapter = null;
            this.tableAdapterManager.Покупатель_TableAdapter = null;
            this.tableAdapterManager.ПродажиTableAdapter = null;
            this.tableAdapterManager.ПроданоTableAdapter = null;
            this.tableAdapterManager.СалонTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тест_драйвTableAdapter = null;
            // 
            // габаритыBindingNavigator
            // 
            this.габаритыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.габаритыBindingNavigator.BindingSource = this.габаритыBindingSource;
            this.габаритыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.габаритыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.габаритыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.габаритыBindingNavigatorSaveItem});
            this.габаритыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.габаритыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.габаритыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.габаритыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.габаритыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.габаритыBindingNavigator.Name = "габаритыBindingNavigator";
            this.габаритыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.габаритыBindingNavigator.Size = new System.Drawing.Size(308, 25);
            this.габаритыBindingNavigator.TabIndex = 0;
            this.габаритыBindingNavigator.Text = "bindingNavigator1";
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
            // код_автоLabel
            // 
            код_автоLabel.AutoSize = true;
            код_автоLabel.Location = new System.Drawing.Point(27, 46);
            код_автоLabel.Name = "код_автоLabel";
            код_автоLabel.Size = new System.Drawing.Size(55, 13);
            код_автоLabel.TabIndex = 1;
            код_автоLabel.Text = "Код авто:";
            // 
            // код_автоTextBox
            // 
            this.код_автоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.габаритыBindingSource, "Код_авто", true));
            this.код_автоTextBox.Location = new System.Drawing.Point(88, 43);
            this.код_автоTextBox.Name = "код_автоTextBox";
            this.код_автоTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_автоTextBox.TabIndex = 2;
            // 
            // длинаLabel
            // 
            длинаLabel.AutoSize = true;
            длинаLabel.Location = new System.Drawing.Point(27, 72);
            длинаLabel.Name = "длинаLabel";
            длинаLabel.Size = new System.Drawing.Size(43, 13);
            длинаLabel.TabIndex = 3;
            длинаLabel.Text = "Длина:";
            // 
            // длинаTextBox
            // 
            this.длинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.габаритыBindingSource, "Длина", true));
            this.длинаTextBox.Location = new System.Drawing.Point(88, 69);
            this.длинаTextBox.Name = "длинаTextBox";
            this.длинаTextBox.Size = new System.Drawing.Size(100, 20);
            this.длинаTextBox.TabIndex = 4;
            // 
            // высотаLabel
            // 
            высотаLabel.AutoSize = true;
            высотаLabel.Location = new System.Drawing.Point(27, 98);
            высотаLabel.Name = "высотаLabel";
            высотаLabel.Size = new System.Drawing.Size(48, 13);
            высотаLabel.TabIndex = 5;
            высотаLabel.Text = "Высота:";
            // 
            // высотаTextBox
            // 
            this.высотаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.габаритыBindingSource, "Высота", true));
            this.высотаTextBox.Location = new System.Drawing.Point(88, 95);
            this.высотаTextBox.Name = "высотаTextBox";
            this.высотаTextBox.Size = new System.Drawing.Size(100, 20);
            this.высотаTextBox.TabIndex = 6;
            // 
            // ширинаLabel
            // 
            ширинаLabel.AutoSize = true;
            ширинаLabel.Location = new System.Drawing.Point(27, 124);
            ширинаLabel.Name = "ширинаLabel";
            ширинаLabel.Size = new System.Drawing.Size(49, 13);
            ширинаLabel.TabIndex = 7;
            ширинаLabel.Text = "Ширина:";
            // 
            // ширинаTextBox
            // 
            this.ширинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.габаритыBindingSource, "Ширина", true));
            this.ширинаTextBox.Location = new System.Drawing.Point(88, 121);
            this.ширинаTextBox.Name = "ширинаTextBox";
            this.ширинаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ширинаTextBox.TabIndex = 8;
            // 
            // весLabel
            // 
            весLabel.AutoSize = true;
            весLabel.Location = new System.Drawing.Point(27, 150);
            весLabel.Name = "весLabel";
            весLabel.Size = new System.Drawing.Size(29, 13);
            весLabel.TabIndex = 9;
            весLabel.Text = "Вес:";
            // 
            // весTextBox
            // 
            this.весTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.габаритыBindingSource, "Вес", true));
            this.весTextBox.Location = new System.Drawing.Point(88, 147);
            this.весTextBox.Name = "весTextBox";
            this.весTextBox.Size = new System.Drawing.Size(100, 20);
            this.весTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "См";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "См";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "См";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Кг";
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
            // габаритыBindingNavigatorSaveItem
            // 
            this.габаритыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.габаритыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("габаритыBindingNavigatorSaveItem.Image")));
            this.габаритыBindingNavigatorSaveItem.Name = "габаритыBindingNavigatorSaveItem";
            this.габаритыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.габаритыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.габаритыBindingNavigatorSaveItem.Click += new System.EventHandler(this.габаритыBindingNavigatorSaveItem_Click);
            // 
            // FormГабариты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(308, 178);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(код_автоLabel);
            this.Controls.Add(this.код_автоTextBox);
            this.Controls.Add(длинаLabel);
            this.Controls.Add(this.длинаTextBox);
            this.Controls.Add(высотаLabel);
            this.Controls.Add(this.высотаTextBox);
            this.Controls.Add(ширинаLabel);
            this.Controls.Add(this.ширинаTextBox);
            this.Controls.Add(весLabel);
            this.Controls.Add(this.весTextBox);
            this.Controls.Add(this.габаритыBindingNavigator);
            this.Name = "FormГабариты";
            this.Text = "Габариты";
            this.Load += new System.EventHandler(this.FormГабариты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.габаритыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.габаритыBindingNavigator)).EndInit();
            this.габаритыBindingNavigator.ResumeLayout(false);
            this.габаритыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mimimi6DataSet mimimi6DataSet;
        private System.Windows.Forms.BindingSource габаритыBindingSource;
        private ToyotaCenter.mimimi6DataSetTableAdapters.ГабаритыTableAdapter габаритыTableAdapter;
        private ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator габаритыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton габаритыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_автоTextBox;
        private System.Windows.Forms.TextBox длинаTextBox;
        private System.Windows.Forms.TextBox высотаTextBox;
        private System.Windows.Forms.TextBox ширинаTextBox;
        private System.Windows.Forms.TextBox весTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}