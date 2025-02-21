using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study4
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 변수 선언과 초기화를 한번에 수행
            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.5; // 실수형 변수 선언과 초기화
            //string city = "Seoul"; //문자열 변수 선언과 초기화

            //// 변수 출력
            //Console.WriteLine(score); //출력100
            //Console.WriteLine(temperature); //출력36.5
            //Console.WriteLine(city); //출력 Seoul


            // 같은 데이터 타입의 변수를 쉼표로 구분해서 서언
            //int x = 10, y = 20, z = 30; //정수형 변수 x,y,z를 선언하고 초기화

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            //const double Pi = 3.14159; //상수 pi선언 및 초기화
            //const int MaxScore = 100; //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi : " + Pi); //출력 : Pi: 3.14159
            //Console.WriteLine("MaxScore : " + MaxScore); //출력 : MaxScor: 100

            int att = 16755;
            int maxhp = 78103;
            int cri = 36;
            int spe = 1017;
            int ove = 41;
            int qui = 611;
            int end = 22;
            int ski = 39;

            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("최대 생명력 : " + maxhp);
            Console.WriteLine("치명 : " + cri);
            Console.WriteLine("특화 : " + spe);
            Console.WriteLine("제압 : " + ove);
            Console.WriteLine("신속 : " + qui);
            Console.WriteLine("인내 : " + end);
            Console.WriteLine("숙련 : " + ski);
            

        }
    }
}
