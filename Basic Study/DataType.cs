using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study
{      
    public partial class DataType : Form
    {   
        public DataType()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 변수와 자료형 20240814
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInt_Click(object sender, EventArgs e)
        {
            int iValue = 100;      //선언후 , 100 대입
            lblResult.Text = iValue.ToString(); //iValue를 문자열로 바꿔줌
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double fValue = 3.1415;
            lblResult.Text = fValue.ToString(); 
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            String sValue = "문자열";
            lblResult.Text = sValue;

        }
    }
}
