﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2, intGetal3;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt32(tbGetal1.Text);
            intGetal2 = Convert.ToInt32(tbGetal2.Text);
            intGetal3 = Convert.ToInt32(tbGetal3.Text);

            tbHoogste.Text = Convert.ToString(Math.Max(intGetal1, Math.Max(intGetal2, intGetal3)));
            tbLaagste.Text = Convert.ToString(Math.Min(intGetal1, Math.Min(intGetal2, intGetal3)));

        }
    }
}
