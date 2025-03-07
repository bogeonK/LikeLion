using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study38
{
    class MyResource
    {
        // 소멸자
        ~MyResource()
        {
            Console.WriteLine("삭제될때 호출");
        }
    }
    class Program
    {
        // 메서드 ref, out
        static void Increase(ref int x)
        {
            x++;
        }

        //out은 반환이 여러개일때 유용
        static void OutFunc( int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
        }
       
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            //Increase(ref a);
            //Console.WriteLine("A의 값: " + a);
            int x, y;
            OutFunc(a, b, out x, out y);
            Console.WriteLine("x: " + x + "y: " + y);
        }
    }
}
