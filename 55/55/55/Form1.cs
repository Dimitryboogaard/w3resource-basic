using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = { 3, 5, 2, 7, 6 };
        int intProduct, intMax, intTeller = 0, intGetal1, intGetal2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                intProduct = arrayGetallen[intTeller] * arrayGetallen[intTeller + 1];
                
                if(intProduct > intMax)
                {
                    intMax = intProduct;
                    intGetal1 = arrayGetallen[intTeller];
                    intGetal2 = arrayGetallen[intTeller + 1];
                }
            }

            lblPaar.Text = "(" + intGetal1.ToString() + ", " + intGetal2.ToString() + ")";
     
        }
    }
}
