using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class Player
    {
        public INFO info;

        public void SetDamage(int attack)
        {
            info.Hp -= attack;
        }

        public INFO GetInfo() { return info; }

        public void SetHp(int hp) { info.Hp = hp; }

        public void SelectJob()
        {
            info = new INFO();

            Console.WriteLine("직업을 선택하세요. (1. 전사 | 2. 마법사 | 3. 도적");
            int InputJob = int.Parse(Console.ReadLine());

            switch (InputJob)
            {
                case 1:
                    info.Name = "전사";
                    info.Hp = 120;
                    info.Attack = 80;
                    break;

                case 2:
                    info.Name = "마법사";
                    info.Hp = 80;
                    info.Attack = 100;
                    break;

                case 3:
                    info.Name = "도적";
                    info.Hp = 90;
                    info.Attack = 90;
                    break;
            }
                
        }

        public void Render()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("직업 이름: " + info.Name);
            Console.WriteLine("체력: " + info.Hp);
            Console.WriteLine("공격력: " + info.Attack);

        }






    }
}
