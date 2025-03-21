﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace study42
{
    class Warrior : GameCharacter
    {
        public Warrior(string name) : base(name, 100, 25, 10)
        {

        }


        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 기본 공격을합니다!!");
            target.TakeDamage(Attack);
        }

        public override void SpecialAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}이 {target.Name}에게 힐윈드를 시전합니다!!");
            target.TakeDamage(Attack * 2);
        }
    }
}

