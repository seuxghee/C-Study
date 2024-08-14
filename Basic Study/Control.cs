using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }
        /// <summary>
        /// else if / switch case 제어문 20240814
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click_1(object sender, EventArgs e)
        {
            int Kor = int.Parse(tbKor.Text);
            int Eng = int.Parse(tbEng.Text);
            int Math = int.Parse(tbMath.Text);
            int Cut = int.Parse(tbCut.Text);
            int Total = Kor + Eng + Math;
            int Avg = Total / 3;
            lblAvg.Text = Avg.ToString();

            if (Total >= Cut)
            {
                lblResult.Text = tbName.Text + "님" + Total.ToString() + "점입니다. 합격입니다.";
            }
            else
            {
                lblResult.Text = tbName.Text + "님" + Total.ToString() + "점입니다. 불합격입니다.";
            }

            //학점계산
            switch (Avg/10)
            { 
                case 10: //다음 case로 넘어감
                    lblGrade.Text = "A";
                    break; //이 case문을 빠져나감.
                case 9:
                    lblGrade.Text = "A";
                    break; 
                case 8:
                    lblGrade.Text = "B";
                    break; 
                case 7:
                    lblGrade.Text = "C";
                    break;
                case 6:
                    lblGrade.Text = "D";
                    break; 
                default :
                     lblGrade.Text = "F";
                    break; 

                 
            }
            /* else if 문으로 바꾸면
            if (90 <= Avg && Avg <= 100 )
            {
                lblGrade.Text = "A";
            }
            else if (80 <= Avg && Avg < 90)
            {
                lblGrade.Text = "B";
            }
            else if (70 <= Avg && Avg < 80)
            {
                lblGrade.Text = "C";
            }
            else if (60 <= Avg && Avg < 70)
            {
                lblGrade.Text = "D";
            }
            else 
            {
                lblGrade.Text = "F";
            } */
        }
    }
}
