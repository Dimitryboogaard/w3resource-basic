using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int A = 10, B = 11, C = 12, D = 13, E = 14, F = 15;
        int intTeller, intStringLengte, intHex;
        double dblTijdelijk;
        string strInvoer, strTijdelijk;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            for (intTeller = 0; intTeller < intStringLengte; intTeller++)
            {


                strTijdelijk = strInvoer.Substring(intStringLengte - intTeller - 1, 1);

                switch (strTijdelijk)
                {
                    case "A":
                        intHex = 10;
                        break;

                    case "B":
                        intHex = 11;
                        break;

                    case "C":
                        intHex = 12;
                        break;

                    case "D":
                        intHex = 13;
                        break;

                    case "E":
                        intHex = 14;
                        break;

                    case "F":
                        intHex = 15;
                        break;

                    default:
                        intHex = Convert.ToInt32(strTijdelijk);
                        break;

                }

                dblTijdelijk += Math.Pow(16, intTeller) * intHex;

            }

            tbUitvoer.Text = dblTijdelijk.ToString();
        }
    }
}
