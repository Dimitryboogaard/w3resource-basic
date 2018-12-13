using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoorden_Click(object sender, EventArgs e)
        {
            tbAntwoord1.Text = Convert.ToString(-1 + 4 * 6);
            tbAntwoord2.Text = Convert.ToString((35 + 5) % 7);
            tbAntwoord3.Text = Convert.ToString(14 + -4 * 6 / 11);
            tbAntwoord4.Text = Convert.ToString(2 + 15 / 6 * 1 - 7 % 2);
        }
    }
}
