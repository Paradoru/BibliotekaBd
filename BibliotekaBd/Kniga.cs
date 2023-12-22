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
    public partial class Kniga : Form
    {
        public Kniga()
        {
            InitializeComponent();
        }

        private void книгаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void Kniga_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.bibliotekaDataSet.Книга);

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            книгаBindingSource.MoveFirst();
        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {
            книгаBindingSource.RemoveCurrent();
        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            книгаBindingSource.MoveNext();
        }

        private void btnlast_Click_1(object sender, EventArgs e)
        {
            книгаBindingSource.MoveLast();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            книгаBindingSource.AddNew();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            книгаBindingSource.MovePrevious();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.книгаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZadaniyAutor zadaniyAutor = new ZadaniyAutor();
            zadaniyAutor.Show();
        }
    }
}
