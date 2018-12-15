using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2, intMinTwintig1, intMinTwintig2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt16(tbGetal1.Text);
            intGetal2 = Convert.ToInt16(tbGetal2.Text);

            intMinTwintig1 = Math.Abs(intGetal1 - 20);
            intMinTwintig2 = Math.Abs(intGetal2 - 20);

            tbUitvoer.Text = Convert.ToString(intMinTwintig1 == intMinTwintig2 ? 0 :
                                              intMinTwintig1 < intMinTwintig2 ? intGetal1 :
                                              intGetal2);
        }
    }
}
