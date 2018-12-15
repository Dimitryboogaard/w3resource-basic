using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2, intStringLengte;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            if(intStringLengte < 4)
            {
                tbUitvoer.Text = strInvoer;
            }

            else
            {
                for (intTeller2 = 1; intTeller2 <= 4; intTeller2++)
                {
                    for (intTeller = intStringLengte - 4; intTeller < intStringLengte; intTeller++)
                    {
                        tbUitvoer.Text += strInvoer.Substring(intTeller, 1);
                    }
                }

            }
        }
    }
}
