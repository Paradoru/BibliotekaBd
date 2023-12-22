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
    public partial class SpisokDoljnikov : Form
    {
        public SpisokDoljnikov()
        {
            InitializeComponent();
        }

        private void SpisokDoljnikov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bibliotekaDataSet._Выдача_сведений_о_читателях___должниках". При необходимости она может быть перемещена или удалена.
            this.выдача_сведений_о_читателях___должникахTableAdapter.Fill(this.bibliotekaDataSet._Выдача_сведений_о_читателях___должниках);

        }
    }
}
