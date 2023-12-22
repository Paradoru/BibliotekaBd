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
    public partial class Oblast_znaniy : Form
    {
        public Oblast_znaniy()
        {
            InitializeComponent();
        }

        private void область_знанийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.область_знанийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void Oblast_znaniy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Область_знаний". При необходимости она может быть перемещена или удалена.
            this.область_знанийTableAdapter.Fill(this.bibliotekaDataSet.Область_знаний);

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            область_знанийBindingSource.MoveFirst();
        }



        private void btnback_Click_1(object sender, EventArgs e)
        {
            область_знанийBindingSource.MovePrevious();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            область_знанийBindingSource.AddNew();
        }

        private void btnlast_Click_1(object sender, EventArgs e)
        {
            область_знанийBindingSource.MoveLast();
        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            область_знанийBindingSource.MoveNext();
        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {
            область_знанийBindingSource.RemoveCurrent();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.область_знанийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpravkaLiterature spravkaLiterature = new SpravkaLiterature();
            spravkaLiterature.Show();
        }
    }
}
