namespace BibliotekaBd
{
    partial class SpravkaLiterature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpravkaLiterature));
            this.bibliotekaDataSet = new BibliotekaBd.BibliotekaDataSet();
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийTableAdapter = new BibliotekaBd.BibliotekaDataSetTableAdapters.Выдача_справок_о_наличии_литературы_по_заданной_области_знанийTableAdapter();
            this.tableAdapterManager = new BibliotekaBd.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.область__знанийToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.область__знанийToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator)).BeginInit();
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource
            // 
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource.DataMember = "Выдача справок о наличии литературы по заданной области знаний";
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // выдача_справок_о_наличии_литературы_по_заданной_области_знанийTableAdapter
            // 
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийTableAdapter.ClearBeforeFill = true;
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
            // выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator
            // 
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.BindingSource = this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem});
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.Name = "выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator";
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.TabIndex = 0;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem
            // 
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem.Enabled = false;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSav" +
        "eItem.Image")));
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem.Name = "выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSav" +
    "eItem";
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.область__знанийToolStripLabel,
            this.область__знанийToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.fillToolStrip.Size = new System.Drawing.Size(800, 93);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // область__знанийToolStripLabel
            // 
            this.область__знанийToolStripLabel.Name = "область__знанийToolStripLabel";
            this.область__знанийToolStripLabel.Size = new System.Drawing.Size(105, 15);
            this.область__знанийToolStripLabel.Text = "Область__знаний:";
            // 
            // область__знанийToolStripTextBox
            // 
            this.область__знанийToolStripTextBox.Name = "область__знанийToolStripTextBox";
            this.область__знанийToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView
            // 
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.AutoGenerateColumns = false;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.DataSource = this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource;
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.Location = new System.Drawing.Point(0, 121);
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.Name = "выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView";
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.Size = new System.Drawing.Size(800, 268);
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Шифр_ISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Шифр_ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилии авторов";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилии авторов";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Место издания";
            this.dataGridViewTextBoxColumn4.HeaderText = "Место издания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Издательство";
            this.dataGridViewTextBoxColumn5.HeaderText = "Издательство";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Год издания";
            this.dataGridViewTextBoxColumn6.HeaderText = "Год издания";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Количество страниц";
            this.dataGridViewTextBoxColumn7.HeaderText = "Количество страниц";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Кол-во экземпляров";
            this.dataGridViewTextBoxColumn8.HeaderText = "Кол-во экземпляров";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Номер зала";
            this.dataGridViewTextBoxColumn9.HeaderText = "Номер зала";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Код области";
            this.dataGridViewTextBoxColumn10.HeaderText = "Код области";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn11.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(88, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выдача справок о наличии литературы по заданной области знаний ";
            // 
            // SpravkaLiterature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator);
            this.Name = "SpravkaLiterature";
            this.Text = "SpravkaLiterature";
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator)).EndInit();
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.ResumeLayout(false);
            this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingSource;
        private BibliotekaDataSetTableAdapters.Выдача_справок_о_наличии_литературы_по_заданной_области_знанийTableAdapter выдача_справок_о_наличии_литературы_по_заданной_области_знанийTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выдача_справок_о_наличии_литературы_по_заданной_области_знанийBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel область__знанийToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox область__знанийToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView выдача_справок_о_наличии_литературы_по_заданной_области_знанийDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label2;
    }
}