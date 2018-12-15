namespace _26
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
            this.lblSom1e500PriemGetallen = new System.Windows.Forms.Label();
            this.rtTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(148, 41);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(128, 20);
            this.tbAntwoord.TabIndex = 0;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(148, 12);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 1;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblSom1e500PriemGetallen
            // 
            this.lblSom1e500PriemGetallen.AutoSize = true;
            this.lblSom1e500PriemGetallen.Location = new System.Drawing.Point(12, 44);
            this.lblSom1e500PriemGetallen.Name = "lblSom1e500PriemGetallen";
            this.lblSom1e500PriemGetallen.Size = new System.Drawing.Size(130, 13);
            this.lblSom1e500PriemGetallen.TabIndex = 2;
            this.lblSom1e500PriemGetallen.Text = "Som 1e 500 Priemgetallen";
            // 
            // rtTest
            // 
            this.rtTest.Location = new System.Drawing.Point(282, 12);
            this.rtTest.Name = "rtTest";
            this.rtTest.Size = new System.Drawing.Size(100, 197);
            this.rtTest.TabIndex = 3;
            this.rtTest.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 231);
            this.Controls.Add(this.rtTest);
            this.Controls.Add(this.lblSom1e500PriemGetallen);
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
        private System.Windows.Forms.Label lblSom1e500PriemGetallen;
        private System.Windows.Forms.RichTextBox rtTest;
    }
}

