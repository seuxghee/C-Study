using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_2
{
    public partial class Box : Form
    {
        public Box()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 메시지박스, 체크박스 사용하기/ 라디오버튼, 콤보박스,리스트박스 사용하기 20240819
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼을 클릭했습니다.","메세지박스제목",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
        }
        // 메시지 박스, 체크박스 사용하기
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblOrder.Text = "";

            if (checkBox1.Checked == true)
            {
                strOrder += checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)
            {
                strOrder += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                strOrder += checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                strOrder += checkBox4.Text + "\n";
            }

            lblOrder.Text = strOrder + "메뉴를 주문하셨습니다.";

            if(!checkBox1.Checked  && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("메뉴를 선택하고 주문하세요!", "주문 오류", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }
        // 라디오버튼, 콤보박스, 리스트박스
        private void button2_Click(object sender, EventArgs e)
        {
            if (rbAgree.Checked)
            {
                MessageBox.Show("이벤트에 응모하셨습니다.", "이벤트 응오 결과");
            }
            else
            {
                MessageBox.Show("개인정보에동의하지 않으셨습니다.");
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 추가요구사항이 접수되었습니다.";
            MessageBox.Show(strText, "추가요구사항");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string strText = cbPay.Text + " " + lbPayInfo.Text
                + "\n결제방법을 선택하셨습니다.";
            MessageBox.Show(strText, "결제정보확인");
        }


        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월할부");
                lbPayInfo.Items.Add("6개월할부");

            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("우리은행");
                lbPayInfo.Items.Add("국민은행");
                lbPayInfo.Items.Add("하나은행");

            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("롯데포인트");
                lbPayInfo.Items.Add("OK캐쉬백");
                lbPayInfo.Items.Add("주유포인트");

            }
        }
    }
}
