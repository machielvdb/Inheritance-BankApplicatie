using Inheritance_BankApplicatie.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_BankApplicatie.Forms
{
    public partial class NieuweDebit : Form
    {
        public static string Rekeningkeuze = string.Empty;

        public NieuweDebit(string rekeningkeuze)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Rekeningkeuze = rekeningkeuze;
         }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            bool magNeg;
            int pin;

            if (tbPincode.Text.Length != 4 && int.TryParse(tbPincode.Text, out pin))
            {
                MessageBox.Show("Pincode mag enkel 4 cijfers bevatten.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Weet je zeker dat je wilt doorgaan? Aanpassingen niet meer mogelijk.", "Waarschuwing!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes && tbRekeningNaam.Text != string.Empty && tbPincode.Text.Length == 4 && int.TryParse(tbPincode.Text, out pin))
            {
                if (rbJa.Checked) magNeg = true;
                else magNeg = false;

                if (GetRekeningType() == "debit")
                {
                    Debitkaart debit = new Debitkaart(tbRekeningNaam.Text, magNeg, pin);
                    debit.GenereerRekeningnummer();
                    Hoofdmenu.rekeningLijst.Add(debit);
                }

                else if (GetRekeningType() == "credit")
                {
                    Creditkaart credit = new Creditkaart(tbRekeningNaam.Text, magNeg, pin);
                    credit.GenereerRekeningnummer();
                    credit.GenerateCVS();
                    Hoofdmenu.rekeningLijst.Add(credit);
                }

                else if (GetRekeningType() == "spaar")
                {
                    Spaarrekening spaar = new Spaarrekening();
                    spaar.GenereerRekeningnummer();
                    Hoofdmenu.rekeningLijst.Add(spaar);
                }

                else if (GetRekeningType() == null)
                {
                    MessageBox.Show("Oeps er ging iets fout.");
                }
                Close();
            }
        }

        public string GetRekeningType()
        {
            if (Rekeningkeuze.Equals("debit")) return "debit";

            else if (Rekeningkeuze.Equals("credit")) return "credit";

            else if (Rekeningkeuze.Equals("spaar")) return "spaar";

            else return null;
        }
        private void NieuweDebit_Load(object sender, EventArgs e)
        {
            if (GetRekeningType() == "credit") gbMagNegatief.Enabled = true;
            else gbMagNegatief.Enabled = false;
        }
    }
}
