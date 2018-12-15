using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
        int[] arrayGetallen2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblTrueOrFalse.Text = Convert.ToString(arrayGetallen[0].Equals(arrayGetallen2[0]) ||
                                  arrayGetallen[arrayGetallen.Length - 1].Equals(
                                  arrayGetallen2[arrayGetallen2.Length - 1]));
        }
    }
}
