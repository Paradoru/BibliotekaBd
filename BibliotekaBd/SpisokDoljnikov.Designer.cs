namespace BibliotekaBd
{
    partial class SpisokDoljnikov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpisokDoljnikov));
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.выдача_сведений_о_читателях___должникахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выдача_сведений_о_читателях___должникахTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.Выдача_сведений_о_читателях___должникахTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.выдача_сведений_о_читателях___должникахBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.выдача_сведений_о_читателях___должникахDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_сведений_о_читателях___должникахBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_сведений_о_читателях___должникахBindingNavigator)).BeginInit();
            this.выдача_сведений_о_читателях___должникахBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_сведений_о_читателях___должникахDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выдача_сведений_о_читателях___должникахBindingSource
            // 
            this.выдача_сведений_о_читателях___должникахBindingSource.DataMember = "Выдача сведений о читателях – должниках";
            this.выдача_сведений_о_читателях___должникахBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // выдача_сведений_о_читателях___должникахTableAdapter
            // 
            this.выдача_сведений_о_читателях___должникахTableAdapter.ClearBeforeFill = true;
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
            // выдача_сведений_о_читателях___должникахBindingNavigator
            // 
            this.выдача_сведений_о_читателях___должникахBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.BindingSource = this.выдача_сведений_о_читателях___должникахBindingSource;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem});
            this.выдача_сведений_о_читателях___должникахBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выдача_сведений_о_читателях___должникахBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.Name = "выдача_сведений_о_читателях___должникахBindingNavigator";
            this.выдача_сведений_о_читателях___должникахBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.выдача_сведений_о_читателях___должникахBindingNavigator.TabIndex = 0;
            this.выдача_сведений_о_читателях___должникахBindingNavigator.Text = "bindingNavigator1";
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
            // выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem
            // 
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem.Enabled = false;
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem.Image")));
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem.Name = "выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem";
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // выдача_сведений_о_читателях___должникахDataGridView
            // 
            this.выдача_сведений_о_читателях___должникахDataGridView.AutoGenerateColumns = false;
            this.выдача_сведений_о_читателях___должникахDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выдача_сведений_о_читателях___должникахDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.выдача_сведений_о_читателях___должникахDataGridView.DataSource = this.выдача_сведений_о_читателях___должникахBindingSource;
            this.выдача_сведений_о_читателях___должникахDataGridView.Location = new System.Drawing.Point(12, 80);
            this.выдача_сведений_о_читателях___должникахDataGridView.Name = "выдача_сведений_о_читателях___должникахDataGridView";
            this.выдача_сведений_о_читателях___должникахDataGridView.Size = new System.Drawing.Size(744, 154);
            this.выдача_сведений_о_читателях___должникахDataGridView.TabIndex = 1;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата возврата";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата возврата";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(187, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(402, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выдача сведений о читателях – должниках";
            // 
            // SpisokDoljnikov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.выдача_сведений_о_читателях___должникахDataGridView);
            this.Controls.Add(this.выдача_сведений_о_читателях___должникахBindingNavigator);
            this.Name = "SpisokDoljnikov";
            this.Text = "SpisokDoljnikov";
            this.Load += new System.EventHandler(this.SpisokDoljnikov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_сведений_о_читателях___должникахBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_сведений_о_читателях___должникахBindingNavigator)).EndInit();
            this.выдача_сведений_о_читателях___должникахBindingNavigator.ResumeLayout(false);
            this.выдача_сведений_о_читателях___должникахBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_сведений_о_читателях___должникахDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource выдача_сведений_о_читателях___должникахBindingSource;
        private BibliotekaDataSetTableAdapters.Выдача_сведений_о_читателях___должникахTableAdapter выдача_сведений_о_читателях___должникахTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выдача_сведений_о_читателях___должникахBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выдача_сведений_о_читателях___должникахBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView выдача_сведений_о_читателях___должникахDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
    }
}