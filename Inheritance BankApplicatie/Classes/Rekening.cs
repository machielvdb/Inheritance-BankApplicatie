using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BankApplicatie
{
    public class Rekening
    {
        public string Eigenaar { get; set; }
        public string Rekeningnaam { get; set; }
        public string Rekeningnummer = "BE## #### #### ####";
        public double Saldo { get; set; }
        public bool MagNegatief { get; set; }

        public Rekening(string rekeningnaam)
        {
            Eigenaar = "Machiel Vandenbussche";
            Rekeningnaam = rekeningnaam;
            Saldo = 0;
            MagNegatief = false;
            GenereerRekeningnummer();
        }

        public Rekening()
        {
            Eigenaar = "Machiel Vandenbussche";
        }

        public void GenereerRekeningnummer()
        {
            Random rng = new Random();

            Rekeningnummer = "BE" + rng.Next(99).ToString().PadLeft(2, '0');

            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(9999);
                Rekeningnummer += " " + randomnr.ToString().PadLeft(4, '0');
            }
        }

        public override string ToString()
        {
            return Rekeningnaam + " " + Rekeningnummer;
        }
    }
}
