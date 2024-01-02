using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace asal_mi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            label1.Text = "ASAL MI ?";
            if (e.KeyCode == Keys.Enter)
            {
                int sayi=0;
                try
                {
                    sayi = Convert.ToInt32(textBox1.Text);
                    bool asal_mi = true;
                    for (int i = sayi - 1; i >= 2; i--)
                    {

                        if (sayi % i == 0)
                        {
                            asal_mi = false;
                            break;
                        }
                    }
                    if (asal_mi.Equals(true))
                    {
                        label1.Text = "ASAL";

                    }
                    else
                    {
                        label1.Text = "ASAL DEĞİL";
                    }

                    textBox1.Text = " ";
                }

                catch
                {
                    MessageBox.Show("Hatali parametre girildi");
                    textBox1.Text = " ";

                }
                      
            }

        }
    }
}
