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
            //↓↓↓設定ファイルで定義することで、プログラムから切り離せる
            //行最大値
            const int MAX_ROW = 20;
            //列最大値
            const int MAX_COL = 9;
            //桁数
            const int DIGITS = 3;
            //↑↑↑設定ファイルで定義することで、プログラムから切り離せる

            //行反復
            for (int row = 1; row <= MAX_ROW; row++)
            {
                //列反復
                for (int col = 1; col <= MAX_COL; col++)
                {
                    //九九の計算結果を記憶
                    int value = row * col;
                    //計算結果を表示
                    textBox1.Text += $"{value, DIGITS} "; //古いバージョンの書き方は「　string.Format("{0, 2} ", value)　」

                    /*
                    //計算結果が1桁以下の時は前にスペースを入れて桁合わせする
                    if (value <= 9)
                    {
                        //前にスペースを表示
                        textBox1.Text += " ";
                    }
                    //計算結果を表示
                    textBox1.Text += value;
                    //後にスペースを表示
                    textBox1.Text += " ";
                    */

                }
                //一行ごとに改行を表示
                textBox1.Text += "\r\n";
            }
        }
    }
}
