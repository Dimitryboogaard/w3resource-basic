using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = { 1, 3, 4, 7, 9 };
        int intTeller, intTeller2, intAntwoord;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                if(arrayGetallen[intTeller + 1] - arrayGetallen[intTeller] != 1)
                {
                    for(intTeller2 = 1; intTeller2 < arrayGetallen[intTeller + 1] - arrayGetallen[intTeller]; intTeller2++)
                    {
                        lblAntwoord.Text += Convert.ToString(arrayGetallen[intTeller] + intTeller2) + " ";
                        intAntwoord++;
                    }
                }
            }

            lblAntwoord.Text += ": " + intAntwoord.ToString();
        }
    }
}
