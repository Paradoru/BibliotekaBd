namespace BibliotekaBd
{
    partial class Chitatel
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
            System.Windows.Forms.Label iD_ЧитателяLabel;
            System.Windows.Forms.Label номер_залаLabel;
            System.Windows.Forms.Label адрес_проживанияLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chitatel));
            this.label2 = new System.Windows.Forms.Label();
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.журнал_читателяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.журнал_читателяTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.Журнал_читателяTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.читательTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.ЧитательTableAdapter();
            this.журнал_читателяBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.журнал_читателяBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.читательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_ЧитателяTextBox = new System.Windows.Forms.TextBox();
            this.номер_залаTextBox = new System.Windows.Forms.TextBox();
            this.адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.tablechitatel = new System.Windows.Forms.Button();
            iD_ЧитателяLabel = new System.Windows.Forms.Label();
            номер_залаLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingNavigator)).BeginInit();
            this.журнал_читателяBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ЧитателяLabel
            // 
            iD_ЧитателяLabel.AutoSize = true;
            iD_ЧитателяLabel.Location = new System.Drawing.Point(52, 83);
            iD_ЧитателяLabel.Name = "iD_ЧитателяLabel";
            iD_ЧитателяLabel.Size = new System.Drawing.Size(72, 13);
            iD_ЧитателяLabel.TabIndex = 3;
            iD_ЧитателяLabel.Text = "ID Читателя:";
            // 
            // номер_залаLabel
            // 
            номер_залаLabel.AutoSize = true;
            номер_залаLabel.Location = new System.Drawing.Point(53, 125);
            номер_залаLabel.Name = "номер_залаLabel";
            номер_залаLabel.Size = new System.Drawing.Size(71, 13);
            номер_залаLabel.TabIndex = 4;
            номер_залаLabel.Text = "Номер зала:";
            // 
            // адрес_проживанияLabel
            // 
            адрес_проживанияLabel.AutoSize = true;
            адрес_проживанияLabel.Location = new System.Drawing.Point(18, 168);
            адрес_проживанияLabel.Name = "адрес_проживанияLabel";
            адрес_проживанияLabel.Size = new System.Drawing.Size(106, 13);
            адрес_проживанияLabel.TabIndex = 6;
            адрес_проживанияLabel.Text = "Адрес проживания:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(334, 102);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(96, 13);
            номер_телефонаLabel.TabIndex = 8;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(341, 147);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 10;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(235, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Таблица \"Читатель\"";
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // журнал_читателяBindingSource
            // 
            this.журнал_читателяBindingSource.DataMember = "Журнал читателя";
            this.журнал_читателяBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // журнал_читателяTableAdapter
            // 
            this.журнал_читателяTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_читателяTableAdapter = this.журнал_читателяTableAdapter;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.Область_знанийTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = this.читательTableAdapter;
            this.tableAdapterManager.Экземпляр_книгиTableAdapter = null;
            // 
            // читательTableAdapter
            // 
            this.читательTableAdapter.ClearBeforeFill = true;
            // 
            // журнал_читателяBindingNavigator
            // 
            this.журнал_читателяBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.журнал_читателяBindingNavigator.BindingSource = this.журнал_читателяBindingSource;
            this.журнал_читателяBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.журнал_читателяBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.журнал_читателяBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.журнал_читателяBindingNavigatorSaveItem});
            this.журнал_читателяBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.журнал_читателяBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.журнал_читателяBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.журнал_читателяBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.журнал_читателяBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.журнал_читателяBindingNavigator.Name = "журнал_читателяBindingNavigator";
            this.журнал_читателяBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.журнал_читателяBindingNavigator.Size = new System.Drawing.Size(689, 25);
            this.журнал_читателяBindingNavigator.TabIndex = 3;
            this.журнал_читателяBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // журнал_читателяBindingNavigatorSaveItem
            // 
            this.журнал_читателяBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.журнал_читателяBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("журнал_читателяBindingNavigatorSaveItem.Image")));
            this.журнал_читателяBindingNavigatorSaveItem.Name = "журнал_читателяBindingNavigatorSaveItem";
            this.журнал_читателяBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.журнал_читателяBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.журнал_читателяBindingNavigatorSaveItem.Click += new System.EventHandler(this.журнал_читателяBindingNavigatorSaveItem_Click);
            // 
            // читательBindingSource
            // 
            this.читательBindingSource.DataMember = "Читатель";
            this.читательBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // iD_ЧитателяTextBox
            // 
            this.iD_ЧитателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "ID Читателя", true));
            this.iD_ЧитателяTextBox.Location = new System.Drawing.Point(130, 80);
            this.iD_ЧитателяTextBox.Name = "iD_ЧитателяTextBox";
            this.iD_ЧитателяTextBox.Size = new System.Drawing.Size(184, 20);
            this.iD_ЧитателяTextBox.TabIndex = 4;
            // 
            // номер_залаTextBox
            // 
            this.номер_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "Номер зала", true));
            this.номер_залаTextBox.Location = new System.Drawing.Point(130, 122);
            this.номер_залаTextBox.Name = "номер_залаTextBox";
            this.номер_залаTextBox.Size = new System.Drawing.Size(184, 20);
            this.номер_залаTextBox.TabIndex = 5;
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "Адрес проживания", true));
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(130, 165);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(184, 20);
            this.адрес_проживанияTextBox.TabIndex = 7;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "Номер телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(436, 99);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(200, 20);
            this.номер_телефонаTextBox.TabIndex = 9;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.читательBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(436, 143);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 11;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(344, 355);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(402, 326);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(109, 23);
            this.btnremove.TabIndex = 18;
            this.btnremove.Text = "Удалить";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(284, 326);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 23);
            this.btnnext.TabIndex = 17;
            this.btnnext.Text = "Следующая";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(159, 326);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(103, 23);
            this.btnlast.TabIndex = 16;
            this.btnlast.Text = "Последняя";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(402, 297);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 23);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(284, 297);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 23);
            this.btnback.TabIndex = 14;
            this.btnback.Text = "Предыдущая";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(159, 297);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(103, 23);
            this.btnfirst.TabIndex = 13;
            this.btnfirst.Text = "Первая";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // tablechitatel
            // 
            this.tablechitatel.Location = new System.Drawing.Point(222, 355);
            this.tablechitatel.Name = "tablechitatel";
            this.tablechitatel.Size = new System.Drawing.Size(103, 23);
            this.tablechitatel.TabIndex = 20;
            this.tablechitatel.Text = "Таблица";
            this.tablechitatel.UseVisualStyleBackColor = true;
            this.tablechitatel.Click += new System.EventHandler(this.tablechitatel_Click);
            // 
            // Chitatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.tablechitatel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаTextBox);
            this.Controls.Add(адрес_проживанияLabel);
            this.Controls.Add(this.адрес_проживанияTextBox);
            this.Controls.Add(номер_залаLabel);
            this.Controls.Add(this.номер_залаTextBox);
            this.Controls.Add(iD_ЧитателяLabel);
            this.Controls.Add(this.iD_ЧитателяTextBox);
            this.Controls.Add(this.журнал_читателяBindingNavigator);
            this.Controls.Add(this.label2);
            this.Name = "Chitatel";
            this.Text = "Chitatel";
            this.Load += new System.EventHandler(this.Chitatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingNavigator)).EndInit();
            this.журнал_читателяBindingNavigator.ResumeLayout(false);
            this.журнал_читателяBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource журнал_читателяBindingSource;
        private BibliotekaDataSetTableAdapters.Журнал_читателяTableAdapter журнал_читателяTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator журнал_читателяBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton журнал_читателяBindingNavigatorSaveItem;
        private BibliotekaDataSetTableAdapters.ЧитательTableAdapter читательTableAdapter;
        private System.Windows.Forms.BindingSource читательBindingSource;
        private System.Windows.Forms.TextBox iD_ЧитателяTextBox;
        private System.Windows.Forms.TextBox номер_залаTextBox;
        private System.Windows.Forms.TextBox адрес_проживанияTextBox;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button tablechitatel;
    }
}