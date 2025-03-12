using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    public class Brick
    {

        public BRICKDATA[] d_brick = new BRICKDATA[30];
        
        public Brick()
        {
            for(int i = 0; i<d_brick.Length; i++)
            {
                d_brick[i] = new BRICKDATA();
                d_brick[i].brickLife = 0;
                d_brick[i].brickX = 0;
                d_brick[i].brickY = 0;
            }
        }
        public void SetBrick(int nBlckCount)
        {
            int bX = 6;
            int bY = 1;
            for(int i=0; i< nBlckCount; i++)
            {
                d_brick[i].brickLife = 1;
                bX += 2;

                d_brick[i].brickX = bX;
                d_brick[i].brickY = bY;
            }

        }

        public void initialize()
        {
            SetBrick(30);
        }

        public void Progress() { }

        public void Render()
        {
            for(int i=0; i<30; i++)
            {
                if (d_brick[i].brickLife == 1)
                {
                    Console.SetCursorPosition(d_brick[i].brickX, d_brick[i].brickY);
                    Console.Write("■");
                }
            }

        }

        public void Release() { }
    

    }
}
