using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intJaar, intEeuw;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intJaar = Convert.ToInt32(tbInvoer.Text);

            intEeuw = intJaar / 100 + (intJaar % 100 == 0 ? 0 : 1);

            lblEeuw.Text = intEeuw.ToString();
        }
    }
}
