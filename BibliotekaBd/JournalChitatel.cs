using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaBd
{
    public partial class JournalChitatel : Form
    {
        public JournalChitatel()
        {
            InitializeComponent();
        }

        private void журнал_читателяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.журнал_читателяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void журнал_читателяBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.журнал_читателяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void JournalChitatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Журнал_читателя". При необходимости она может быть перемещена или удалена.
            this.журнал_читателяTableAdapter.Fill(this.bibliotekaDataSet.Журнал_читателя);

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            журнал_читателяBindingSource.MovePrevious();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            журнал_читателяBindingSource.RemoveCurrent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            журнал_читателяBindingSource.MoveNext();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            журнал_читателяBindingSource.MoveLast();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            журнал_читателяBindingSource.AddNew();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.журнал_читателяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            журнал_читателяBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpisokChitatelei spisokChitatelei = new SpisokChitatelei();
            spisokChitatelei.Show();
        }
    }
}
