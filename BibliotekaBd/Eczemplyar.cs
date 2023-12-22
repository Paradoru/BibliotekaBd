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
    public partial class Eczemplyar : Form
    {
        public Eczemplyar()
        {
            InitializeComponent();
        }

        private void экземпляр_книгиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.экземпляр_книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void Eczemplyar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Экземпляр_книги". При необходимости она может быть перемещена или удалена.
            this.экземпляр_книгиTableAdapter.Fill(this.bibliotekaDataSet.Экземпляр_книги);

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            экземпляр_книгиBindingSource.MovePrevious();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            экземпляр_книгиBindingSource.RemoveCurrent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            экземпляр_книгиBindingSource.MoveNext();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            экземпляр_книгиBindingSource.MoveLast();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            экземпляр_книгиBindingSource.AddNew();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.экземпляр_книгиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            экземпляр_книгиBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteOffBookForm writeOffBookForm = new WriteOffBookForm();
            writeOffBookForm.ShowDialog();
        }
    }
}
