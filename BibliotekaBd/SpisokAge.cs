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
    public partial class SpisokAge : Form
    {
        public SpisokAge()
        {
            InitializeComponent();
            ageToolStripTextBox.Text = "14"; 
            FillData(); 
        }

        // Метод для заполнения данных
        private void FillData()
        {
            try
            {
                this.список_читателей__относящихся_к_взрослому_читательскому_залу_на_основе_их_возрастаTableAdapter.Fill(this.bibliotekaDataSet._Список_читателей__относящихся_к_взрослому_читательскому_залу_на_основе_их_возраста, new System.Nullable<int>(((int)(System.Convert.ChangeType(ageToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
