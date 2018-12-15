using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer;
        int intStringLengte, intTeller;
        bool booPalinDroom = true;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            if(intStringLengte % 2 == 0)
            {
                for(intTeller = 0; intTeller < intStringLengte / 2; intTeller++)
                {
                    if(strInvoer.Substring(intTeller, 1) != 
                      strInvoer.Substring(intStringLengte - intTeller - 1, 1))
                    {
                        booPalinDroom = false;
                    }
                }
            }

            if (intStringLengte % 2 != 0)
            {
                for (intTeller = 0; intTeller < (intStringLengte - 1) / 2; intTeller++)
                {
                    if (strInvoer.Substring(intTeller, 1) !=
                      strInvoer.Substring(intStringLengte - intTeller - 1, 1))
                    {
                        booPalinDroom = false;
                    }
                }
            }

            lblTrueOrFalse.Text = booPalinDroom.ToString();

        }
    }
}
