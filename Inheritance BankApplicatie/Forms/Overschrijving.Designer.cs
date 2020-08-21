namespace Inheritance_BankApplicatie.Forms
{
    partial class Overschrijving
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
            this.lbEigenRekeningen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAndereRekening = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBedrag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCVS = new System.Windows.Forms.TextBox();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.btnVorige = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEigenRekeningen
            // 
            this.lbEigenRekeningen.FormattingEnabled = true;
            this.lbEigenRekeningen.Location = new System.Drawing.Point(10, 21);
            this.lbEigenRekeningen.Name = "lbEigenRekeningen";
            this.lbEigenRekeningen.Size = new System.Drawing.Size(204, 147);
            this.lbEigenRekeningen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eigen rekeningen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Andere rekening:";
            // 
            // tbAndereRekening
            // 
            this.tbAndereRekening.Location = new System.Drawing.Point(223, 22);
            this.tbAndereRekening.Name = "tbAndereRekening";
            this.tbAndereRekening.Size = new System.Drawing.Size(168, 20);
            this.tbAndereRekening.TabIndex = 3;
            this.tbAndereRekening.TextChanged += new System.EventHandler(this.tbAndereRekening_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bedrag:";
            // 
            // tbBedrag
            // 
            this.tbBedrag.Location = new System.Drawing.Point(223, 62);
            this.tbBedrag.Name = "tbBedrag";
            this.tbBedrag.Size = new System.Drawing.Size(168, 20);
            this.tbBedrag.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CVS:";
            // 
            // tbCVS
            // 
            this.tbCVS.Location = new System.Drawing.Point(223, 101);
            this.tbCVS.Name = "tbCVS";
            this.tbCVS.Size = new System.Drawing.Size(168, 20);
            this.tbCVS.TabIndex = 7;
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(310, 136);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(81, 32);
            this.btnBevestigen.TabIndex = 8;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(223, 136);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(81, 32);
            this.btnVorige.TabIndex = 9;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            this.btnVorige.Click += new System.EventHandler(this.btnVorige_Click);
            // 
            // Overschrijving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 173);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.tbCVS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBedrag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAndereRekening);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEigenRekeningen);
            this.Name = "Overschrijving";
            this.Text = "Overschrijving";
            this.Load += new System.EventHandler(this.Overschrijving_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEigenRekeningen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAndereRekening;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBedrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCVS;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Button btnVorige;
    }
}