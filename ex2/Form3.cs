using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Year;
            comboBox1.Text = DateTime.Now.Month.ToString();
        }
        private void MakeCalendar()
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                LinkLabel[] labels = {
                    linkLabel1, linkLabel2, linkLabel4, linkLabel3, linkLabel6, linkLabel5 , linkLabel7,
                    linkLabel14, linkLabel13, linkLabel12, linkLabel11, linkLabel10, linkLabel9, linkLabel8,
                    linkLabel21, linkLabel20, linkLabel19, linkLabel18, linkLabel17, linkLabel16, linkLabel15,
                    linkLabel28, linkLabel27, linkLabel26, linkLabel25, linkLabel24, linkLabel23, linkLabel22,
                    linkLabel35, linkLabel34, linkLabel33, linkLabel32, linkLabel31, linkLabel30, linkLabel29,
                    linkLabel42, linkLabel41, linkLabel40, linkLabel39, linkLabel38, linkLabel37, linkLabel36,
                };

                int year = (int)numericUpDown1.Value;
                int month = int.Parse(comboBox1.Text);
                
                // 月の１日が何曜日かを管理（日曜日：0 ～ 土曜日：6）
                int week = CalendarLibrary.Functions.MakeWeek(year, month);
                // 月の末日の日付を管理（28、29、30、31）
                int last = CalendarLibrary.Functions.MakeLast(year, month); 
                //当月分よりも前の表示処理
                int day = (month == 1)
                   ? CalendarLibrary.Functions.MakeLast(year - 1, 12)
                   : CalendarLibrary.Functions.MakeLast(year, month - 1);
                for (int i = 0; i < week; i++, day--)
                { 
                    labels[i].Text = day.ToString();
                    labels[i].Links[0].Enabled = false;
                }
                //当月の表示処理
                day = 1;
                for (int i = week; day <= last; i++, day++)
                { 
                    labels[i].Text = day.ToString();
                    labels[i].Links[0].Enabled = true;
                    labels[i].Links[0].Description = numericUpDown1.Value + "-" + comboBox1.Text.PadLeft(2, '0') + "-" + labels[i].Text;
                }
                //当月分よりも後の表示処理
                day = 1;
                for (int i = (week + last); i < labels.Length; i++, day++)
                { 
                    labels[i].Text = day.ToString();
                    labels[i].Links[0].Enabled = false;
                }
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MakeCalendar();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeCalendar();
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(e.Link.Description);//ここで表示
        }
    }
}
