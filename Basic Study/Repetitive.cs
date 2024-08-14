using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repetitive
{
    public partial class Repetitive : Form
    {
        public Repetitive()
        {
            InitializeComponent();
        }

   
        
        private void btnRepeat_Click(object sender, EventArgs e)
        {   
           //while 문
           /* int i = 0;
            while (i < 5)
            {
                lblRepeat.Text += "C# programming" + "\r\n"; //  lblRepeat.Text = lblRepeat.Text + "C# programming";
                i++;
            }*/
            // for 문
            /* for (int i = 0; i < 5; i++ )
            {
                lblRepeat.Text += "C# programming" + Environment.NewLine; //  lblRepeat.Text = lblRepeat.Text + "C# programming";
              
            }*/
            //구구단
            int Dan = int.Parse(tbDan.Text );
            int Cal;
            lblRepeat.Text = "";

            for (int i = 1; i < 10; i++ )
            {
                Cal = Dan * i;
                lblRepeat.Text += tbDan.Text  +  "X" + i.ToString() + "=" + Cal.ToString() +  Environment.NewLine; // 구구단 결과표시
              
            }
        }

     
    }
}
