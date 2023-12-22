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
    public partial class SpravkaLiterature : Form
    {
        public SpravkaLiterature()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.выдача_справок_о_наличии_литературы_по_заданной_области_знанийTableAdapter.Fill(this.bibliotekaDataSet.Выдача_справок_о_наличии_литературы_по_заданной_области_знаний, область__знанийToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
