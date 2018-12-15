using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array1 = { 1, 2, 5 };
        int[] array2 = { 0, 3, 8 };
        int[] array3 = { -1, 0, 2 };
        int[] arrayNieuw = new int[3];

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            arrayNieuw[0] = array1[1];
            arrayNieuw[1] = array2[1];
            arrayNieuw[2] = array3[1];

            lblNieuweArray.Text = "(" + arrayNieuw[0].ToString() + ", " + arrayNieuw[1].ToString() +
                                   ", " + arrayNieuw[2].ToString() + ")";
        }
    }
}
