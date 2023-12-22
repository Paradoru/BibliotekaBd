namespace BibliotekaBd
{
    partial class Eczemplyar
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
            System.Windows.Forms.Label инвентарный_номерLabel;
            System.Windows.Forms.Label шифр_ISBNLabel;
            System.Windows.Forms.Label состояние_книгиLabel;
            System.Windows.Forms.Label место_размещенияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eczemplyar));
            this.label2 = new System.Windows.Forms.Label();
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.экземпляр_книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экземпляр_книгиTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.Экземпляр_книгиTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.экземпляр_книгиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.экземпляр_книгиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.инвентарный_номерTextBox = new System.Windows.Forms.TextBox();
            this.шифр_ISBNTextBox = new System.Windows.Forms.TextBox();
            this.состояние_книгиTextBox = new System.Windows.Forms.TextBox();
            this.место_размещенияTextBox = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            инвентарный_номерLabel = new System.Windows.Forms.Label();
            шифр_ISBNLabel = new System.Windows.Forms.Label();
            состояние_книгиLabel = new System.Windows.Forms.Label();
            место_размещенияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземпляр_книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземпляр_книгиBindingNavigator)).BeginInit();
            this.экземпляр_книгиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // инвентарный_номерLabel
            // 
            инвентарный_номерLabel.AutoSize = true;
            инвентарный_номерLabel.Location = new System.Drawing.Point(63, 100);
            инвентарный_номерLabel.Name = "инвентарный_номерLabel";
            инвентарный_номерLabel.Size = new System.Drawing.Size(114, 13);
            инвентарный_номерLabel.TabIndex = 3;
            инвентарный_номерLabel.Text = "Инвентарный номер:";
            // 
            // шифр_ISBNLabel
            // 
            шифр_ISBNLabel.AutoSize = true;
            шифр_ISBNLabel.Location = new System.Drawing.Point(110, 143);
            шифр_ISBNLabel.Name = "шифр_ISBNLabel";
            шифр_ISBNLabel.Size = new System.Drawing.Size(67, 13);
            шифр_ISBNLabel.TabIndex = 4;
            шифр_ISBNLabel.Text = "Шифр ISBN:";
            // 
            // состояние_книгиLabel
            // 
            состояние_книгиLabel.AutoSize = true;
            состояние_книгиLabel.Location = new System.Drawing.Point(418, 100);
            состояние_книгиLabel.Name = "состояние_книгиLabel";
            состояние_книгиLabel.Size = new System.Drawing.Size(96, 13);
            состояние_книгиLabel.TabIndex = 6;
            состояние_книгиLabel.Text = "Состояние книги:";
            // 
            // место_размещенияLabel
            // 
            место_размещенияLabel.AutoSize = true;
            место_размещенияLabel.Location = new System.Drawing.Point(404, 143);
            место_размещенияLabel.Name = "место_размещенияLabel";
            место_размещенияLabel.Size = new System.Drawing.Size(110, 13);
            место_размещенияLabel.TabIndex = 8;
            место_размещенияLabel.Text = "Место размещения:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(251, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Таблица \"Экземпляр книги\"";
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экземпляр_книгиBindingSource
            // 
            this.экземпляр_книгиBindingSource.DataMember = "Экземпляр книги";
            this.экземпляр_книгиBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // экземпляр_книгиTableAdapter
            // 
            this.экземпляр_книгиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_читателяTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.Область_знанийTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Экземпляр_книгиTableAdapter = this.экземпляр_книгиTableAdapter;
            // 
            // экземпляр_книгиBindingNavigator
            // 
            this.экземпляр_книгиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.экземпляр_книгиBindingNavigator.BindingSource = this.экземпляр_книгиBindingSource;
            this.экземпляр_книгиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.экземпляр_книгиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.экземпляр_книгиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.экземпляр_книгиBindingNavigatorSaveItem});
            this.экземпляр_книгиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.экземпляр_книгиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.экземпляр_книгиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.экземпляр_книгиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.экземпляр_книгиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.экземпляр_книгиBindingNavigator.Name = "экземпляр_книгиBindingNavigator";
            this.экземпляр_книгиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.экземпляр_книгиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.экземпляр_книгиBindingNavigator.TabIndex = 3;
            this.экземпляр_книгиBindingNavigator.Text = "bindingNavigator1";
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
            // экземпляр_книгиBindingNavigatorSaveItem
            // 
            this.экземпляр_книгиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.экземпляр_книгиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("экземпляр_книгиBindingNavigatorSaveItem.Image")));
            this.экземпляр_книгиBindingNavigatorSaveItem.Name = "экземпляр_книгиBindingNavigatorSaveItem";
            this.экземпляр_книгиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.экземпляр_книгиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.экземпляр_книгиBindingNavigatorSaveItem.Click += new System.EventHandler(this.экземпляр_книгиBindingNavigatorSaveItem_Click);
            // 
            // инвентарный_номерTextBox
            // 
            this.инвентарный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экземпляр_книгиBindingSource, "Инвентарный номер", true));
            this.инвентарный_номерTextBox.Location = new System.Drawing.Point(183, 97);
            this.инвентарный_номерTextBox.Name = "инвентарный_номерTextBox";
            this.инвентарный_номерTextBox.Size = new System.Drawing.Size(129, 20);
            this.инвентарный_номерTextBox.TabIndex = 4;
            // 
            // шифр_ISBNTextBox
            // 
            this.шифр_ISBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экземпляр_книгиBindingSource, "Шифр_ISBN", true));
            this.шифр_ISBNTextBox.Location = new System.Drawing.Point(183, 140);
            this.шифр_ISBNTextBox.Name = "шифр_ISBNTextBox";
            this.шифр_ISBNTextBox.Size = new System.Drawing.Size(129, 20);
            this.шифр_ISBNTextBox.TabIndex = 5;
            // 
            // состояние_книгиTextBox
            // 
            this.состояние_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экземпляр_книгиBindingSource, "Состояние книги", true));
            this.состояние_книгиTextBox.Location = new System.Drawing.Point(520, 97);
            this.состояние_книгиTextBox.Name = "состояние_книгиTextBox";
            this.состояние_книгиTextBox.Size = new System.Drawing.Size(125, 20);
            this.состояние_книгиTextBox.TabIndex = 7;
            // 
            // место_размещенияTextBox
            // 
            this.место_размещенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экземпляр_книгиBindingSource, "Место размещения", true));
            this.место_размещенияTextBox.Location = new System.Drawing.Point(520, 140);
            this.место_размещенияTextBox.Name = "место_размещенияTextBox";
            this.место_размещенияTextBox.Size = new System.Drawing.Size(125, 20);
            this.место_размещенияTextBox.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(407, 373);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 40;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(461, 344);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(109, 23);
            this.btnremove.TabIndex = 39;
            this.btnremove.Text = "Удалить";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(343, 344);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 23);
            this.btnnext.TabIndex = 38;
            this.btnnext.Text = "Следующая";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(218, 344);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(103, 23);
            this.btnlast.TabIndex = 37;
            this.btnlast.Text = "Последняя";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(461, 315);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 23);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(343, 315);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 23);
            this.btnback.TabIndex = 35;
            this.btnback.Text = "Предыдущая";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(218, 315);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(103, 23);
            this.btnfirst.TabIndex = 34;
            this.btnfirst.Text = "Первая";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Списание книги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eczemplyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(место_размещенияLabel);
            this.Controls.Add(this.место_размещенияTextBox);
            this.Controls.Add(состояние_книгиLabel);
            this.Controls.Add(this.состояние_книгиTextBox);
            this.Controls.Add(шифр_ISBNLabel);
            this.Controls.Add(this.шифр_ISBNTextBox);
            this.Controls.Add(инвентарный_номерLabel);
            this.Controls.Add(this.инвентарный_номерTextBox);
            this.Controls.Add(this.экземпляр_книгиBindingNavigator);
            this.Controls.Add(this.label2);
            this.Name = "Eczemplyar";
            this.Text = "Eczemplyar";
            this.Load += new System.EventHandler(this.Eczemplyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземпляр_книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземпляр_книгиBindingNavigator)).EndInit();
            this.экземпляр_книгиBindingNavigator.ResumeLayout(false);
            this.экземпляр_книгиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource экземпляр_книгиBindingSource;
        private BibliotekaDataSetTableAdapters.Экземпляр_книгиTableAdapter экземпляр_книгиTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator экземпляр_книгиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton экземпляр_книгиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox инвентарный_номерTextBox;
        private System.Windows.Forms.TextBox шифр_ISBNTextBox;
        private System.Windows.Forms.TextBox состояние_книгиTextBox;
        private System.Windows.Forms.TextBox место_размещенияTextBox;
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