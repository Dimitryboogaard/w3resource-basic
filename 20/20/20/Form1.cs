using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tbGetal1.Text) > Convert.ToInt16(tbGetal2.Text))
            {
                tbAntwoord.Text = Convert.ToString(Math.Abs(Convert.ToInt16(tbGetal1.Text) -
                                  Convert.ToInt16(tbGetal2.Text)) * 2);
            }

            else
            {
                tbAntwoord.Text = Convert.ToString(Math.Abs(Convert.ToInt16(tbGetal1.Text) -
                  Convert.ToInt16(tbGetal2.Text)));

            }
        }
    }
}
