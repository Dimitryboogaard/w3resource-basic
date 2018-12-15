using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer;
        int intStringLengte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            if(intStringLengte < 4)
            {
                tbUitvoer.Text = strInvoer.Substring(0, intStringLengte).ToUpper();
            }

            else if(intStringLengte >= 4)
            {
                tbUitvoer.Text += strInvoer.Substring(0, 4).ToLower();
                tbUitvoer.Text += strInvoer.Substring(4, intStringLengte - 4);
            }
        }
    }
}
