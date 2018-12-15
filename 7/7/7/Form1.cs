using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoorden_Click(object sender, EventArgs e)
        {
            tbSom.Text = Convert.ToString(Convert.ToInt16(tbGetal1.Text) + Convert.ToInt16(tbGetal2.Text));
            tbVerschil.Text = Convert.ToString(Convert.ToInt16(tbGetal1.Text) - Convert.ToInt16(tbGetal2.Text));
            tbProduct.Text = Convert.ToString(Convert.ToInt16(tbGetal1.Text) * Convert.ToInt16(tbGetal2.Text));
            tbQuotiënt.Text = Convert.ToString(Convert.ToInt16(tbGetal1.Text) / Convert.ToInt16(tbGetal2.Text));
            tbMod.Text = Convert.ToString(Convert.ToInt16(tbGetal1.Text) % Convert.ToInt16(tbGetal2.Text));
        }
    }
}
