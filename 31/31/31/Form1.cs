using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            array1[0] = 1;
            array1[1] = 3;
            array1[2] = -5;
            array1[3] = 4;

            array2[0] = 1;
            array2[1] = 4;
            array2[2] = - 5;
            array2[3] = - 2;
        }

        int[] array1 = new int[4];
        int[] array2 = new int[4];
        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller < array1.Length; intTeller++)
            {
                tbAntwoord.Text += array1[intTeller] * array2[intTeller] + " ";
            }
        }
    }
}
