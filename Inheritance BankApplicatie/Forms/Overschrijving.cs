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
        }
    }
}