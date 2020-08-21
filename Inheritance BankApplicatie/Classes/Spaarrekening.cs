using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BankApplicatie.Classes
{
    public class Spaarrekening : Rekening
    {
        public Debitkaart LinkedDebit { get; set; }

        public Spaarrekening(string eigenaar, string rekeningnaam, string rekeningnummer) :base(rekeningnaam)
        {
            Eigenaar = eigenaar;
            Rekeningnaam = rekeningnaam;
            Saldo = 0;
            MagNegatief = false;
            Rekeningnummer = rekeningnummer;
        }

        public Spaarrekening()
        {

        }
    }
}
