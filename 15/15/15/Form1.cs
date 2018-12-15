using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intIndex;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intIndex = Convert.ToInt32(tbIndex.Text);
            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(intTeller != intIndex)
                {
                    tbUitvoer.Text += strInvoer.Substring(intTeller, 1);
                }

                else if(intTeller == intIndex)
                {
                    tbUitvoer.Text += "";
                }
            }
        }
    }
}
