using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogCare
{
    class Dog
    {
        //멤버 변수
        private string dogName;
        private int dogLife = 50;

        //생성자
        public Dog()
        {
           
        }
        //메소드
        public void SetDogName(string dogName)
        {
            this.dogName = dogName;
        }
        public int GetDogLife()
        {
            return  this.dogLife;
        }
        public void Play()
        { 
            
            dogLife += dogLife + 5;
            if (dogLife >= 100) dogLife = 100;
        }

        public void  Feed()
        {
            dogLife += dogLife + 10;
            if (dogLife >= 100) dogLife = 100;
        }

        public void LifeDec()
        {
            dogLife -= 1;
            if (dogLife <= 0) dogLife = 0;
        }

        public string  Message()
        {
            string msg;
            if (dogLife >= 70)
            {
                msg = dogName + "~가 행복해요~";
            }
            else if (dogLife >= 50)
            {
                msg = dogName + "랑 놀어주세요~";
            }
            else if (dogLife >= 25)
            {
                msg = dogName + "가 슬퍼요~";
            }
            else if (dogLife > 0)
            {
                msg = dogName + "가 위험해요~";
            }
            else
            {
                msg = dogName + "게임이 끝났어요 ㅠㅠ";
            }
            return msg;
            }
    }
}
