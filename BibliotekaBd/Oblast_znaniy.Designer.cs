namespace BibliotekaBd
{
    partial class Oblast_znaniy
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
            System.Windows.Forms.Label код_областиLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oblast_znaniy));
            this.label2 = new System.Windows.Forms.Label();
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.область_знанийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.область_знанийTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.Область_знанийTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.область_знанийBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.область_знанийBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_областиTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            код_областиLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.область_знанийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.область_знанийBindingNavigator)).BeginInit();
            this.область_знанийBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_областиLabel
            // 
            код_областиLabel.AutoSize = true;
            код_областиLabel.Location = new System.Drawing.Point(11, 118);
            код_областиLabel.Name = "код_областиLabel";
            код_областиLabel.Size = new System.Drawing.Size(73, 13);
            код_областиLabel.TabIndex = 3;
            код_областиLabel.Text = "Код области:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(240, 118);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(103, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Таблица \"Область знаний\"";
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // область_знанийBindingSource
            // 
            this.область_знанийBindingSource.DataMember = "Область знаний";
            this.область_знанийBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // область_знанийTableAdapter
            // 
            this.область_знанийTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_читателяTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.Область_знанийTableAdapter = this.область_знанийTableAdapter;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Экземпляр_книгиTableAdapter = null;
            // 
            // область_знанийBindingNavigator
            // 
            this.область_знанийBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.область_знанийBindingNavigator.BindingSource = this.область_знанийBindingSource;
            this.область_знанийBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.область_знанийBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.область_знанийBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.область_знанийBindingNavigatorSaveItem});
            this.область_знанийBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.область_знанийBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.область_знанийBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.область_знанийBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.область_знанийBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.область_знанийBindingNavigator.Name = "область_знанийBindingNavigator";
            this.область_знанийBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.область_знанийBindingNavigator.Size = new System.Drawing.Size(470, 25);
            this.область_знанийBindingNavigator.TabIndex = 3;
            this.область_знанийBindingNavigator.Text = "bindingNavigator1";
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
            // область_знанийBindingNavigatorSaveItem
            // 
            this.область_знанийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.область_знанийBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("область_знанийBindingNavigatorSaveItem.Image")));
            this.область_знанийBindingNavigatorSaveItem.Name = "область_знанийBindingNavigatorSaveItem";
            this.область_знанийBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.область_знанийBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.область_знанийBindingNavigatorSaveItem.Click += new System.EventHandler(this.область_знанийBindingNavigatorSaveItem_Click);
            // 
            // код_областиTextBox
            // 
            this.код_областиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.область_знанийBindingSource, "Код области", true));
            this.код_областиTextBox.Location = new System.Drawing.Point(90, 115);
            this.код_областиTextBox.Name = "код_областиTextBox";
            this.код_областиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_областиTextBox.TabIndex = 4;
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.область_знанийBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(332, 115);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(180, 221);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 23);
            this.btnsave.TabIndex = 33;
            this.btnsave.Text = "Сохранить";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(298, 192);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(109, 23);
            this.btnremove.TabIndex = 32;
            this.btnremove.Text = "Удалить";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(180, 192);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 23);
            this.btnnext.TabIndex = 31;
            this.btnnext.Text = "Следующая";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click_1);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(55, 192);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(103, 23);
            this.btnlast.TabIndex = 30;
            this.btnlast.Text = "Последняя";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(298, 163);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(109, 23);
            this.btnadd.TabIndex = 29;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(180, 163);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 23);
            this.btnback.TabIndex = 28;
            this.btnback.Text = "Предыдущая";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(55, 163);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(103, 23);
            this.btnfirst.TabIndex = 27;
            this.btnfirst.Text = "Первая";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Справка по литературе заданной области";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Oblast_znaniy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_областиLabel);
            this.Controls.Add(this.код_областиTextBox);
            this.Controls.Add(this.область_знанийBindingNavigator);
            this.Controls.Add(this.label2);
            this.Name = "Oblast_znaniy";
            this.Text = "Oblast_znaniy";
            this.Load += new System.EventHandler(this.Oblast_znaniy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.область_знанийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.область_знанийBindingNavigator)).EndInit();
            this.область_знанийBindingNavigator.ResumeLayout(false);
            this.область_знанийBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource область_знанийBindingSource;
        private BibliotekaDataSetTableAdapters.Область_знанийTableAdapter область_знанийTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator область_знанийBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton область_знанийBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_областиTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
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