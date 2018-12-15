using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte;
        string strInvoer;
             

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            tbUitvoer.Text += strInvoer.Substring(0, 1);

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                tbUitvoer.Text += strInvoer.Substring(intTeller, 1);
            }

            tbUitvoer.Text += strInvoer.Substring(0, 1);

        }
    }
}
