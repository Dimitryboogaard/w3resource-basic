namespace _34
{
    partial class Form1
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
            this.tbInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.tbBeginWoord = new System.Windows.Forms.TextBox();
            this.lblBeginWoord = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblWaarOfNietWaar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(84, 12);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(250, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(41, 15);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(37, 13);
            this.lblInvoer.TabIndex = 1;
            this.lblInvoer.Text = "Invoer";
            // 
            // tbBeginWoord
            // 
            this.tbBeginWoord.Location = new System.Drawing.Point(84, 38);
            this.tbBeginWoord.Name = "tbBeginWoord";
            this.tbBeginWoord.Size = new System.Drawing.Size(100, 20);
            this.tbBeginWoord.TabIndex = 2;
            // 
            // lblBeginWoord
            // 
            this.lblBeginWoord.AutoSize = true;
            this.lblBeginWoord.Location = new System.Drawing.Point(12, 41);
            this.lblBeginWoord.Name = "lblBeginWoord";
            this.lblBeginWoord.Size = new System.Drawing.Size(66, 13);
            this.lblBeginWoord.TabIndex = 3;
            this.lblBeginWoord.Text = "Begin woord";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(84, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblWaarOfNietWaar
            // 
            this.lblWaarOfNietWaar.AutoSize = true;
            this.lblWaarOfNietWaar.Location = new System.Drawing.Point(81, 90);
            this.lblWaarOfNietWaar.Name = "lblWaarOfNietWaar";
            this.lblWaarOfNietWaar.Size = new System.Drawing.Size(91, 13);
            this.lblWaarOfNietWaar.TabIndex = 5;
            this.lblWaarOfNietWaar.Text = "Waar of niet waar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 121);
            this.Controls.Add(this.lblWaarOfNietWaar);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblBeginWoord);
            this.Controls.Add(this.tbBeginWoord);
            this.Controls.Add(this.lblInvoer);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox tbBeginWoord;
        private System.Windows.Forms.Label lblBeginWoord;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblWaarOfNietWaar;
    }
}

