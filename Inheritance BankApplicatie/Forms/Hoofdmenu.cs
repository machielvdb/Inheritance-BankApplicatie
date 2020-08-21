using Inheritance_BankApplicatie.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_BankApplicatie
{
    public partial class Hoofdmenu : Form
    {
        public static List<Rekening> rekeningLijst = new List<Rekening>();
        public Hoofdmenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            Rekeningoverzicht f = new Rekeningoverzicht();
            f.Show();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            Rekeningkeuze f = new Rekeningkeuze();
            f.ShowDialog();
        }

        private void Hoofdmenu_Load(object sender, EventArgs e)
        {
            Debitkaart debit = new Debitkaart();
            debit.EersteRekening();
            debit.GenereerRekeningnummer();
            rekeningLijst.Add(debit);
        }
    }
}
