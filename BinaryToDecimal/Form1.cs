using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryToDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            char[] binary = binaryText.Text.ToCharArray();

            bool signed = signedCheck.Checked;

            //the converted value
            uint dec = 0;

            //used to decide power
            int j = 0;

            for (int i = binary.Length - 1; i >= 0; i--)
            {

                if (i == 0 && signed)
                {
                    // if signed convert to negative
                    if (binary[i] == '1')
                    {
                        int signedDec = (int)-dec;
                        decimalText.Text = signedDec.ToString();
                        return;
                    }
                }
                else
                {

                    switch (binary[i])
                    {
                        case '1':
                            dec += (uint)Math.Pow(2, j);
                            break;
                        case '0':
                            break;
                        default:
                            //some characters other than 0 or 1
                            decimalText.Text = "Not a binary number";
                            return;
                    }
                }

                j++;
            }

            decimalText.Text = dec.ToString();
        }
    }
}
