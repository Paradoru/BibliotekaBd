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
    public partial class Zal : Form
    {
        public Zal()
        {
            InitializeComponent();
        }

        private void залBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.залBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void Zal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Зал". При необходимости она может быть перемещена или удалена.
            this.залTableAdapter.Fill(this.bibliotekaDataSet.Зал);

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            залBindingSource.MoveFirst();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            залBindingSource.MovePrevious();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            залBindingSource.AddNew();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            залBindingSource.MoveLast();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            залBindingSource.MoveNext();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            залBindingSource.RemoveCurrent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.залBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);
        }
    }
}
