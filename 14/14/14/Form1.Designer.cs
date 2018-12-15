namespace _14
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
            this.tbTemperatuurInCelcius = new System.Windows.Forms.TextBox();
            this.lblTemperatuurInCelcius = new System.Windows.Forms.Label();
            this.tbTemperatuurInFahrenheit = new System.Windows.Forms.TextBox();
            this.lblTemperatuurInFahrenheit = new System.Windows.Forms.Label();
            this.btnZetOm = new System.Windows.Forms.Button();
            this.tbTemperatuurInKelvin = new System.Windows.Forms.TextBox();
            this.lblTemperatuurInKelvin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTemperatuurInCelcius
            // 
            this.tbTemperatuurInCelcius.Location = new System.Drawing.Point(149, 12);
            this.tbTemperatuurInCelcius.Name = "tbTemperatuurInCelcius";
            this.tbTemperatuurInCelcius.Size = new System.Drawing.Size(100, 20);
            this.tbTemperatuurInCelcius.TabIndex = 0;
            // 
            // lblTemperatuurInCelcius
            // 
            this.lblTemperatuurInCelcius.AutoSize = true;
            this.lblTemperatuurInCelcius.Location = new System.Drawing.Point(28, 15);
            this.lblTemperatuurInCelcius.Name = "lblTemperatuurInCelcius";
            this.lblTemperatuurInCelcius.Size = new System.Drawing.Size(115, 13);
            this.lblTemperatuurInCelcius.TabIndex = 1;
            this.lblTemperatuurInCelcius.Text = "Temperatuur in Celcius";
            // 
            // tbTemperatuurInFahrenheit
            // 
            this.tbTemperatuurInFahrenheit.Location = new System.Drawing.Point(149, 38);
            this.tbTemperatuurInFahrenheit.Name = "tbTemperatuurInFahrenheit";
            this.tbTemperatuurInFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbTemperatuurInFahrenheit.TabIndex = 2;
            // 
            // lblTemperatuurInFahrenheit
            // 
            this.lblTemperatuurInFahrenheit.AutoSize = true;
            this.lblTemperatuurInFahrenheit.Location = new System.Drawing.Point(12, 41);
            this.lblTemperatuurInFahrenheit.Name = "lblTemperatuurInFahrenheit";
            this.lblTemperatuurInFahrenheit.Size = new System.Drawing.Size(131, 13);
            this.lblTemperatuurInFahrenheit.TabIndex = 3;
            this.lblTemperatuurInFahrenheit.Text = "Temperatuur in Fahrenheit";
            // 
            // btnZetOm
            // 
            this.btnZetOm.Location = new System.Drawing.Point(149, 90);
            this.btnZetOm.Name = "btnZetOm";
            this.btnZetOm.Size = new System.Drawing.Size(75, 23);
            this.btnZetOm.TabIndex = 4;
            this.btnZetOm.Text = "Zet om";
            this.btnZetOm.UseVisualStyleBackColor = true;
            this.btnZetOm.Click += new System.EventHandler(this.btnZetOm_Click);
            // 
            // tbTemperatuurInKelvin
            // 
            this.tbTemperatuurInKelvin.Location = new System.Drawing.Point(149, 64);
            this.tbTemperatuurInKelvin.Name = "tbTemperatuurInKelvin";
            this.tbTemperatuurInKelvin.Size = new System.Drawing.Size(100, 20);
            this.tbTemperatuurInKelvin.TabIndex = 5;
            // 
            // lblTemperatuurInKelvin
            // 
            this.lblTemperatuurInKelvin.AutoSize = true;
            this.lblTemperatuurInKelvin.Location = new System.Drawing.Point(33, 67);
            this.lblTemperatuurInKelvin.Name = "lblTemperatuurInKelvin";
            this.lblTemperatuurInKelvin.Size = new System.Drawing.Size(110, 13);
            this.lblTemperatuurInKelvin.TabIndex = 6;
            this.lblTemperatuurInKelvin.Text = "Temperatuur in Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 151);
            this.Controls.Add(this.lblTemperatuurInKelvin);
            this.Controls.Add(this.tbTemperatuurInKelvin);
            this.Controls.Add(this.btnZetOm);
            this.Controls.Add(this.lblTemperatuurInFahrenheit);
            this.Controls.Add(this.tbTemperatuurInFahrenheit);
            this.Controls.Add(this.lblTemperatuurInCelcius);
            this.Controls.Add(this.tbTemperatuurInCelcius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTemperatuurInCelcius;
        private System.Windows.Forms.Label lblTemperatuurInCelcius;
        private System.Windows.Forms.TextBox tbTemperatuurInFahrenheit;
        private System.Windows.Forms.Label lblTemperatuurInFahrenheit;
        private System.Windows.Forms.Button btnZetOm;
        private System.Windows.Forms.TextBox tbTemperatuurInKelvin;
        private System.Windows.Forms.Label lblTemperatuurInKelvin;
    }
}

