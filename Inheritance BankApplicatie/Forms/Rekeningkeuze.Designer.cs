namespace Inheritance_BankApplicatie.Forms
{
    partial class Rekeningkeuze
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
            this.cbRekeningType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRekeningType
            // 
            this.cbRekeningType.FormattingEnabled = true;
            this.cbRekeningType.Location = new System.Drawing.Point(94, 6);
            this.cbRekeningType.Name = "cbRekeningType";
            this.cbRekeningType.Size = new System.Drawing.Size(121, 21);
            this.cbRekeningType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rekeningtype:";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(12, 32);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(203, 23);
            this.btnBevestig.TabIndex = 2;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // Rekeningkeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 67);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRekeningType);
            this.Name = "Rekeningkeuze";
            this.Text = "NieuweRekening";
            this.Load += new System.EventHandler(this.NieuweRekening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRekeningType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBevestig;
    }
}