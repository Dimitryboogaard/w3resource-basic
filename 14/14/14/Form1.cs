using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZetOm_Click(object sender, EventArgs e)
        {
            tbTemperatuurInFahrenheit.Text = Convert.ToString(Convert.ToInt16(tbTemperatuurInCelcius.Text) *
                                             1.8 + 32);

            tbTemperatuurInKelvin.Text = Convert.ToString(Convert.ToInt16(tbTemperatuurInCelcius.Text) +
                                         273);
        }
    }
}
