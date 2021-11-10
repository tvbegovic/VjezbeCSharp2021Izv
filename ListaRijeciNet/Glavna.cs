using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaRijeciNet
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnDodajNaKraj_Click(object sender, EventArgs e)
        {
            var rijec = txtJednaRijec.Text;
            rijeci.Add(rijec);
            AzurirajListBox();
        }

        void AzurirajListBox()
        {
            lstPopis.DataSource = null;
            lstPopis.DataSource = rijeci;
        }
    }
}
