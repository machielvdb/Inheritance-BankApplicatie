namespace Inheritance_BankApplicatie
{
    partial class Hoofdmenu
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
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(12, 12);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(173, 23);
            this.btnOverzicht.TabIndex = 0;
            this.btnOverzicht.Text = "Rekeningoverzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(12, 41);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(173, 23);
            this.btnNieuw.TabIndex = 1;
            this.btnNieuw.Text = "Nieuwe rekening";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 73);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.btnOverzicht);
            this.Name = "Hoofdmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.Button btnNieuw;
    }
}

