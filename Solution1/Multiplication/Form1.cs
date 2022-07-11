using System;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int n = 1; n <= 9; n++)
                {
                    int num = n * i;

                    //textBox1.Text += $"{num,2} ";

                    //textBox1.Text += string.Format("{0,2} ", num);

                    if (num < 10)
                    {
                        textBox1.Text += " ";
                    }
                    textBox1.Text += num + " ";
                }
                //textBox1.Text += 1 * i + " ";
                //textBox1.Text += 2 * i + " ";
                //textBox1.Text += 3 * i + " ";
                //textBox1.Text += 4 * i + " ";
                //textBox1.Text += 5 * i + " ";
                //textBox1.Text += 6 * i + " ";
                //textBox1.Text += 7 * i + " ";
                //textBox1.Text += 8 * i + " ";
                //textBox1.Text += 9 * i + " ";
                textBox1.Text += "\r\n";
            }
        }
    }
}
