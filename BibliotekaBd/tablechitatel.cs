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
    public partial class tablechitatel : Form
    {
        public tablechitatel()
        {
            InitializeComponent();
        }

        private void читательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotekaDataSet);

        }

        private void tablechitatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.bibliotekaDataSet.Читатель);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn column = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    {
                        column = dataGridViewTextBoxColumn1;
                        break;
                    }
                case 1:
                    {
                        column = dataGridViewTextBoxColumn2;
                        break;
                    }
                case 2:
                    {
                        column = dataGridViewTextBoxColumn3;
                        break;
                    }
                case 3:
                    {
                        column = dataGridViewTextBoxColumn4;
                        break;
                    }
                case 4:
                    {
                        column = dataGridViewTextBoxColumn5;
                        break;
                    }
                case 5:
                    {
                        column = dataGridViewTextBoxColumn6;
                        break;
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            читательBindingSource.Filter = "[ФИО Читателя]='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            читательBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < читательDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < читательDataGridView.RowCount; j++)
                {

                    читательDataGridView[i, j].Style.BackColor = Color.White;
                    читательDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < читательDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < читательDataGridView.RowCount - 1; j++)
                {
                    if (читательDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        читательDataGridView[i, j].Style.BackColor = Color.Blue;
                        читательDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpisokKnig spisokKnig = new SpisokKnig();
            spisokKnig.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SpisokDoljnikov spisokDoljnikov = new SpisokDoljnikov();
            spisokDoljnikov.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SpisokAge spisokAge = new SpisokAge();
            spisokAge.Show();
        }
    }
}
