using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //클래스 객체 생성
        Dog myDog = new Dog(); 

    /// <summary>
    /// 강아지 키우기 App만들기 20240820
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            myDog.Play();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            myDog.Feed();
        }

        private void tmrLife_Tick(object sender, EventArgs e)
        {
            //Life값 감소
            myDog.LifeDec();
           
            //프로그레스바 디스플레이
            prsBar.Value = myDog.GetDogLife();

            //상태메세지
            lblStatus.Text  = myDog.Message();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            myDog.SetDogName(tboxName.Text);
            tmrLife.Start();
        }
    }
}
