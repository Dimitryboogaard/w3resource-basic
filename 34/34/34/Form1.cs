using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strBeginWoord;
        int intTeller, intStringLengte;
        bool booWaarOfNietWaar = true;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            strBeginWoord = tbBeginWoord.Text;

            intStringLengte = strBeginWoord.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) != strBeginWoord.Substring(intTeller, 1))
                {
                    booWaarOfNietWaar = false;
                }
            }

            if(!booWaarOfNietWaar)
            {
                lblWaarOfNietWaar.Text = "Niet waar";

            }

            else if(booWaarOfNietWaar)
            {
                lblWaarOfNietWaar.Text = "Waar";
            }
        }
    }
}
