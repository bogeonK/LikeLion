using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpgTimeAttack
{
    class MainGame
    {
        public Player n_Player = null;
        public Field n_Field = null;

        public void Initialize()
        {
            n_Player = new Player();
            n_Player.SelectJob();
        }
        
        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();
                n_Player.Render();
                Console.WriteLine("1. 사냥터 | 2. 종료");
                input = int.Parse(Console.ReadLine());
                if(input == 2)
                {
                    break;
                }
                if(input == 1)
                {
                    n_Field = new Field();
                    n_Field.SetPlayer(ref n_Player);
                }
                n_Field.Progress();
            }
        }

    }
}
