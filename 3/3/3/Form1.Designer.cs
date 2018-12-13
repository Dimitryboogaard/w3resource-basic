namespace _3
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
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.btnQuotiënt = new System.Windows.Forms.Button();
            this.tbQuotiënt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(12, 15);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 0;
            this.lblGetal1.Text = "Getal 1";
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(65, 12);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 1;
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(65, 38);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 2;
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(12, 41);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 3;
            this.lblGetal2.Text = "Getal 2";
            // 
            // btnQuotiënt
            // 
            this.btnQuotiënt.Location = new System.Drawing.Point(65, 64);
            this.btnQuotiënt.Name = "btnQuotiënt";
            this.btnQuotiënt.Size = new System.Drawing.Size(75, 23);
            this.btnQuotiënt.TabIndex = 4;
            this.btnQuotiënt.Text = "Quotiënt";
            this.btnQuotiënt.UseVisualStyleBackColor = true;
            this.btnQuotiënt.Click += new System.EventHandler(this.btnQuotiënt_Click);
            // 
            // tbQuotiënt
            // 
            this.tbQuotiënt.Location = new System.Drawing.Point(65, 93);
            this.tbQuotiënt.Name = "tbQuotiënt";
            this.tbQuotiënt.Size = new System.Drawing.Size(100, 20);
            this.tbQuotiënt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quotiënt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbQuotiënt);
            this.Controls.Add(this.btnQuotiënt);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Controls.Add(this.lblGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Button btnQuotiënt;
        private System.Windows.Forms.TextBox tbQuotiënt;
        private System.Windows.Forms.Label label1;
    }
}

