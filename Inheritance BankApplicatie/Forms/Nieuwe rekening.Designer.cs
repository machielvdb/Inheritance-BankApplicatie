namespace Inheritance_BankApplicatie.Forms
{
    partial class NieuweDebit
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
            this.tbRekeningNaam = new System.Windows.Forms.TextBox();
            this.tbRekeningNummer = new System.Windows.Forms.TextBox();
            this.gbMagNegatief = new System.Windows.Forms.GroupBox();
            this.rbJa = new System.Windows.Forms.RadioButton();
            this.rbNee = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPincode = new System.Windows.Forms.TextBox();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.gbMagNegatief.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rekeningnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rekeningnummer:";
            // 
            // tbRekeningNaam
            // 
            this.tbRekeningNaam.Location = new System.Drawing.Point(119, 6);
            this.tbRekeningNaam.Name = "tbRekeningNaam";
            this.tbRekeningNaam.Size = new System.Drawing.Size(247, 20);
            this.tbRekeningNaam.TabIndex = 2;
            // 
            // tbRekeningNummer
            // 
            this.tbRekeningNummer.Location = new System.Drawing.Point(119, 29);
            this.tbRekeningNummer.Name = "tbRekeningNummer";
            this.tbRekeningNummer.ReadOnly = true;
            this.tbRekeningNummer.Size = new System.Drawing.Size(247, 20);
            this.tbRekeningNummer.TabIndex = 3;
            // 
            // gbMagNegatief
            // 
            this.gbMagNegatief.Controls.Add(this.rbNee);
            this.gbMagNegatief.Controls.Add(this.rbJa);
            this.gbMagNegatief.Location = new System.Drawing.Point(12, 70);
            this.gbMagNegatief.Name = "gbMagNegatief";
            this.gbMagNegatief.Size = new System.Drawing.Size(94, 40);
            this.gbMagNegatief.TabIndex = 5;
            this.gbMagNegatief.TabStop = false;
            this.gbMagNegatief.Text = "Mag negatief";
            // 
            // rbJa
            // 
            this.rbJa.AutoSize = true;
            this.rbJa.Location = new System.Drawing.Point(7, 17);
            this.rbJa.Name = "rbJa";
            this.rbJa.Size = new System.Drawing.Size(36, 17);
            this.rbJa.TabIndex = 0;
            this.rbJa.TabStop = true;
            this.rbJa.Text = "Ja";
            this.rbJa.UseVisualStyleBackColor = true;
            // 
            // rbNee
            // 
            this.rbNee.AutoSize = true;
            this.rbNee.Location = new System.Drawing.Point(49, 17);
            this.rbNee.Name = "rbNee";
            this.rbNee.Size = new System.Drawing.Size(45, 17);
            this.rbNee.TabIndex = 1;
            this.rbNee.TabStop = true;
            this.rbNee.Text = "Nee";
            this.rbNee.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pincode:";
            // 
            // tbPincode
            // 
            this.tbPincode.Location = new System.Drawing.Point(119, 51);
            this.tbPincode.Name = "tbPincode";
            this.tbPincode.Size = new System.Drawing.Size(247, 20);
            this.tbPincode.TabIndex = 6;
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Location = new System.Drawing.Point(119, 77);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(247, 33);
            this.btnAanmaken.TabIndex = 7;
            this.btnAanmaken.Text = "Rekening aanmaken";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // NieuweDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 120);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.tbPincode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbMagNegatief);
            this.Controls.Add(this.tbRekeningNummer);
            this.Controls.Add(this.tbRekeningNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NieuweDebit";
            this.Text = "NieuweDebit";
            this.Load += new System.EventHandler(this.NieuweDebit_Load);
            this.gbMagNegatief.ResumeLayout(false);
            this.gbMagNegatief.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRekeningNaam;
        private System.Windows.Forms.TextBox tbRekeningNummer;
        private System.Windows.Forms.GroupBox gbMagNegatief;
        private System.Windows.Forms.RadioButton rbNee;
        private System.Windows.Forms.RadioButton rbJa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPincode;
        private System.Windows.Forms.Button btnAanmaken;
    }
}