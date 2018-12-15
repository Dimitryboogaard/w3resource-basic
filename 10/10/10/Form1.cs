using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            tbAntwoord.Text = "(X + Y) · Z = " + Convert.ToString((Convert.ToInt16(tbX.Text) + Convert.ToInt16(tbY.Text)) *
                              Convert.ToInt16(tbZ.Text));

            tbAntwoord.Text += "     X · Y + Y · Z = " + Convert.ToString(Convert.ToInt16(tbX.Text) *
                               Convert.ToInt16(tbY.Text) + Convert.ToInt16(tbY.Text) *
                               Convert.ToInt16(tbZ.Text));
        }
    }
}
