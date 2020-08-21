using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BankApplicatie
{
    public class Creditkaart : Rekening
    {
        public int Pincode { get; set; }
        public int MaxNegatief { get; set; }
        public int CVS { get; set; }

        public Creditkaart(string rekeningnaam, bool magnegatief, int pincode) :base(rekeningnaam)
        {
            Rekeningnaam = rekeningnaam;
            MaxNegatief = 1000;
        }
        public void GenerateCVS()
        {
            Random rng = new Random();
            string cvs = string.Empty;

            for (int i = 0; i > 3; i--)
            {
                cvs.Append(Convert.ToChar(rng.Next(0, 9)));
                i--;
            }
        }
        public Creditkaart()
        {

        }
    }
}
