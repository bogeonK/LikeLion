using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class Field
    {
        Player n_player = null;
        Monster n_monster = null;

        public void SetPlayer(ref Player player) { n_player = player; }

        public void Progress()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                n_player.Render(); 
                DrawMap();

                input = int.Parse(Console.ReadLine());

                if(input == 4)
                {
                    break;
                }

                if(input <= 3)
                {
                    CreatMonster(input);
                    Fight();
                }
            }
        }


        public void Create(string mName, int mHP, int mAttack, out Monster monster)
        {
            monster = new Monster();
            INFO tMonster = new INFO();

            tMonster.Name = mName;
            tMonster.Hp = mHP;
            tMonster.Attack = mAttack;

            monster.SetMonster(tMonster);
        }

        public void CreatMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 60, 5, out n_monster);
                    break;
                case 2:
                    Create("중급몹", 80, 10, out n_monster);
                    break;
                case 3:
                    Create("고급몹", 100, 20, out n_monster);
                    break;
            }
        }

        public void Fight()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                n_player.Render();
                n_monster.Render();

                Console.WriteLine("1.공격 | 2.도망");
                input = int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    n_player.SetDamage(n_monster.GetMonster().Attack);
                    n_monster.SetDamage(n_player.GetInfo().Attack);

                    if(n_player.GetInfo().Hp < 0)
                    {
                        n_player.SetHp(100);
                        break;
                    }
                }
                if(input == 2 || n_monster.GetMonster().Hp <= 0)
                {
                    n_monster = null;
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("===============");
            Console.WriteLine("맵을 선택하세요: ");
        }
    }
}
