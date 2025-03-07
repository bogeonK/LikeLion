using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class Monster
    {
        public INFO n_monster;

        public void SetDamage(int Attack) { n_monster.Hp -= Attack; }

        public void SetMonster(INFO imonster) { n_monster = imonster; }

        public INFO GetMonster() { return n_monster; }

        public void Render()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("몬스터 이름 : " + n_monster.Name);
            Console.WriteLine("체력 : " + n_monster.Hp + "\t공격력 : " + n_monster.Attack);
        }
    }
}
