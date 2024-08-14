using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 연산자  20240814
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text); //Parse 통해 integer타입으로 바꿔줌
            int num2 = int.Parse(txtNum2.Text);
            int num3 = num1 + num2;
            lblResult.Text = num3.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text); //Parse 통해 integer타입으로 바꿔줌
            int num2 = int.Parse(txtNum2.Text);
            int num3 = num1 - num2;
            lblResult.Text = num3.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text); //Parse 통해 integer타입으로 바꿔줌
            int num2 = int.Parse(txtNum2.Text);
            int num3 = num1 * num2;
            lblResult.Text = num3.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text); //Parse 통해 integer타입으로 바꿔줌
            int num2 = int.Parse(txtNum2.Text);
            int num3 = num1 / num2;
            lblResult.Text = num3.ToString();
        }
    }
}
