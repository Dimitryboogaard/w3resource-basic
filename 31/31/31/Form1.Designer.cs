namespace _31
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
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(59, 41);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(159, 20);
            this.tbAntwoord.TabIndex = 0;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(59, 12);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 1;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.AutoSize = true;
            this.lblUitvoer.Location = new System.Drawing.Point(12, 44);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(41, 13);
            this.lblUitvoer.TabIndex = 2;
            this.lblUitvoer.Text = "Uitvoer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 88);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbAntwoord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAntwoord;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblUitvoer;
    }
}

