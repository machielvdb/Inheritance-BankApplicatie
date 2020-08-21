using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BankApplicatie
{
    public class Debitkaart : Rekening
    {
        public int Pincode { get; set; }
        public Debitkaart(string rekeningnaam, bool magnegatief, int pincode) : base(rekeningnaam)
        {
            Rekeningnaam = rekeningnaam;
            MagNegatief = false;
            Pincode = pincode;
        }

        public Debitkaart()
        {

        }

        public void EersteRekening()
        {
            Saldo = 10000;
            Rekeningnaam = "Zichtrekening";
        }
    }
}