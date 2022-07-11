using System;
using System.Windows.Forms;

namespace MultipleLine
{
    public partial class Form1 : Form
    {
        int rowNo;

        public Form1()
        {
            InitializeComponent();
            rowNo = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ボタンが押されるたびに1行ずつ追記する
            rowNo++;

            //10回目で終了できるように
            if (rowNo == 10)
            {
                MessageBox.Show("プログラムを終了します。");
                Close();
            }
            else if (rowNo == 9)
            {
                button1.Text = "閉じる";
            }

            for (int i = 1; i <= 9; i++)
            {
                int num = rowNo * i;
                textBox1.Text += $"{num,2} ";
            }
            textBox1.Text += "\r\n";

        }
    }
}
