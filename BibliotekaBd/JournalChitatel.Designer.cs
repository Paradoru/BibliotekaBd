namespace BibliotekaBd
{
    partial class JournalChitatel
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
            System.Windows.Forms.Label уникальный_IDLabel;
            System.Windows.Forms.Label инвентарный_номерLabel;
            System.Windows.Forms.Label iD_ЧитателяLabel;
            System.Windows.Forms.Label уникальный_IDLabel1;
            System.Windows.Forms.Label дата_выдачиLabel;
            System.Windows.Forms.Label дата_возвратаLabel;
            System.Windows.Forms.Label шифр_ISBNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalChitatel));
            this.label2 = new System.Windows.Forms.Label();
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.журнал_читателяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.журнал_читателяTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.Журнал_читателяTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
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
            this.уникальный_IDTextBox = new System.Windows.Forms.TextBox();
            this.инвентарный_номерTextBox = new System.Windows.Forms.TextBox();
            this.iD_ЧитателяTextBox = new System.Windows.Forms.TextBox();
            this.уникальный_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.дата_выдачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_возвратаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.шифр_ISBNTextBox = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            уникальный_IDLabel = new System.Windows.Forms.Label();
            инвентарный_номерLabel = new System.Windows.Forms.Label();
            iD_ЧитателяLabel = new System.Windows.Forms.Label();
            уникальный_IDLabel1 = new System.Windows.Forms.Label();
            дата_выдачиLabel = new System.Windows.Forms.Label();
            дата_возвратаLabel = new System.Windows.Forms.Label();
            шифр_ISBNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingNavigator)).BeginInit();
            this.журнал_читателяBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // уникальный_IDLabel
            // 
            уникальный_IDLabel.AutoSize = true;
            уникальный_IDLabel.Location = new System.Drawing.Point(31, 76);
            уникальный_IDLabel.Name = "уникальный_IDLabel";
            уникальный_IDLabel.Size = new System.Drawing.Size(88, 13);
            уникальный_IDLabel.TabIndex = 2;
            уникальный_IDLabel.Text = "Уникальный ID:";
            // 
            // инвентарный_номерLabel
            // 
            инвентарный_номерLabel.AutoSize = true;
            инвентарный_номерLabel.Location = new System.Drawing.Point(5, 115);
            инвентарный_номерLabel.Name = "инвентарный_номерLabel";
            инвентарный_номерLabel.Size = new System.Drawing.Size(114, 13);
            инвентарный_номерLabel.TabIndex = 4;
            инвентарный_номерLabel.Text = "Инвентарный номер:";
            // 
            // iD_ЧитателяLabel
            // 
            iD_ЧитателяLabel.AutoSize = true;
            iD_ЧитателяLabel.Location = new System.Drawing.Point(47, 154);
            iD_ЧитателяLabel.Name = "iD_ЧитателяLabel";
            iD_ЧитателяLabel.Size = new System.Drawing.Size(72, 13);
            iD_ЧитателяLabel.TabIndex = 6;
            iD_ЧитателяLabel.Text = "ID Читателя:";
            // 
            // уникальный_IDLabel1
            // 
            уникальный_IDLabel1.AutoSize = true;
            уникальный_IDLabel1.Location = new System.Drawing.Point(394, 76);
            уникальный_IDLabel1.Name = "уникальный_IDLabel1";
            уникальный_IDLabel1.Size = new System.Drawing.Size(88, 13);
            уникальный_IDLabel1.TabIndex = 8;
            уникальный_IDLabel1.Text = "Уникальный ID:";
            // 
            // дата_выдачиLabel
            // 
            дата_выдачиLabel.AutoSize = true;
            дата_выдачиLabel.Location = new System.Drawing.Point(406, 116);
            дата_выдачиLabel.Name = "дата_выдачиLabel";
            дата_выдачиLabel.Size = new System.Drawing.Size(76, 13);
            дата_выдачиLabel.TabIndex = 10;
            дата_выдачиLabel.Text = "Дата выдачи:";
            // 
            // дата_возвратаLabel
            // 
            дата_возвратаLabel.AutoSize = true;
            дата_возвратаLabel.Location = new System.Drawing.Point(396, 155);
            дата_возвратаLabel.Name = "дата_возвратаLabel";
            дата_возвратаLabel.Size = new System.Drawing.Size(86, 13);
            дата_возвратаLabel.TabIndex = 12;
            дата_возвратаLabel.Text = "Дата возврата:";
            // 
            // шифр_ISBNLabel
            // 
            шифр_ISBNLabel.AutoSize = true;
            шифр_ISBNLabel.Location = new System.Drawing.Point(197, 208);
            шифр_ISBNLabel.Name = "шифр_ISBNLabel";
            шифр_ISBNLabel.Size = new System.Drawing.Size(67, 13);
            шифр_ISBNLabel.TabIndex = 14;
            шифр_ISBNLabel.Text = "Шифр ISBN:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(266, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблица \"Журнал читателя\"";
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
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Экземпляр_книгиTableAdapter = null;
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
            this.журнал_читателяBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.журнал_читателяBindingNavigator.TabIndex = 2;
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
            this.журнал_читателяBindingNavigatorSaveItem.Click += new System.EventHandler(this.журнал_читателяBindingNavigatorSaveItem_Click_1);
            // 
            // уникальный_IDTextBox
            // 
            this.уникальный_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.журнал_читателяBindingSource, "Уникальный ID", true));
            this.уникальный_IDTextBox.Location = new System.Drawing.Point(125, 73);
            this.уникальный_IDTextBox.Name = "уникальный_IDTextBox";
            this.уникальный_IDTextBox.Size = new System.Drawing.Size(139, 20);
            this.уникальный_IDTextBox.TabIndex = 3;
            // 
            // инвентарный_номерTextBox
            // 
            this.инвентарный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.журнал_читателяBindingSource, "Инвентарный номер", true));
            this.инвентарный_номерTextBox.Location = new System.Drawing.Point(125, 112);
            this.инвентарный_номерTextBox.Name = "инвентарный_номерTextBox";
            this.инвентарный_номерTextBox.Size = new System.Drawing.Size(139, 20);
            this.инвентарный_номерTextBox.TabIndex = 5;
            // 
            // iD_ЧитателяTextBox
            // 
            this.iD_ЧитателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.журнал_читателяBindingSource, "ID Читателя", true));
            this.iD_ЧитателяTextBox.Location = new System.Drawing.Point(125, 151);
            this.iD_ЧитателяTextBox.Name = "iD_ЧитателяTextBox";
            this.iD_ЧитателяTextBox.Size = new System.Drawing.Size(139, 20);
            this.iD_ЧитателяTextBox.TabIndex = 7;
            // 
            // уникальный_IDTextBox1
            // 
            this.уникальный_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.журнал_читателяBindingSource, "Уникальный ID", true));
            this.уникальный_IDTextBox1.Location = new System.Drawing.Point(488, 73);
            this.уникальный_IDTextBox1.Name = "уникальный_IDTextBox1";
            this.уникальный_IDTextBox1.Size = new System.Drawing.Size(200, 20);
            this.уникальный_IDTextBox1.TabIndex = 9;
            // 
            // дата_выдачиDateTimePicker
            // 
            this.дата_выдачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.журнал_читателяBindingSource, "Дата выдачи", true));
            this.дата_выдачиDateTimePicker.Location = new System.Drawing.Point(488, 112);
            this.дата_выдачиDateTimePicker.Name = "дата_выдачиDateTimePicker";
            this.дата_выдачиDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_выдачиDateTimePicker.TabIndex = 11;
            // 
            // дата_возвратаDateTimePicker
            // 
            this.дата_возвратаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.журнал_читателяBindingSource, "Дата возврата", true));
            this.дата_возвратаDateTimePicker.Location = new System.Drawing.Point(488, 151);
            this.дата_возвратаDateTimePicker.Name = "дата_возвратаDateTimePicker";
            this.дата_возвратаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_возвратаDateTimePicker.TabIndex = 13;
            // 
            // шифр_ISBNTextBox
            // 
            this.шифр_ISBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.журнал_читателяBindingSource, "Шифр_ISBN", true));
            this.шифр_ISBNTextBox.Location = new System.Drawing.Point(270, 205);
            this.шифр_ISBNTextBox.Name = "шифр_ISBNTextBox";
            this.шифр_ISBNTextBox.Size = new System.Drawing.Size(289, 20);
            this.шифр_ISBNTextBox.TabIndex = 15;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(343, 345);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 33;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(461, 316);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(109, 23);
            this.btnremove.TabIndex = 32;
            this.btnremove.Text = "Удалить";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(343, 316);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 23);
            this.btnnext.TabIndex = 31;
            this.btnnext.Text = "Следующая";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(218, 316);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(103, 23);
            this.btnlast.TabIndex = 30;
            this.btnlast.Text = "Последняя";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(461, 287);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 23);
            this.btnadd.TabIndex = 29;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(343, 287);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 23);
            this.btnback.TabIndex = 28;
            this.btnback.Text = "Предыдущая";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(218, 287);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(103, 23);
            this.btnfirst.TabIndex = 27;
            this.btnfirst.Text = "Первая";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Список читателей, взявших в прокат определённое количество книг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JournalChitatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(шифр_ISBNLabel);
            this.Controls.Add(this.шифр_ISBNTextBox);
            this.Controls.Add(дата_возвратаLabel);
            this.Controls.Add(this.дата_возвратаDateTimePicker);
            this.Controls.Add(дата_выдачиLabel);
            this.Controls.Add(this.дата_выдачиDateTimePicker);
            this.Controls.Add(уникальный_IDLabel1);
            this.Controls.Add(this.уникальный_IDTextBox1);
            this.Controls.Add(iD_ЧитателяLabel);
            this.Controls.Add(this.iD_ЧитателяTextBox);
            this.Controls.Add(инвентарный_номерLabel);
            this.Controls.Add(this.инвентарный_номерTextBox);
            this.Controls.Add(уникальный_IDLabel);
            this.Controls.Add(this.уникальный_IDTextBox);
            this.Controls.Add(this.журнал_читателяBindingNavigator);
            this.Controls.Add(this.label2);
            this.Name = "JournalChitatel";
            this.Text = "JournalChitatel";
            this.Load += new System.EventHandler(this.JournalChitatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_читателяBindingNavigator)).EndInit();
            this.журнал_читателяBindingNavigator.ResumeLayout(false);
            this.журнал_читателяBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox уникальный_IDTextBox;
        private System.Windows.Forms.TextBox инвентарный_номерTextBox;
        private System.Windows.Forms.TextBox iD_ЧитателяTextBox;
        private System.Windows.Forms.TextBox уникальный_IDTextBox1;
        private System.Windows.Forms.DateTimePicker дата_выдачиDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_возвратаDateTimePicker;
        private System.Windows.Forms.TextBox шифр_ISBNTextBox;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button button1;
    }
}