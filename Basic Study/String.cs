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
        //추가
        StringBuilder str = new StringBuilder();

        /// <summary>
        /// String 클래스의 Length,Substring 20240814 / Replace,ToUpper, ToLower,StringBuilder 20240819
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInput_Click(object sender, EventArgs e)
        {

            string str = tbInput.Text;

            // 앞글자만 대문자
            //string str1 = str.Substring(0, 1);
            //string str2 = str.Substring(1,str.Length -1);

            //str1 = str1.ToUpper();
            //str2 = str2.ToLower();

            //lblResult.Text = str1 + str2;


            //ToUpper
            //str = str.ToUpper();
            //lblResult.Text = str;


            //Replace
            //string str2 = str.Replace(" ", "");
            //lblResult.Text = str2;

            //substring 
            //string subStr = str.Substring(7, 1);
            //string subMonth = str.Substring(2, 2);
            //string subDay = str.Substring(4, 2);

            //lblBirthday.Text = "생일:" + subMonth + "월" + subDay + "일";


            //if ((subStr == "1") || (subStr == "3"))
            //{
            //    lblResult.Text = "남성";
            //}
            //else if ((subStr == "2") || (subStr == "4"))
            //{
            //    lblResult.Text = "여성";

            //}
            //else
            //{
            //    lblResult.Text = "당신은 외계인?";

            //}


            //length
            /*lblResult.Text = str.Length.ToString();

            int pos = str.IndexOf("-");

            if (pos >= 0)
            {
                lblResult.Text = (pos + 1) + "번째에 - 문자가 있습니다.";
            }*/
        }
        //StringBuilder
        private void btnDefault_Click(object sender, EventArgs e)
        {
            str.Clear();
            str.Append("안녕하세요");
            lblResult.Text = str.ToString();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            str.Append("Hello");
            lblResult.Text = str.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            str.Remove(2, 3);
            lblResult.Text = str.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            str.Insert(2, "영어로는");
            lblResult.Text = str.ToString();
        }

    }
}
