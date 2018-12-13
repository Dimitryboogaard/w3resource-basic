using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSom_Click(object sender, EventArgs e)
        {
            if(btnSom.Text == "Som")
            {
                btnSom.Text = "Opnieuw";
                tbSom.Text = Convert.ToString(Convert.ToInt16(tbGetal1.Text) + Convert.ToInt16(tbGetal2.Text));
            }

            else if(btnSom.Text == "Opnieuw")
            {
                btnSom.Text = "Som";
                tbGetal1.Text = "";
                tbGetal2.Text = "";
                tbSom.Text = "";
            }
        }
    }
}
