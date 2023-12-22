namespace BibliotekaBd
{
    partial class SpisokChitatelei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpisokChitatelei));
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_читателей__взявших_в_прокат_определенное_количество_книгTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.Список_читателей__взявших_в_прокат_определенное_количество_книгTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.количествоToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.количествоToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator)).BeginInit();
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource
            // 
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource.DataMember = "Список читателей, взявших в прокат определенное количество книг";
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // список_читателей__взявших_в_прокат_определенное_количество_книгTableAdapter
            // 
            this.список_читателей__взявших_в_прокат_определенное_количество_книгTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Журнал_читателяTableAdapter = null;
            this.tableAdapterManager.ЗалTableAdapter = null;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.Область_знанийTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Экземпляр_книгиTableAdapter = null;
            // 
            // список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator
            // 
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.BindingSource = this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem});
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.Name = "список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator";
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.Size = new System.Drawing.Size(664, 25);
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.TabIndex = 0;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.Text = "bindingNavigator1";
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
            // список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem
            // 
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem.Enabled = false;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSa" +
        "veItem.Image")));
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem.Name = "список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSa" +
    "veItem";
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоToolStripLabel,
            this.количествоToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Padding = new System.Windows.Forms.Padding(0, 60, 1, 0);
            this.fillToolStrip.Size = new System.Drawing.Size(664, 83);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // количествоToolStripLabel
            // 
            this.количествоToolStripLabel.Name = "количествоToolStripLabel";
            this.количествоToolStripLabel.Size = new System.Drawing.Size(75, 20);
            this.количествоToolStripLabel.Text = "Количество:";
            // 
            // количествоToolStripTextBox
            // 
            this.количествоToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.количествоToolStripTextBox.Name = "количествоToolStripTextBox";
            this.количествоToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 20);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView
            // 
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.AutoGenerateColumns = false;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.DataSource = this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource;
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.Location = new System.Drawing.Point(17, 111);
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.Name = "список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView";
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.Size = new System.Drawing.Size(635, 273);
            this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID Читателя";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Читателя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер зала";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер зала";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО Читателя";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО Читателя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Адрес проживания";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес проживания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер телефона";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список читателей, взявших в прокат определённое количество книг";
            // 
            // SpisokChitatelei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(664, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator);
            this.Name = "SpisokChitatelei";
            this.Text = "SpisokChitatelei";
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator)).EndInit();
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.ResumeLayout(false);
            this.список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource список_читателей__взявших_в_прокат_определенное_количество_книгBindingSource;
        private BibliotekaDataSetTableAdapters.Список_читателей__взявших_в_прокат_определенное_количество_книгTableAdapter список_читателей__взявших_в_прокат_определенное_количество_книгTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton список_читателей__взявших_в_прокат_определенное_количество_книгBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel количествоToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox количествоToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView список_читателей__взявших_в_прокат_определенное_количество_книгDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}