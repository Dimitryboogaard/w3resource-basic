using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = { 1, 2, 8 };
        int intTeller, intTijdelijk;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intTijdelijk = arrayGetallen[0];
            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                arrayGetallen[intTeller] = arrayGetallen[intTeller + 1];
            }

            arrayGetallen[arrayGetallen.Length - 1] = intTijdelijk;

            tbUitvoer.Text = "[";
            
            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                tbUitvoer.Text += arrayGetallen[intTeller] + ", ";
            }

            tbUitvoer.Text += arrayGetallen[arrayGetallen.Length - 1] + "]";
        }
    }
}
