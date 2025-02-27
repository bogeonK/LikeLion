using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_17
{
    class Program
    {
        //C# 구조체
        //클래스와 비슷하지만, 값 타임(Value Type)이며 가볍고 빠름
        //주로 간단한 데이터 묶음을 만들때사용

        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용하려고 하는 키워드
            public int x;
            public int y;
            
            public void Print()
            {
                Console.WriteLine($"좌표: {x}, {y}");
            }
        }
        static void Main(string[] args)
        {
            Point p; //구조체 선언(초기화 필요)

            p.x = 10;
            p.y = 20;
            p.Print();
        }
    }
}
