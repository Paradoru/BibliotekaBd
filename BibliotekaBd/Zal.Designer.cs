namespace BibliotekaBd
{
    partial class Zal
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
            System.Windows.Forms.Label категорияLabel;
            System.Windows.Forms.Label номер_залаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zal));
            this.label2 = new System.Windows.Forms.Label();
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.залBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.залTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.ЗалTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.залBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.залBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.категорияTextBox = new System.Windows.Forms.TextBox();
            this.номер_залаTextBox = new System.Windows.Forms.TextBox();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            категорияLabel = new System.Windows.Forms.Label();
            номер_залаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingNavigator)).BeginInit();
            this.залBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // категорияLabel
            // 
            категорияLabel.AutoSize = true;
            категорияLabel.Location = new System.Drawing.Point(21, 93);
            категорияLabel.Name = "категорияLabel";
            категорияLabel.Size = new System.Drawing.Size(63, 13);
            категорияLabel.TabIndex = 3;
            категорияLabel.Text = "Категория:";
            // 
            // номер_залаLabel
            // 
            номер_залаLabel.AutoSize = true;
            номер_залаLabel.Location = new System.Drawing.Point(281, 93);
            номер_залаLabel.Name = "номер_залаLabel";
            номер_залаLabel.Size = new System.Drawing.Size(71, 13);
            номер_залаLabel.TabIndex = 4;
            номер_залаLabel.Text = "Номер зала:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(189, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Таблица \"Зал\"";
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залBindingSource
            // 
            this.залBindingSource.DataMember = "Зал";
            this.залBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // залTableAdapter
            // 
            this.залTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_читателяTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = this.залTableAdapter;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.Область_знанийTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Экземпляр_книгиTableAdapter = null;
            // 
            // залBindingNavigator
            // 
            this.залBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.залBindingNavigator.BindingSource = this.залBindingSource;
            this.залBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.залBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.залBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.залBindingNavigatorSaveItem});
            this.залBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.залBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.залBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.залBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.залBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.залBindingNavigator.Name = "залBindingNavigator";
            this.залBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.залBindingNavigator.Size = new System.Drawing.Size(512, 25);
            this.залBindingNavigator.TabIndex = 3;
            this.залBindingNavigator.Text = "bindingNavigator1";
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
            // залBindingNavigatorSaveItem
            // 
            this.залBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.залBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("залBindingNavigatorSaveItem.Image")));
            this.залBindingNavigatorSaveItem.Name = "залBindingNavigatorSaveItem";
            this.залBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.залBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.залBindingNavigatorSaveItem.Click += new System.EventHandler(this.залBindingNavigatorSaveItem_Click);
            // 
            // категорияTextBox
            // 
            this.категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залBindingSource, "Категория", true));
            this.категорияTextBox.Location = new System.Drawing.Point(90, 90);
            this.категорияTextBox.Name = "категорияTextBox";
            this.категорияTextBox.Size = new System.Drawing.Size(185, 20);
            this.категорияTextBox.TabIndex = 4;
            // 
            // номер_залаTextBox
            // 
            this.номер_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залBindingSource, "Номер зала", true));
            this.номер_залаTextBox.Location = new System.Drawing.Point(358, 90);
            this.номер_залаTextBox.Name = "номер_залаTextBox";
            this.номер_залаTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_залаTextBox.TabIndex = 5;
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(90, 216);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(103, 23);
            this.btnfirst.TabIndex = 6;
            this.btnfirst.Text = "Первая";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(215, 216);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 23);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Предыдущая";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(333, 216);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(90, 245);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(103, 23);
            this.btnlast.TabIndex = 9;
            this.btnlast.Text = "Последняя";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(215, 245);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 23);
            this.btnnext.TabIndex = 10;
            this.btnnext.Text = "Следующая";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(333, 245);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(109, 23);
            this.btnremove.TabIndex = 11;
            this.btnremove.Text = "Удалить";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(215, 274);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Zal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 335);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(номер_залаLabel);
            this.Controls.Add(this.номер_залаTextBox);
            this.Controls.Add(категорияLabel);
            this.Controls.Add(this.категорияTextBox);
            this.Controls.Add(this.залBindingNavigator);
            this.Controls.Add(this.label2);
            this.Name = "Zal";
            this.Text = "Zal";
            this.Load += new System.EventHandler(this.Zal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingNavigator)).EndInit();
            this.залBindingNavigator.ResumeLayout(false);
            this.залBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource залBindingSource;
        private BibliotekaDataSetTableAdapters.ЗалTableAdapter залTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator залBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton залBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox категорияTextBox;
        private System.Windows.Forms.TextBox номер_залаTextBox;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
    }
}