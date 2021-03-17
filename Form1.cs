using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сумма_и_произведение_ряда
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N;
            double m;
            double l;
            double k = 1;
            double factorial = 1;
            N = int.Parse(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                double sum = 0;

                for (double i = 1; i <= N; i++)
                {
                    factorial *= i;
                    sum += ( i + 1) / (2 * factorial);
                }
                textBox2.Text = "Работу выполнил студент Городов М.А. Сумма ряда = " + sum;
            }
            else if (radioButton2.Checked == true)
            {
                for (double i = 1; i <= N; i++)
                {
                    m = i + 2;
                    factorial = 1;
                    for (l = 1; l <= m; l++)
                    {
                        factorial *= l;
                    }
                    
                    k *= (factorial / (i+1));
                    textBox2.Text = "Работу выполнил студент Городов М.А. Сумма ряда = " + k;
                }
                
            }
            



            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
