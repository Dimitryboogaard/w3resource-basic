using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intPriemTeller, intAantalPriemGetallen, intInvoer, intAntwoord;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            do
            {
                intInvoer++;
                intPriemTeller = 0;

                for(intTeller2 = 1; intTeller2 <= intInvoer; intTeller2++)
                {
                    if(intInvoer % intTeller2 == 0)
                    {
                        intPriemTeller++;
                    }
                }

                if(intPriemTeller == 2)
                {
                    intAntwoord += intInvoer;
                    intAantalPriemGetallen++;
                    rtTest.Text += intAantalPriemGetallen.ToString() + "   " + intInvoer.ToString() + 
                                   Environment.NewLine;
                }

            } while (intAantalPriemGetallen < 500);

            tbAntwoord.Text = intAntwoord.ToString();
        }
    }
}
