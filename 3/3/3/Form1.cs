using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuotiënt_Click(object sender, EventArgs e)
        {
            if (btnQuotiënt.Text == "Quotiënt")
            {
                btnQuotiënt.Text = "Opnieuw";
                tbQuotiënt.Text = Convert.ToString(Convert.ToDouble(tbGetal1.Text) / Convert.ToDouble(tbGetal2.Text));
            }

            else if (btnQuotiënt.Text == "Opnieuw")
            {
                btnQuotiënt.Text = "Quotiënt";
                tbGetal1.Text = "";
                tbGetal2.Text = "";
                tbQuotiënt.Text = "";
            }
        }
    }
}
