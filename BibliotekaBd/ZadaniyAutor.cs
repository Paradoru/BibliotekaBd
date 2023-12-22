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
    public partial class ZadaniyAutor : Form
    {
        public ZadaniyAutor()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.выдача_справок_о_наличии_книг_заданного_автора__издательства__вышедших_после_заданного_года_TableAdapter.Fill(this.bibliotekaDataSet._Выдача_справок_о_наличии_книг_заданного_автора__издательства__вышедших_после_заданного_года_, authorToolStripTextBox.Text, yearToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
