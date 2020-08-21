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
    public partial class Rekeningoverzicht : Form
    {
        public Rekeningoverzicht()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Rekeningoverzicht_Load(object sender, EventArgs e)
        {
            foreach (var item in Hoofdmenu.rekeningLijst)
            {
                lbRekeningen.Items.Add(item);
            }

            lbRekeningen.SelectedIndex = 0;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Rekening rekening = lbRekeningen.SelectedItem as Rekening;
            Rekeningdetails f = new Rekeningdetails(rekening);
            f.Show();
        }

        private void btnOverschrijven_Click(object sender, EventArgs e)
        {
            Rekening geselecteerdeRekening = lbRekeningen.SelectedItem as Rekening;
            Overschrijving f = new Overschrijving(geselecteerdeRekening);
            f.Show();
        }
    }
}