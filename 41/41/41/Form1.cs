using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intWTeller;


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strInvoer = tbInvoer.Text;
            int intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) == "w")
                {
                    intWTeller++;
                }
            }

            lblTrueOrNot.Text = Convert.ToString(1 <= intWTeller && intWTeller <= 3);
        }
    }
}
