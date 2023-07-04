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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form form = new ZipcodeLibrary.SearchZipcodeForm())
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
