using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// if 조건문 20240814
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click(object sender, EventArgs e)
        {
            int Kor = int.Parse(tbKor.Text);
            int Eng = int.Parse(tbEng.Text);
            int Math = int.Parse(tbMath.Text);
            int Cut = int.Parse(tbCut.Text);
            int Total = Kor + Eng + Math;

            if (Total >= Cut)
            {
                lblResult.Text = tbName.Text + "님" + Total.ToString() + "점입니다. 합격입니다.";
            }
            else
            {
                lblResult.Text = tbName.Text + "님" + Total.ToString() + "점입니다. 불합격입니다.";
            }
        }
    }
}
