namespace _11
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
            this.tbLeeftijd = new System.Windows.Forms.TextBox();
            this.lblWatIsJeLeefTijd = new System.Windows.Forms.Label();
            this.lblZinnetje = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLeeftijd
            // 
            this.tbLeeftijd.Location = new System.Drawing.Point(105, 12);
            this.tbLeeftijd.Name = "tbLeeftijd";
            this.tbLeeftijd.Size = new System.Drawing.Size(38, 20);
            this.tbLeeftijd.TabIndex = 0;
            // 
            // lblWatIsJeLeefTijd
            // 
            this.lblWatIsJeLeefTijd.AutoSize = true;
            this.lblWatIsJeLeefTijd.Location = new System.Drawing.Point(12, 15);
            this.lblWatIsJeLeefTijd.Name = "lblWatIsJeLeefTijd";
            this.lblWatIsJeLeefTijd.Size = new System.Drawing.Size(87, 13);
            this.lblWatIsJeLeefTijd.TabIndex = 1;
            this.lblWatIsJeLeefTijd.Text = "Wat is je leeftijd?";
            // 
            // lblZinnetje
            // 
            this.lblZinnetje.AutoSize = true;
            this.lblZinnetje.Location = new System.Drawing.Point(12, 69);
            this.lblZinnetje.Name = "lblZinnetje";
            this.lblZinnetje.Size = new System.Drawing.Size(0, 13);
            this.lblZinnetje.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(105, 39);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 135);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblZinnetje);
            this.Controls.Add(this.lblWatIsJeLeefTijd);
            this.Controls.Add(this.tbLeeftijd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLeeftijd;
        private System.Windows.Forms.Label lblWatIsJeLeefTijd;
        private System.Windows.Forms.Label lblZinnetje;
        private System.Windows.Forms.Button btnEnter;
    }
}

