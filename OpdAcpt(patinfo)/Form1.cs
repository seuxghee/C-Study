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
        //버튼 클릭시 새로운 form 보여줌
        private void ultraButton3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        // 체크박스 클릭시 활성화
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            uttxtPassortNo.Enabled = checkBox11.Checked;
        }      
    }
}
