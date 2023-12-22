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
    public partial class Biblioteka : Form
    {
        public Biblioteka()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_journalchitatel_Click(object sender, EventArgs e)
        {
            JournalChitatel sf = new JournalChitatel();
            sf.Show();
        }

        private void button_zal_Click(object sender, EventArgs e)
        {
            Zal sf = new Zal();
            sf.Show();
        }

        private void button_kniga_Click(object sender, EventArgs e)
        {
            Kniga sf = new Kniga();
            sf.Show();
        }

        private void button_oblast_znaniy_Click(object sender, EventArgs e)
        {
            Oblast_znaniy sf = new Oblast_znaniy();
            sf.Show();
        }

        private void button_chitatel_Click(object sender, EventArgs e)
        {
            Chitatel sf = new Chitatel();
            sf.Show();
        }

        private void button_eczemlyar_Click(object sender, EventArgs e)
        {
            Eczemplyar sf = new Eczemplyar();
            sf.Show();
        }
    }
}
