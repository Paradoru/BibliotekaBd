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
    public partial class Chitatel : Form
    {
        public Chitatel()
        {
            InitializeComponent();
        }

        private void журнал_читателяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.журнал_читателяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void Chitatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.bibliotekaDataSet.Читатель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Журнал_читателя". При необходимости она может быть перемещена или удалена.
            this.журнал_читателяTableAdapter.Fill(this.bibliotekaDataSet.Журнал_читателя);

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            читательBindingSource.MovePrevious();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            читательBindingSource.RemoveCurrent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            читательBindingSource.MoveLast();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            читательBindingSource.AddNew();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            читательBindingSource.MoveNext();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            читательBindingSource.MoveFirst();
        }

        private void tablechitatel_Click(object sender, EventArgs e)
        {
            tablechitatel tablechitatel = new tablechitatel();
            tablechitatel.Show();
        }
    }
}
