using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerwissel_Click(object sender, EventArgs e)
        {
            tbUitvoerGetal1.Text = tbGetal2.Text;
            tbUitvoerGetal2.Text = tbGetal1.Text;
        }
    }
}
