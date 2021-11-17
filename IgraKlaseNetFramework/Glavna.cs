using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraKlaseNetFramework
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            var naziv = txtNaziv.Text;
            var opis = txtOpis.Text;
            var vrsta = txtVrsta.Text;
            var izdavac = txtIzdavac.Text;

            var unos = txtDatum.Text;
            DateTime datum = DateTime.Now;
            if(!string.IsNullOrEmpty(unos))
            {
                var ok = DateTime.TryParse(unos, out datum);
                if(!ok)
                {
                    MessageBox.Show("Pogrešan format datuma");
                    return;
                }
            }
            unos = txtCijena.Text;
            decimal cijena = 0;
            if(!string.IsNullOrEmpty(unos))
            {
                var ok = decimal.TryParse(unos, out cijena);
                if (!ok)
                {
                    MessageBox.Show("Pogrešan format cijene");
                    return;
                }
            }
            var igra = new Igra();
            try
            {
                igra.Naziv = naziv;
                igra.Vrsta = vrsta;
                igra.Cijena = cijena;
                igra.DatumIzdavanja = datum;
                igra.Opis = opis;
                igra.Izdavac = izdavac;
                MessageBox.Show("Podaci su uspješno uneseni");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
