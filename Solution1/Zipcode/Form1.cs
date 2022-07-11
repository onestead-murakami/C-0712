using System;
using System.Windows.Forms;
using ZipcodeLibrary;

namespace Zipcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form form = new SearchZipcodeForm())
            {
                DialogResult result = form.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    string[] selected = form.Tag as string[];
                    if (selected != null && selected.Length == 4)
                    {
                        string address = $"{selected[1]}{selected[2]}{selected[3]}";
                        MessageBox.Show(address);
                    }
                    else
                    {
                        MessageBox.Show("プログラム結合エラー");
                    }
                }
            }
        }
    }
}
