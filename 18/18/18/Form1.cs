using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool booNegatief = false, booPositief = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(tbGetal1.Text) < 0)
            {
                booNegatief = true;
            }

            else if(Convert.ToInt16(tbGetal1.Text) > 0)
            {
                booPositief = true;
            }

            if (Convert.ToInt16(tbGetal2.Text) < 0)
            {
                booNegatief = true;
            }

            else if (Convert.ToInt16(tbGetal2.Text) > 0)
            {
                booPositief = true;
            }

            if(booPositief && booNegatief)
            {
                lblAntwoord.Text = "Een getal is positief en een getal is negatief";
            }
        }
    }
}
