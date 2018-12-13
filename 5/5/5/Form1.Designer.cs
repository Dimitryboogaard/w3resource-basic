namespace _5
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
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.btnVerwissel = new System.Windows.Forms.Button();
            this.tbUitvoerGetal1 = new System.Windows.Forms.TextBox();
            this.tbUitvoerGetal2 = new System.Windows.Forms.TextBox();
            this.lblUitvoerGetal1 = new System.Windows.Forms.Label();
            this.lblUitvoerGetal2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(94, 12);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 0;
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(47, 15);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 1;
            this.lblGetal1.Text = "Getal 1";
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(94, 38);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 2;
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(47, 41);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 3;
            this.lblGetal2.Text = "Getal 2";
            // 
            // btnVerwissel
            // 
            this.btnVerwissel.Location = new System.Drawing.Point(94, 68);
            this.btnVerwissel.Name = "btnVerwissel";
            this.btnVerwissel.Size = new System.Drawing.Size(75, 23);
            this.btnVerwissel.TabIndex = 4;
            this.btnVerwissel.Text = "Verwissel";
            this.btnVerwissel.UseVisualStyleBackColor = true;
            this.btnVerwissel.Click += new System.EventHandler(this.btnVerwissel_Click);
            // 
            // tbUitvoerGetal1
            // 
            this.tbUitvoerGetal1.Location = new System.Drawing.Point(94, 97);
            this.tbUitvoerGetal1.Name = "tbUitvoerGetal1";
            this.tbUitvoerGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbUitvoerGetal1.TabIndex = 5;
            // 
            // tbUitvoerGetal2
            // 
            this.tbUitvoerGetal2.Location = new System.Drawing.Point(94, 123);
            this.tbUitvoerGetal2.Name = "tbUitvoerGetal2";
            this.tbUitvoerGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbUitvoerGetal2.TabIndex = 6;
            // 
            // lblUitvoerGetal1
            // 
            this.lblUitvoerGetal1.AutoSize = true;
            this.lblUitvoerGetal1.Location = new System.Drawing.Point(12, 100);
            this.lblUitvoerGetal1.Name = "lblUitvoerGetal1";
            this.lblUitvoerGetal1.Size = new System.Drawing.Size(76, 13);
            this.lblUitvoerGetal1.TabIndex = 7;
            this.lblUitvoerGetal1.Text = "Uitvoer getal 1";
            // 
            // lblUitvoerGetal2
            // 
            this.lblUitvoerGetal2.AutoSize = true;
            this.lblUitvoerGetal2.Location = new System.Drawing.Point(12, 126);
            this.lblUitvoerGetal2.Name = "lblUitvoerGetal2";
            this.lblUitvoerGetal2.Size = new System.Drawing.Size(76, 13);
            this.lblUitvoerGetal2.TabIndex = 8;
            this.lblUitvoerGetal2.Text = "Uitvoer getal 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 207);
            this.Controls.Add(this.lblUitvoerGetal2);
            this.Controls.Add(this.lblUitvoerGetal1);
            this.Controls.Add(this.tbUitvoerGetal2);
            this.Controls.Add(this.tbUitvoerGetal1);
            this.Controls.Add(this.btnVerwissel);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.tbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Button btnVerwissel;
        private System.Windows.Forms.TextBox tbUitvoerGetal1;
        private System.Windows.Forms.TextBox tbUitvoerGetal2;
        private System.Windows.Forms.Label lblUitvoerGetal1;
        private System.Windows.Forms.Label lblUitvoerGetal2;
    }
}

