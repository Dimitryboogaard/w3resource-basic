using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arrayGetallen[1] = 2;
            arrayGetallen[2] = 4;
            arrayGetallen[3] = 5;
            arrayGetallen[4] = 9;
            arrayGetallen[5] = 1;
            arrayGetallen[6] = 4;
            arrayGetallen[7] = 3;
            arrayGetallen[8] = 5;
            arrayGetallen[9] = 7;
            arrayGetallen[10] = 4;
        }

        int[] arrayGetallen = new int[25];
        int intTeller, intGetal, intGetalTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal = Convert.ToInt16(tbInvoer.Text);

            for(intTeller = 1; intTeller <= 10; intTeller++)
            {
                if(intGetal == arrayGetallen[intTeller])
                {
                    intGetalTeller++;
                }
            }

            lblAntwoord.Text = "Getal " + intGetal.ToString() + " komt " + intGetalTeller.ToString() +
                               " keer voor.";
        }
    }
}
