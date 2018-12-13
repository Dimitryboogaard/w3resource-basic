namespace _1
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
            this.lblTypJeNaamIn = new System.Windows.Forms.Label();
            this.lblBegroeting = new System.Windows.Forms.Label();
            this.btnBegroeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInvoer
            // 
            this.tbInvoer.Location = new System.Drawing.Point(97, 22);
            this.tbInvoer.Name = "tbInvoer";
            this.tbInvoer.Size = new System.Drawing.Size(164, 20);
            this.tbInvoer.TabIndex = 0;
            // 
            // lblTypJeNaamIn
            // 
            this.lblTypJeNaamIn.AutoSize = true;
            this.lblTypJeNaamIn.Location = new System.Drawing.Point(12, 25);
            this.lblTypJeNaamIn.Name = "lblTypJeNaamIn";
            this.lblTypJeNaamIn.Size = new System.Drawing.Size(79, 13);
            this.lblTypJeNaamIn.TabIndex = 1;
            this.lblTypJeNaamIn.Text = "Typ je naam in:";
            // 
            // lblBegroeting
            // 
            this.lblBegroeting.AutoSize = true;
            this.lblBegroeting.Location = new System.Drawing.Point(12, 81);
            this.lblBegroeting.Name = "lblBegroeting";
            this.lblBegroeting.Size = new System.Drawing.Size(0, 13);
            this.lblBegroeting.TabIndex = 2;
            // 
            // btnBegroeting
            // 
            this.btnBegroeting.Location = new System.Drawing.Point(97, 48);
            this.btnBegroeting.Name = "btnBegroeting";
            this.btnBegroeting.Size = new System.Drawing.Size(75, 23);
            this.btnBegroeting.TabIndex = 3;
            this.btnBegroeting.Text = "Begroeting";
            this.btnBegroeting.UseVisualStyleBackColor = true;
            this.btnBegroeting.Click += new System.EventHandler(this.btnBegroeting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 250);
            this.Controls.Add(this.btnBegroeting);
            this.Controls.Add(this.lblBegroeting);
            this.Controls.Add(this.lblTypJeNaamIn);
            this.Controls.Add(this.tbInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvoer;
        private System.Windows.Forms.Label lblTypJeNaamIn;
        private System.Windows.Forms.Label lblBegroeting;
        private System.Windows.Forms.Button btnBegroeting;
    }
}

