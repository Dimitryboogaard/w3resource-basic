using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intTeller2;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;

            for (intTeller2 = 1; intTeller2 <= 2; intTeller2++)
            {
                for (intTeller = 1; intTeller <= 4; intTeller++)
                {
                    rtUitvoer.Text += strInvoer + " ";
                }

                rtUitvoer.Text += Environment.NewLine;

                for (intTeller = 1; intTeller <= 4; intTeller++)
                {
                    rtUitvoer.Text += strInvoer;

                }

                rtUitvoer.Text += Environment.NewLine;
            }
        }
    }
}
