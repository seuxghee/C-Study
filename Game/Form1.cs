using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {  
        /// <summary>
        /// 간단한 게임 만들기 20240822
        /// </summary>

        int health = 100;
        int playerspeed = 7;
        int damage = 20;
        int scorepoint = 0;

        bool goleft, goright; //참, 거짓을 나타냄

        public Form1()
        {
            InitializeComponent();
        }
        
        //게임 메인 타이머
        private void timer1_Tick(object sender, EventArgs e) 
        {
            healthbar.Text = "체력 : " + health; //초기 체력 설정
            score.Text = "점수 :" + scorepoint; //점수 설정
            if (goleft)
            {
                player.Left -= playerspeed;
            } 
            if (goright)
            {
                player.Left += playerspeed;
            }

            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if ((string)control.Tag == "obstacle")// 장애물 데미지
                    {
                        if (player.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                        {
                            control.Visible = false;
                            health -= damage;
                        }
                    }

                    if ((string)control.Tag == "coin")// 코인
                    {
                        if (player.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                        {
                            control.Visible = false;
                            scorepoint++;
                        }
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }
    }
}
