﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller <= 10; intTeller++)
            {
                rtUitvoer.Text += tbInvoer.Text + " x " + intTeller.ToString() + " = " +
                                  Convert.ToString(Convert.ToInt16(tbInvoer.Text) * intTeller) + 
                                  Environment.NewLine;
            }
        }
    }
}
