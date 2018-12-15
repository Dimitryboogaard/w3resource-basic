using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strInvoer = tbInvoer.Text;
            int intStringLengte = strInvoer.Length;
            if (intStringLengte >= 5)
            {
                lblTrueOrFalse.Text = Convert.ToString(strInvoer.Substring(0, 5) == "wwwww");
            }

            else if(intStringLengte < 5)
            {
                lblTrueOrFalse.Text = "False";
            }
        }
    }
}
