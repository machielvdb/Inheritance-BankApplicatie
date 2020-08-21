namespace Inheritance_BankApplicatie.Forms
{
    partial class Rekeningdetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEigenaar = new System.Windows.Forms.TextBox();
            this.tbRekeningnaam = new System.Windows.Forms.TextBox();
            this.tbRekeningnummer = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbMagNegatief = new System.Windows.Forms.TextBox();
            this.btnVorige = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eigenaar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rekeningnaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rekeningnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mag negatief:";
            // 
            // tbEigenaar
            // 
            this.tbEigenaar.Location = new System.Drawing.Point(126, 6);
            this.tbEigenaar.Name = "tbEigenaar";
            this.tbEigenaar.ReadOnly = true;
            this.tbEigenaar.Size = new System.Drawing.Size(145, 20);
            this.tbEigenaar.TabIndex = 6;
            // 
            // tbRekeningnaam
            // 
            this.tbRekeningnaam.Location = new System.Drawing.Point(126, 30);
            this.tbRekeningnaam.Name = "tbRekeningnaam";
            this.tbRekeningnaam.ReadOnly = true;
            this.tbRekeningnaam.Size = new System.Drawing.Size(145, 20);
            this.tbRekeningnaam.TabIndex = 7;
            // 
            // tbRekeningnummer
            // 
            this.tbRekeningnummer.Location = new System.Drawing.Point(126, 54);
            this.tbRekeningnummer.Name = "tbRekeningnummer";
            this.tbRekeningnummer.ReadOnly = true;
            this.tbRekeningnummer.Size = new System.Drawing.Size(145, 20);
            this.tbRekeningnummer.TabIndex = 8;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(126, 76);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(145, 20);
            this.tbSaldo.TabIndex = 9;
            // 
            // tbMagNegatief
            // 
            this.tbMagNegatief.Location = new System.Drawing.Point(126, 98);
            this.tbMagNegatief.Name = "tbMagNegatief";
            this.tbMagNegatief.ReadOnly = true;
            this.tbMagNegatief.Size = new System.Drawing.Size(145, 20);
            this.tbMagNegatief.TabIndex = 10;
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(12, 129);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(120, 23);
            this.btnVorige.TabIndex = 11;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            this.btnVorige.Click += new System.EventHandler(this.btnVorige_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(151, 129);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(120, 23);
            this.btnVerwijder.TabIndex = 12;
            this.btnVerwijder.Text = "Verwijder rekening";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Rekeningdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 162);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.tbMagNegatief);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbRekeningnummer);
            this.Controls.Add(this.tbRekeningnaam);
            this.Controls.Add(this.tbEigenaar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rekeningdetails";
            this.Text = "Rekeningdetails";
            this.Load += new System.EventHandler(this.Rekeningdetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEigenaar;
        private System.Windows.Forms.TextBox tbRekeningnaam;
        private System.Windows.Forms.TextBox tbRekeningnummer;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbMagNegatief;
        private System.Windows.Forms.Button btnVorige;
        private System.Windows.Forms.Button btnVerwijder;
    }
}