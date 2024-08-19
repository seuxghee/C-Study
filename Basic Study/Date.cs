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
        /// <summary>
        /// 날짜 시간 정하기 20240819
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ledRun.BackColor = Color.White;
            ledRun.Text = "OFF";
        }
    }
}
