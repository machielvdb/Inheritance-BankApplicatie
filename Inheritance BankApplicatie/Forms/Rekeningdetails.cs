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
    public partial class Rekeningdetails : Form
    {
        public static Rekening geselecteerdeRekening = new Rekening();

        public Rekeningdetails(Rekening rekening)
        {
            InitializeComponent();
            geselecteerdeRekening = rekening;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Rekeningdetails_Load(object sender, EventArgs e)
        {
            tbEigenaar.Text = geselecteerdeRekening.Eigenaar;
            tbRekeningnaam.Text = geselecteerdeRekening.Rekeningnaam;
            tbRekeningnummer.Text = geselecteerdeRekening.Rekeningnummer;
            tbSaldo.Text = geselecteerdeRekening.Saldo.ToString();

            if (geselecteerdeRekening.MagNegatief == true)
            {
                tbMagNegatief.Text = "Ja";
            }

            else
            {
                tbMagNegatief.Text = "Nee";
            }

            tbEigenaar.Enabled = false;
            tbRekeningnaam.Enabled = false;
            tbRekeningnummer.Enabled = false;
            tbSaldo.Enabled = false;
            tbMagNegatief.Enabled = false;
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (tbSaldo.Text != "0")
            {
                MessageBox.Show("Saldo moet op 0 staan vooraleer je rekening kan verwijderen.");
            }
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}