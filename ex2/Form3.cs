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
    public partial class Form3 : Form
    {
        private List<LinkLabel> links = new List<LinkLabel>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //1行目
            links.Add(linkLabel1);
            links.Add(linkLabel2);
            links.Add(linkLabel3);
            links.Add(linkLabel4);
            links.Add(linkLabel5);
            links.Add(linkLabel6);
            links.Add(linkLabel7);
            //2行目
            links.Add(linkLabel14);
            links.Add(linkLabel13);
            links.Add(linkLabel12);
            links.Add(linkLabel11);
            links.Add(linkLabel10);
            links.Add(linkLabel9);
            links.Add(linkLabel8);
            //3行目
            links.Add(linkLabel21);
            links.Add(linkLabel20);
            links.Add(linkLabel19);
            links.Add(linkLabel18);
            links.Add(linkLabel17);
            links.Add(linkLabel16);
            links.Add(linkLabel15);
            //4行目
            links.Add(linkLabel28);
            links.Add(linkLabel27);
            links.Add(linkLabel26);
            links.Add(linkLabel25);
            links.Add(linkLabel24);
            links.Add(linkLabel23);
            links.Add(linkLabel22);
            //5行目
            links.Add(linkLabel35);
            links.Add(linkLabel34);
            links.Add(linkLabel33);
            links.Add(linkLabel32);
            links.Add(linkLabel31);
            links.Add(linkLabel30);
            links.Add(linkLabel29);
            //6行目
            links.Add(linkLabel42);
            links.Add(linkLabel41);
            links.Add(linkLabel40);
            links.Add(linkLabel39);
            links.Add(linkLabel38);
            links.Add(linkLabel37);
            links.Add(linkLabel36);
            //初期化
            for (int i = 0; i < links.Count; i++)
            {
                links[i].Text = i.ToString();
            }
        }
    }
}
