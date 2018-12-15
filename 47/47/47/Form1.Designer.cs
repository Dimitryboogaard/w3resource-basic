namespace _47
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
            this.btnSom = new System.Windows.Forms.Button();
            this.tbSom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSom
            // 
            this.btnSom.Location = new System.Drawing.Point(12, 12);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(75, 23);
            this.btnSom.TabIndex = 0;
            this.btnSom.Text = "Som";
            this.btnSom.UseVisualStyleBackColor = true;
            this.btnSom.Click += new System.EventHandler(this.btnSom_Click);
            // 
            // tbSom
            // 
            this.tbSom.Location = new System.Drawing.Point(12, 41);
            this.tbSom.Name = "tbSom";
            this.tbSom.Size = new System.Drawing.Size(100, 20);
            this.tbSom.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 86);
            this.Controls.Add(this.tbSom);
            this.Controls.Add(this.btnSom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.TextBox tbSom;
    }
}

