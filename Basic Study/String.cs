using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String
{
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }
        /// <summary>
        /// String 클래스의 Length,Substring 20240814
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInput_Click(object sender, EventArgs e)
        {
           //substring 
            string str = tbInput.Text;
            string subStr = str.Substring(7, 1);
            string subMonth = str.Substring(2, 2);
            string subDay = str.Substring(4, 2);

            lblBirthday.Text = "생일:" + subMonth + "월" + subDay + "일";


            if ((subStr == "1") || (subStr == "3"))
            {
                lblResult.Text = "남성";
            }
            else if ((subStr == "2") || (subStr == "4"))
            {
                lblResult.Text = "여성";

            }
            else
            {
                lblResult.Text = "당신은 외계인?";
             
            }
            
            
            //length
            /*lblResult.Text = str.Length.ToString();

            int pos = str.IndexOf("-");

            if (pos >= 0)
            {
                lblResult.Text = (pos + 1) + "번째에 - 문자가 있습니다.";
            }*/
        }
    }
}
