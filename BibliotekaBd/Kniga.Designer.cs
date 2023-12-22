namespace BibliotekaBd
{
    partial class Kniga
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
            System.Windows.Forms.Label шифр_ISBNLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label фамилии_авторовLabel;
            System.Windows.Forms.Label место_изданияLabel;
            System.Windows.Forms.Label год_изданияLabel;
            System.Windows.Forms.Label количество_страницLabel;
            System.Windows.Forms.Label кол_во_экземпляровLabel;
            System.Windows.Forms.Label номер_залаLabel;
            System.Windows.Forms.Label код_областиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kniga));
            this.label2 = new System.Windows.Forms.Label();
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.книгаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгаTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.КнигаTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.книгаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.книгаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.шифр_ISBNTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.фамилии_авторовTextBox = new System.Windows.Forms.TextBox();
            this.место_изданияTextBox = new System.Windows.Forms.TextBox();
            this.год_изданияTextBox = new System.Windows.Forms.TextBox();
            this.количество_страницTextBox = new System.Windows.Forms.TextBox();
            this.кол_во_экземпляровTextBox = new System.Windows.Forms.TextBox();
            this.номер_залаTextBox = new System.Windows.Forms.TextBox();
            this.код_областиTextBox = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            шифр_ISBNLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            фамилии_авторовLabel = new System.Windows.Forms.Label();
            место_изданияLabel = new System.Windows.Forms.Label();
            год_изданияLabel = new System.Windows.Forms.Label();
            количество_страницLabel = new System.Windows.Forms.Label();
            кол_во_экземпляровLabel = new System.Windows.Forms.Label();
            номер_залаLabel = new System.Windows.Forms.Label();
            код_областиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingNavigator)).BeginInit();
            this.книгаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // шифр_ISBNLabel
            // 
            шифр_ISBNLabel.AutoSize = true;
            шифр_ISBNLabel.Location = new System.Drawing.Point(42, 74);
            шифр_ISBNLabel.Name = "шифр_ISBNLabel";
            шифр_ISBNLabel.Size = new System.Drawing.Size(67, 13);
            шифр_ISBNLabel.TabIndex = 3;
            шифр_ISBNLabel.Text = "Шифр ISBN:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(49, 113);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 4;
            названиеLabel.Text = "Название:";
            // 
            // фамилии_авторовLabel
            // 
            фамилии_авторовLabel.AutoSize = true;
            фамилии_авторовLabel.Location = new System.Drawing.Point(6, 150);
            фамилии_авторовLabel.Name = "фамилии_авторовLabel";
            фамилии_авторовLabel.Size = new System.Drawing.Size(103, 13);
            фамилии_авторовLabel.TabIndex = 6;
            фамилии_авторовLabel.Text = "Фамилии авторов:";
            // 
            // место_изданияLabel
            // 
            место_изданияLabel.AutoSize = true;
            место_изданияLabel.Location = new System.Drawing.Point(22, 188);
            место_изданияLabel.Name = "место_изданияLabel";
            место_изданияLabel.Size = new System.Drawing.Size(87, 13);
            место_изданияLabel.TabIndex = 8;
            место_изданияLabel.Text = "Место издания:";
            // 
            // год_изданияLabel
            // 
            год_изданияLabel.AutoSize = true;
            год_изданияLabel.Location = new System.Drawing.Point(36, 228);
            год_изданияLabel.Name = "год_изданияLabel";
            год_изданияLabel.Size = new System.Drawing.Size(73, 13);
            год_изданияLabel.TabIndex = 10;
            год_изданияLabel.Text = "Год издания:";
            // 
            // количество_страницLabel
            // 
            количество_страницLabel.AutoSize = true;
            количество_страницLabel.Location = new System.Drawing.Point(289, 188);
            количество_страницLabel.Name = "количество_страницLabel";
            количество_страницLabel.Size = new System.Drawing.Size(113, 13);
            количество_страницLabel.TabIndex = 12;
            количество_страницLabel.Text = "Количество страниц:";
            // 
            // кол_во_экземпляровLabel
            // 
            кол_во_экземпляровLabel.AutoSize = true;
            кол_во_экземпляровLabel.Location = new System.Drawing.Point(287, 150);
            кол_во_экземпляровLabel.Name = "кол_во_экземпляровLabel";
            кол_во_экземпляровLabel.Size = new System.Drawing.Size(115, 13);
            кол_во_экземпляровLabel.TabIndex = 14;
            кол_во_экземпляровLabel.Text = "Кол-во экземпляров:";
            // 
            // номер_залаLabel
            // 
            номер_залаLabel.AutoSize = true;
            номер_залаLabel.Location = new System.Drawing.Point(331, 116);
            номер_залаLabel.Name = "номер_залаLabel";
            номер_залаLabel.Size = new System.Drawing.Size(71, 13);
            номер_залаLabel.TabIndex = 16;
            номер_залаLabel.Text = "Номер зала:";
            // 
            // код_областиLabel
            // 
            код_областиLabel.AutoSize = true;
            код_областиLabel.Location = new System.Drawing.Point(329, 228);
            код_областиLabel.Name = "код_областиLabel";
            код_областиLabel.Size = new System.Drawing.Size(73, 13);
            код_областиLabel.TabIndex = 18;
            код_областиLabel.Text = "Код области:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(208, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Таблица \"Книга\"";
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгаBindingSource
            // 
            this.книгаBindingSource.DataMember = "Книга";
            this.книгаBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // книгаTableAdapter
            // 
            this.книгаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_читателяTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.КнигаTableAdapter = this.книгаTableAdapter;
            this.tableAdapterManager.Область_знанийTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Экземпляр_книгиTableAdapter = null;
            // 
            // книгаBindingNavigator
            // 
            this.книгаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.книгаBindingNavigator.BindingSource = this.книгаBindingSource;
            this.книгаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.книгаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.книгаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.книгаBindingNavigatorSaveItem});
            this.книгаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.книгаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.книгаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.книгаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.книгаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.книгаBindingNavigator.Name = "книгаBindingNavigator";
            this.книгаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.книгаBindingNavigator.Size = new System.Drawing.Size(592, 25);
            this.книгаBindingNavigator.TabIndex = 3;
            this.книгаBindingNavigator.Text = "bindingNavigator1";
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
            // книгаBindingNavigatorSaveItem
            // 
            this.книгаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.книгаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("книгаBindingNavigatorSaveItem.Image")));
            this.книгаBindingNavigatorSaveItem.Name = "книгаBindingNavigatorSaveItem";
            this.книгаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.книгаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.книгаBindingNavigatorSaveItem.Click += new System.EventHandler(this.книгаBindingNavigatorSaveItem_Click);
            // 
            // шифр_ISBNTextBox
            // 
            this.шифр_ISBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Шифр_ISBN", true));
            this.шифр_ISBNTextBox.Location = new System.Drawing.Point(115, 71);
            this.шифр_ISBNTextBox.Name = "шифр_ISBNTextBox";
            this.шифр_ISBNTextBox.Size = new System.Drawing.Size(393, 20);
            this.шифр_ISBNTextBox.TabIndex = 4;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(115, 110);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(154, 20);
            this.названиеTextBox.TabIndex = 5;
            // 
            // фамилии_авторовTextBox
            // 
            this.фамилии_авторовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Фамилии авторов", true));
            this.фамилии_авторовTextBox.Location = new System.Drawing.Point(115, 147);
            this.фамилии_авторовTextBox.Name = "фамилии_авторовTextBox";
            this.фамилии_авторовTextBox.Size = new System.Drawing.Size(154, 20);
            this.фамилии_авторовTextBox.TabIndex = 7;
            // 
            // место_изданияTextBox
            // 
            this.место_изданияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Место издания", true));
            this.место_изданияTextBox.Location = new System.Drawing.Point(115, 185);
            this.место_изданияTextBox.Name = "место_изданияTextBox";
            this.место_изданияTextBox.Size = new System.Drawing.Size(154, 20);
            this.место_изданияTextBox.TabIndex = 9;
            // 
            // год_изданияTextBox
            // 
            this.год_изданияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Год издания", true));
            this.год_изданияTextBox.Location = new System.Drawing.Point(115, 225);
            this.год_изданияTextBox.Name = "год_изданияTextBox";
            this.год_изданияTextBox.Size = new System.Drawing.Size(154, 20);
            this.год_изданияTextBox.TabIndex = 11;
            // 
            // количество_страницTextBox
            // 
            this.количество_страницTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Количество страниц", true));
            this.количество_страницTextBox.Location = new System.Drawing.Point(408, 185);
            this.количество_страницTextBox.Name = "количество_страницTextBox";
            this.количество_страницTextBox.Size = new System.Drawing.Size(100, 20);
            this.количество_страницTextBox.TabIndex = 13;
            // 
            // кол_во_экземпляровTextBox
            // 
            this.кол_во_экземпляровTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Кол-во экземпляров", true));
            this.кол_во_экземпляровTextBox.Location = new System.Drawing.Point(408, 147);
            this.кол_во_экземпляровTextBox.Name = "кол_во_экземпляровTextBox";
            this.кол_во_экземпляровTextBox.Size = new System.Drawing.Size(100, 20);
            this.кол_во_экземпляровTextBox.TabIndex = 15;
            // 
            // номер_залаTextBox
            // 
            this.номер_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Номер зала", true));
            this.номер_залаTextBox.Location = new System.Drawing.Point(408, 113);
            this.номер_залаTextBox.Name = "номер_залаTextBox";
            this.номер_залаTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_залаTextBox.TabIndex = 17;
            // 
            // код_областиTextBox
            // 
            this.код_областиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Код области", true));
            this.код_областиTextBox.Location = new System.Drawing.Point(408, 225);
            this.код_областиTextBox.Name = "код_областиTextBox";
            this.код_областиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_областиTextBox.TabIndex = 19;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(249, 350);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 26;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(367, 321);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(109, 23);
            this.btnremove.TabIndex = 25;
            this.btnremove.Text = "Удалить";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(249, 321);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 23);
            this.btnnext.TabIndex = 24;
            this.btnnext.Text = "Следующая";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click_1);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(124, 321);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(103, 23);
            this.btnlast.TabIndex = 23;
            this.btnlast.Text = "Последняя";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(367, 292);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 23);
            this.btnadd.TabIndex = 22;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(249, 292);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 23);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Предыдущая";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(124, 292);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(103, 23);
            this.btnfirst.TabIndex = 20;
            this.btnfirst.Text = "Первая";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Выдача справок о наличии книг заданного автора";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kniga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(код_областиLabel);
            this.Controls.Add(this.код_областиTextBox);
            this.Controls.Add(номер_залаLabel);
            this.Controls.Add(this.номер_залаTextBox);
            this.Controls.Add(кол_во_экземпляровLabel);
            this.Controls.Add(this.кол_во_экземпляровTextBox);
            this.Controls.Add(количество_страницLabel);
            this.Controls.Add(this.количество_страницTextBox);
            this.Controls.Add(год_изданияLabel);
            this.Controls.Add(this.год_изданияTextBox);
            this.Controls.Add(место_изданияLabel);
            this.Controls.Add(this.место_изданияTextBox);
            this.Controls.Add(фамилии_авторовLabel);
            this.Controls.Add(this.фамилии_авторовTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(шифр_ISBNLabel);
            this.Controls.Add(this.шифр_ISBNTextBox);
            this.Controls.Add(this.книгаBindingNavigator);
            this.Controls.Add(this.label2);
            this.Name = "Kniga";
            this.Text = "Kniga";
            this.Load += new System.EventHandler(this.Kniga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingNavigator)).EndInit();
            this.книгаBindingNavigator.ResumeLayout(false);
            this.книгаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource книгаBindingSource;
        private BibliotekaDataSetTableAdapters.КнигаTableAdapter книгаTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator книгаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton книгаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox шифр_ISBNTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox фамилии_авторовTextBox;
        private System.Windows.Forms.TextBox место_изданияTextBox;
        private System.Windows.Forms.TextBox год_изданияTextBox;
        private System.Windows.Forms.TextBox количество_страницTextBox;
        private System.Windows.Forms.TextBox кол_во_экземпляровTextBox;
        private System.Windows.Forms.TextBox номер_залаTextBox;
        private System.Windows.Forms.TextBox код_областиTextBox;
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