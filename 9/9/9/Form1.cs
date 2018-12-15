using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGemiddelde_Click(object sender, EventArgs e)
        {
            tbGemiddelde.Text = Convert.ToString((Convert.ToInt16(tbGetal1.Text) + Convert.ToInt16(tbGetal2.Text) +
                                Convert.ToInt16(tbGetal3.Text) + Convert.ToInt16(tbGetal4.Text)) / 4);
        }
    }
}
