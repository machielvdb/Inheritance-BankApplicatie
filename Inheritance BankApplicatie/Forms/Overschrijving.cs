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
    public partial class Overschrijving : Form
    {
        public static Rekening geselecteerdeRekening = new Rekening();
        public Overschrijving(Rekening rekening)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            geselecteerdeRekening = rekening;
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Overschrijving_Load(object sender, EventArgs e)
        {
            foreach (var item in Hoofdmenu.rekeningLijst)
            {
                if (item != geselecteerdeRekening)
                {
                    lbEigenRekeningen.Items.Add(item);
                }
            }

            if (geselecteerdeRekening.GetType() == typeof(Creditkaart)) tbCVS.Enabled = true;
            else tbCVS.Enabled = false;
        }

        private void tbAndereRekening_TextChanged(object sender, EventArgs e)
        {
            if (tbAndereRekening.Text == string.Empty) lbEigenRekeningen.Enabled = true;
            else lbEigenRekeningen.Enabled = false;
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            Rekening verzender = geselecteerdeRekening;
            Rekening ontvanger = null;

            if (tbAndereRekening.Text == string.Empty)
            {
                ontvanger = lbEigenRekeningen.SelectedItem as Rekening;
            }

            if (double.TryParse(tbBedrag.Text, out double bedrag))
            {
                verzender.Saldo -= bedrag;

                if (ontvanger != null)
                {
                    ontvanger.Saldo += bedrag;
                }
            }

            DialogResult dialogResult = MessageBox.Show($"Weet je zeker dat je {bedrag} euro wil overschrijven?", "Waarschuwing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var item in Hoofdmenu.rekeningLijst)
                {
                    if (item.Rekeningnummer == verzender.Rekeningnummer)
                        item.Saldo = verzender.Saldo;

                    else if (item.Rekeningnummer == ontvanger.Rekeningnummer)
                        item.Saldo = ontvanger.Saldo;
                }
            }
        }
    }
}