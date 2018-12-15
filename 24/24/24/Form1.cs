using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intWoordLengte;
        string strZin, strWoord, strLangsteWoord = "";

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strZin = tbInvoer.Text;
            intStringLengte = strZin.Length;

            for(intTeller = 0; intTeller <= intStringLengte - 1; intTeller++)
            {
                if(strZin.Substring(intTeller, 1) != " ")
                {
                    strWoord += strZin.Substring(intTeller, 1);
                }

                if(strZin.Substring(intTeller, 1) == " " || intTeller == intStringLengte - 1)
                {
                    if(strWoord.Length > strLangsteWoord.Length)
                    {
                        strLangsteWoord = strWoord;
                    }

                    strWoord = "";
                }
            }

            tbUitvoer.Text = strLangsteWoord;
        }
    }
}
