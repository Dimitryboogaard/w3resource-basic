using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStringLengte, intTeller, intAntwoord;
        string strInvoer;

        private void button1_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                intAntwoord += Convert.ToInt32(strInvoer.Substring(intTeller, 1));
            }

            tbUitvoer.Text = intAntwoord.ToString();
        }
    }
}
