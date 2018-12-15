namespace _39
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
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.tbGetal3 = new System.Windows.Forms.TextBox();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblGetal3 = new System.Windows.Forms.Label();
            this.tbHoogste = new System.Windows.Forms.TextBox();
            this.tbLaagste = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblHoogste = new System.Windows.Forms.Label();
            this.lblLaagste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(65, 12);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 0;
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(65, 38);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 1;
            // 
            // tbGetal3
            // 
            this.tbGetal3.Location = new System.Drawing.Point(65, 64);
            this.tbGetal3.Name = "tbGetal3";
            this.tbGetal3.Size = new System.Drawing.Size(100, 20);
            this.tbGetal3.TabIndex = 2;
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(18, 15);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 3;
            this.lblGetal1.Text = "Getal 1";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(18, 41);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 4;
            this.lblGetal2.Text = "Getal 2";
            // 
            // lblGetal3
            // 
            this.lblGetal3.AutoSize = true;
            this.lblGetal3.Location = new System.Drawing.Point(18, 67);
            this.lblGetal3.Name = "lblGetal3";
            this.lblGetal3.Size = new System.Drawing.Size(41, 13);
            this.lblGetal3.TabIndex = 5;
            this.lblGetal3.Text = "Getal 3";
            // 
            // tbHoogste
            // 
            this.tbHoogste.Location = new System.Drawing.Point(65, 119);
            this.tbHoogste.Name = "tbHoogste";
            this.tbHoogste.Size = new System.Drawing.Size(100, 20);
            this.tbHoogste.TabIndex = 6;
            // 
            // tbLaagste
            // 
            this.tbLaagste.Location = new System.Drawing.Point(65, 145);
            this.tbLaagste.Name = "tbLaagste";
            this.tbLaagste.Size = new System.Drawing.Size(100, 20);
            this.tbLaagste.TabIndex = 7;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(65, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 8;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblHoogste
            // 
            this.lblHoogste.AutoSize = true;
            this.lblHoogste.Location = new System.Drawing.Point(12, 122);
            this.lblHoogste.Name = "lblHoogste";
            this.lblHoogste.Size = new System.Drawing.Size(47, 13);
            this.lblHoogste.TabIndex = 9;
            this.lblHoogste.Text = "Hoogste";
            // 
            // lblLaagste
            // 
            this.lblLaagste.AutoSize = true;
            this.lblLaagste.Location = new System.Drawing.Point(14, 148);
            this.lblLaagste.Name = "lblLaagste";
            this.lblLaagste.Size = new System.Drawing.Size(45, 13);
            this.lblLaagste.TabIndex = 10;
            this.lblLaagste.Text = "Laagste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 200);
            this.Controls.Add(this.lblLaagste);
            this.Controls.Add(this.lblHoogste);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbLaagste);
            this.Controls.Add(this.tbHoogste);
            this.Controls.Add(this.lblGetal3);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.tbGetal3);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.TextBox tbGetal3;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblGetal3;
        private System.Windows.Forms.TextBox tbHoogste;
        private System.Windows.Forms.TextBox tbLaagste;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblHoogste;
        private System.Windows.Forms.Label lblLaagste;
    }
}

