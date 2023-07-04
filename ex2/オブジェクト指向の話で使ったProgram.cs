using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Multiplication
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //インスタンス化
            Class3 c3 = new Class3();
            c3.id = "";      //親クラスに定義
            c3.password = "";//親クラスに定義
            c3.email = "";   //子クラスに定義

            //Class3は、Class1 ですよね？
            //Class3 is Class1 ですよね？
            Class1 c1 = new Class3();
            c1.id = "";      //親クラスに定義
            c1.password = "";//親クラスに定義

            //Class2 is Class1 ですよね？
            Class1 c2 = new Class2();
            c2.id = "";      //親クラスに定義
            c2.password = "";//親クラスに定義

            Class1[] a = { c1, c2, c3 };
            for (int i = 0; i < a.Length; i++)
            {
                Debug.WriteLine(a[i].id);
                Debug.WriteLine(a[i].GetData());
                /*
                if (i == 1)
                {
                    Debug.WriteLine(((Class2)a[i]).name);
                }
                else
                {
                    Debug.WriteLine(((Class3)a[i]).email);
                }
                */
            }

            List<Class1> list = new List<Class1>() { c1, c2, c3 };
            for (int i = 0; i < list.Count; i++)
            {
                Debug.WriteLine(list[i].id);
            }

            try
            {
                int num1 = 0;         //実行される
                
                int num2 = 1 / num1;  //実行エラーが発生

                int num3 = 1;         //実行されない

                int num4 = 1 / num3;  //実行されない
            }
            catch (Exception ex)
            {
                Debug.WriteLine("◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆◆エラーです。");
                Debug.WriteLine(ex);
                //TRYブロック以降の処理を実行させたくないときは、ここでプログラムを終了させる。
                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
