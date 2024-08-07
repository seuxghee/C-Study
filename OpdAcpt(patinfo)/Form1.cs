using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //placeholder 부분
        private void Patnum(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pat num")
            {
                textBox1.Text = "";
            }
        }

        private void Patleave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Pat num";
               
            }
        }

        private void Patname(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pat name")
            {
                textBox1.Text = "";
            }
        }

        private void Patnleave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Pat name";
            }
        }

        private void num1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Num")
            {
                textBox1.Text = "";
            }
        }

        private void num2(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Num";
            }
        }

        private void backnum(object sender, EventArgs e)
        {
            if (textBox1.Text == "Back num")
            {
                textBox1.Text = "";
            }
        }

        private void backnum2(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Back num";
            }
        }

        private void Engname(object sender, EventArgs e)
        {
            if (textBox1.Text == "Eng name")
            {
                textBox1.Text = "";
            }
        }

        private void Engname2(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Eng name";
            }
        }
        private void address(object sender, EventArgs e)
        {
            if (textBox1.Text == "Address")
            {
                textBox1.Text = "";
            }
        }

        private void address1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Address";
            }
        }
        private void Phone(object sender, EventArgs e)
        {
            if (textBox1.Text == "Phone num")
            {
                textBox1.Text = "";
            }
        }
        private void Phone1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Phone num";
            }
        }
        private void homenum(object sender, EventArgs e)
        {
            if (textBox1.Text == "Home num")
            {
                textBox1.Text = "";
            }
        }
        private void homenum1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Home num";
            }
        }
        private void Birth(object sender, EventArgs e)
        {
            if (textBox1.Text == "Birth day")
            {
                textBox1.Text = "";
            }
        }

        private void Birth1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Birth day";
            }
        }

        private void Email(object sender, EventArgs e)
        {
            if (textBox1.Text == "Email")
            {
                textBox1.Text = "";
            }
        }

        private void Email1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Email";
            }
        }
        //form 이동
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void s(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //입력할때 글씨색 검정으로 변경
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.Black;
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.Black;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.ForeColor = Color.Black;

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.ForeColor = Color.Black;
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.ForeColor = Color.Black;
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox12.ForeColor = Color.Black;
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox13.ForeColor = Color.Black;
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox14.ForeColor = Color.Black;
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox15.ForeColor = Color.Black;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox16.ForeColor = Color.Black;
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox17.ForeColor = Color.Black;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            textBox18.ForeColor = Color.Black;
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            textBox19.ForeColor = Color.Black;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       //체크박스 선택 시 텍스트박스 활성화 
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox18.Enabled = false;
            comboBox4.Enabled = false;
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
           
            textBox18.Enabled = checkBox11.Checked;
            comboBox4.Enabled = checkBox11.Checked;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       

      

       

       

       
       


     
        
      
    }
}
