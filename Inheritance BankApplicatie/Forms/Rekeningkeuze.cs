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
    public partial class Rekeningkeuze : Form
    {
        public Rekeningkeuze()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void NieuweRekening_Load(object sender, EventArgs e)
        {
            string[] rekTypes = new string[3] { "Debit", "Credit", "Spaar" };
            cbRekeningType.Items.AddRange(rekTypes);
            cbRekeningType.SelectedIndex = 0;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            if (cbRekeningType.SelectedIndex == 0)
            {
                NieuweDebit f = new NieuweDebit(cbRekeningType.SelectedItem.ToString());
                f.ShowDialog();
                Close();
            }
        }
    }
}
