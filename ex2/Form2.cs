using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// 現在表示している行数をフィールド変数として定義
        /// </summary>
        private int currentRow = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //テキストボックスの表示を空にする
            textBox1.Clear();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //10回目のクリックで画面を閉じる
            if (currentRow == 9)
            {
                MessageBox.Show("プログラムを終了します。");
                Close();
            }
            else
            {
                //currentRowをプラス１する
                currentRow += 1; //currentRow++でも同じ

                //クリックされるたびに1行ずつ表示（1列分表示すればよい）
                for (int col = 1; col <= 9; col++)
                {
                    int value = currentRow * col;
                    textBox1.Text += $"{value,2} ";
                }
                textBox1.Text += "\r\n";

                //9回目のクリックで「実行ボタン」を「閉じるボタン」に変更
                if (currentRow == 9)
                {
                    button1.Text = "閉じる";
                }
            }


        }
    }
}
