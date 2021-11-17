using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraKlaseNetFramework
{
    class Igra
    {
        private string naziv;        
        private string vrsta;
        private string opis;
        private DateTime datumIzdavanja;
        private string izdavac;
        private decimal cijena;
        

        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Naziv mora biti upisan");
                }
                naziv = value;
            }
        }

        public string Vrsta
        {
            get
            {
                return vrsta;
            }
            set
            {
                string[] dozvoljeno =
                    new string[] { "Akcijska", "RPG", "Avantura", "Simulacija",
                        "Sport", "Strategija" };
                if (!dozvoljeno.Contains(value))
                    throw new
                        ArgumentException("Vrsta mora biti jedna od vrijednosti: Akcijska, RPG, Avantura, Simulacija, Sport ili Strategija");
                vrsta = value;
            }
        }

        public decimal Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                if(value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Cijena mora biti između 0 i 1000");
                }
                cijena = value;
            }
        }

        public string Opis { get => opis; set => opis = value; }
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
    }
}
