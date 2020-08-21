namespace Inheritance_BankApplicatie.Forms
{
    partial class Rekeningoverzicht
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
            this.lbRekeningen = new System.Windows.Forms.ListBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnOverschrijven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRekeningen
            // 
            this.lbRekeningen.FormattingEnabled = true;
            this.lbRekeningen.Location = new System.Drawing.Point(12, 12);
            this.lbRekeningen.Name = "lbRekeningen";
            this.lbRekeningen.Size = new System.Drawing.Size(266, 147);
            this.lbRekeningen.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(284, 12);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(132, 23);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnOverschrijven
            // 
            this.btnOverschrijven.Location = new System.Drawing.Point(284, 41);
            this.btnOverschrijven.Name = "btnOverschrijven";
            this.btnOverschrijven.Size = new System.Drawing.Size(132, 23);
            this.btnOverschrijven.TabIndex = 2;
            this.btnOverschrijven.Text = "Overschrijven";
            this.btnOverschrijven.UseVisualStyleBackColor = true;
            this.btnOverschrijven.Click += new System.EventHandler(this.btnOverschrijven_Click);
            // 
            // Rekeningoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 157);
            this.Controls.Add(this.btnOverschrijven);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lbRekeningen);
            this.Name = "Rekeningoverzicht";
            this.Text = "Rekeningoverzicht";
            this.Load += new System.EventHandler(this.Rekeningoverzicht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRekeningen;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnOverschrijven;
    }
}