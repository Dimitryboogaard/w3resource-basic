using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int[] arrayGetallen = { 1, 2, 5, 7, 8 };
        int intMax;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(int intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if(arrayGetallen[intTeller] > intMax)
                {
                    intMax = arrayGetallen[intTeller];
                }
            }

            lblHoogsteWaarde.Text = Convert.ToString(intMax);
        }
    }
}
