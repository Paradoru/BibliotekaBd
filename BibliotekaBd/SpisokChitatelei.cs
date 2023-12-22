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
    public partial class SpisokChitatelei : Form
    {
        public SpisokChitatelei()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.список_читателей__взявших_в_прокат_определенное_количество_книгTableAdapter.Fill(this.bibliotekaDataSet._Список_читателей__взявших_в_прокат_определенное_количество_книг, new System.Nullable<int>(((int)(System.Convert.ChangeType(количествоToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
