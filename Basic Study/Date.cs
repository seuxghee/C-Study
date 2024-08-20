using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date
{
    public partial class Date : Form
    {
        public Date()
        {
            InitializeComponent();
            
        }

        Random rdNum = new Random(); //랜덤클래스

        /// <summary>
        /// 날짜 시간 정하기 20240819 
        /// 랜덤 클래스, 새창열기 20240820
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
            laDT2.Text = DateTime.Now.ToLongDateString();
            laDT3.Text = DateTime.Now.ToShortDateString();
            laDT4.Text = DateTime.Now.ToLongTimeString();
            laDT5.Text = DateTime.Now.ToShortTimeString();
            laDT6.Text = "현재시간은" + DateTime.Now.Hour + "시" 
                + DateTime.Now.Minute + "분 입니다.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ledRun.BackColor = Color.Lime;
            ledRun.Text = "ON";
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ledRun.BackColor = Color.White;
            ledRun.Text = "OFF";
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int num = rdNum.Next(0, 100);
            tbCh1.Text =num.ToString();

            if (num >= 50)
            {
                ledCh1.BackColor = Color.Orange;
                ledCh1.Text = "ON";
            }
            else
            {
                ledCh1.BackColor = Color.Gray;
                ledCh1.Text = "OFF";
            }
        }
        //새창열기
        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
          //  f2.Show(); 
            f2.ShowDialog(); //닫아야지 다른화면 사용가능함
        }
    }
}
