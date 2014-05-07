namespace ToyotaCenter
{
    partial class FormДвиг
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
            System.Windows.Forms.Label код_двигателяLabel;
            System.Windows.Forms.Label количество_лошадейLabel;
            System.Windows.Forms.Label количество_цилиндровLabel;
            System.Windows.Forms.Label расположение_цилиндровLabel;
            System.Windows.Forms.Label топливоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormДвиг));
            System.Windows.Forms.Label объемLabel;
            this.mimimi6DataSet = new ToyotaCenter.mimimi6DataSet();
            this.двигательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.двигательTableAdapter = new ToyotaCenter.mimimi6DataSetTableAdapters.ДвигательTableAdapter();
            this.tableAdapterManager = new ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager();
            this.двигательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.код_двигателяTextBox = new System.Windows.Forms.TextBox();
            this.количество_лошадейTextBox = new System.Windows.Forms.TextBox();
            this.количество_цилиндровTextBox = new System.Windows.Forms.TextBox();
            this.расположение_цилиндровTextBox = new System.Windows.Forms.TextBox();
            this.топливоTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.двигательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.объемNumericUpDown = new System.Windows.Forms.NumericUpDown();
            код_двигателяLabel = new System.Windows.Forms.Label();
            количество_лошадейLabel = new System.Windows.Forms.Label();
            количество_цилиндровLabel = new System.Windows.Forms.Label();
            расположение_цилиндровLabel = new System.Windows.Forms.Label();
            топливоLabel = new System.Windows.Forms.Label();
            объемLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.двигательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.двигательBindingNavigator)).BeginInit();
            this.двигательBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объемNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mimimi6DataSet
            // 
            this.mimimi6DataSet.DataSetName = "mimimi6DataSet";
            this.mimimi6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // двигательBindingSource
            // 
            this.двигательBindingSource.DataMember = "Двигатель";
            this.двигательBindingSource.DataSource = this.mimimi6DataSet;
            // 
            // двигательTableAdapter
            // 
            this.двигательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтоTableAdapter = null;
            this.tableAdapterManager.ГабаритыTableAdapter = null;
            this.tableAdapterManager.ДвигательTableAdapter = this.двигательTableAdapter;
            this.tableAdapterManager.залыTableAdapter = null;
            this.tableAdapterManager.Покупатель_TableAdapter = null;
            this.tableAdapterManager.ПродажиTableAdapter = null;
            this.tableAdapterManager.ПроданоTableAdapter = null;
            this.tableAdapterManager.СалонTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Тест_драйвTableAdapter = null;
            // 
            // двигательBindingNavigator
            // 
            this.двигательBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.двигательBindingNavigator.BindingSource = this.двигательBindingSource;
            this.двигательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.двигательBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.двигательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.двигательBindingNavigatorSaveItem});
            this.двигательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.двигательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.двигательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.двигательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.двигательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.двигательBindingNavigator.Name = "двигательBindingNavigator";
            this.двигательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.двигательBindingNavigator.Size = new System.Drawing.Size(317, 25);
            this.двигательBindingNavigator.TabIndex = 0;
            this.двигательBindingNavigator.Text = "bindingNavigator1";
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
            // код_двигателяLabel
            // 
            код_двигателяLabel.AutoSize = true;
            код_двигателяLabel.Location = new System.Drawing.Point(26, 44);
            код_двигателяLabel.Name = "код_двигателяLabel";
            код_двигателяLabel.Size = new System.Drawing.Size(84, 13);
            код_двигателяLabel.TabIndex = 1;
            код_двигателяLabel.Text = "Код двигателя:";
            // 
            // код_двигателяTextBox
            // 
            this.код_двигателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.двигательBindingSource, "Код_двигателя", true));
            this.код_двигателяTextBox.Location = new System.Drawing.Point(174, 41);
            this.код_двигателяTextBox.Name = "код_двигателяTextBox";
            this.код_двигателяTextBox.Size = new System.Drawing.Size(121, 20);
            this.код_двигателяTextBox.TabIndex = 2;
            // 
            // количество_лошадейLabel
            // 
            количество_лошадейLabel.AutoSize = true;
            количество_лошадейLabel.Location = new System.Drawing.Point(26, 97);
            количество_лошадейLabel.Name = "количество_лошадейLabel";
            количество_лошадейLabel.Size = new System.Drawing.Size(116, 13);
            количество_лошадейLabel.TabIndex = 5;
            количество_лошадейLabel.Text = "Количество лошадей:";
            // 
            // количество_лошадейTextBox
            // 
            this.количество_лошадейTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.двигательBindingSource, "Количество_лошадей", true));
            this.количество_лошадейTextBox.Location = new System.Drawing.Point(174, 94);
            this.количество_лошадейTextBox.Name = "количество_лошадейTextBox";
            this.количество_лошадейTextBox.Size = new System.Drawing.Size(121, 20);
            this.количество_лошадейTextBox.TabIndex = 6;
            // 
            // количество_цилиндровLabel
            // 
            количество_цилиндровLabel.AutoSize = true;
            количество_цилиндровLabel.Location = new System.Drawing.Point(26, 123);
            количество_цилиндровLabel.Name = "количество_цилиндровLabel";
            количество_цилиндровLabel.Size = new System.Drawing.Size(126, 13);
            количество_цилиндровLabel.TabIndex = 7;
            количество_цилиндровLabel.Text = "Количество цилиндров:";
            // 
            // количество_цилиндровTextBox
            // 
            this.количество_цилиндровTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.двигательBindingSource, "Количество_цилиндров", true));
            this.количество_цилиндровTextBox.Location = new System.Drawing.Point(174, 120);
            this.количество_цилиндровTextBox.Name = "количество_цилиндровTextBox";
            this.количество_цилиндровTextBox.Size = new System.Drawing.Size(121, 20);
            this.количество_цилиндровTextBox.TabIndex = 8;
            // 
            // расположение_цилиндровLabel
            // 
            расположение_цилиндровLabel.AutoSize = true;
            расположение_цилиндровLabel.Location = new System.Drawing.Point(26, 149);
            расположение_цилиндровLabel.Name = "расположение_цилиндровLabel";
            расположение_цилиндровLabel.Size = new System.Drawing.Size(142, 13);
            расположение_цилиндровLabel.TabIndex = 9;
            расположение_цилиндровLabel.Text = "Расположение цилиндров:";
            // 
            // расположение_цилиндровTextBox
            // 
            this.расположение_цилиндровTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.двигательBindingSource, "Расположение_цилиндров", true));
            this.расположение_цилиндровTextBox.Location = new System.Drawing.Point(174, 146);
            this.расположение_цилиндровTextBox.Name = "расположение_цилиндровTextBox";
            this.расположение_цилиндровTextBox.Size = new System.Drawing.Size(121, 20);
            this.расположение_цилиндровTextBox.TabIndex = 10;
            // 
            // топливоLabel
            // 
            топливоLabel.AutoSize = true;
            топливоLabel.Location = new System.Drawing.Point(26, 175);
            топливоLabel.Name = "топливоLabel";
            топливоLabel.Size = new System.Drawing.Size(53, 13);
            топливоLabel.TabIndex = 11;
            топливоLabel.Text = "Топливо:";
            // 
            // топливоTextBox
            // 
            this.топливоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.двигательBindingSource, "Топливо", true));
            this.топливоTextBox.Location = new System.Drawing.Point(174, 172);
            this.топливоTextBox.Name = "топливоTextBox";
            this.топливоTextBox.Size = new System.Drawing.Size(121, 20);
            this.топливоTextBox.TabIndex = 12;
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
            // двигательBindingNavigatorSaveItem
            // 
            this.двигательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.двигательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("двигательBindingNavigatorSaveItem.Image")));
            this.двигательBindingNavigatorSaveItem.Name = "двигательBindingNavigatorSaveItem";
            this.двигательBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.двигательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.двигательBindingNavigatorSaveItem.Click += new System.EventHandler(this.двигательBindingNavigatorSaveItem_Click);
            // 
            // объемLabel
            // 
            объемLabel.AutoSize = true;
            объемLabel.Location = new System.Drawing.Point(26, 67);
            объемLabel.Name = "объемLabel";
            объемLabel.Size = new System.Drawing.Size(45, 13);
            объемLabel.TabIndex = 12;
            объемLabel.Text = "Объем:";
            // 
            // объемNumericUpDown
            // 
            this.объемNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.двигательBindingSource, "Объем", true));
            this.объемNumericUpDown.Location = new System.Drawing.Point(174, 65);
            this.объемNumericUpDown.Name = "объемNumericUpDown";
            this.объемNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.объемNumericUpDown.TabIndex = 13;
            // 
            // FormДвиг
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 208);
            this.Controls.Add(объемLabel);
            this.Controls.Add(this.объемNumericUpDown);
            this.Controls.Add(код_двигателяLabel);
            this.Controls.Add(this.код_двигателяTextBox);
            this.Controls.Add(количество_лошадейLabel);
            this.Controls.Add(this.количество_лошадейTextBox);
            this.Controls.Add(количество_цилиндровLabel);
            this.Controls.Add(this.количество_цилиндровTextBox);
            this.Controls.Add(расположение_цилиндровLabel);
            this.Controls.Add(this.расположение_цилиндровTextBox);
            this.Controls.Add(топливоLabel);
            this.Controls.Add(this.топливоTextBox);
            this.Controls.Add(this.двигательBindingNavigator);
            this.Name = "FormДвиг";
            this.Text = "FormДвиг";
            this.Load += new System.EventHandler(this.FormДвиг_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mimimi6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.двигательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.двигательBindingNavigator)).EndInit();
            this.двигательBindingNavigator.ResumeLayout(false);
            this.двигательBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объемNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mimimi6DataSet mimimi6DataSet;
        private System.Windows.Forms.BindingSource двигательBindingSource;
        private ToyotaCenter.mimimi6DataSetTableAdapters.ДвигательTableAdapter двигательTableAdapter;
        private ToyotaCenter.mimimi6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator двигательBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton двигательBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_двигателяTextBox;
        private System.Windows.Forms.TextBox количество_лошадейTextBox;
        private System.Windows.Forms.TextBox количество_цилиндровTextBox;
        private System.Windows.Forms.TextBox расположение_цилиндровTextBox;
        private System.Windows.Forms.TextBox топливоTextBox;
        private System.Windows.Forms.NumericUpDown объемNumericUpDown;
    }
}