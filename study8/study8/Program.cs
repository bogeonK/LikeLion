using System;
using System.Data;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5, y = 10;


            //Console.WriteLine(x == y);  // false
            //Console.WriteLine(x != y);  // true
            //Console.WriteLine(x < y);   // true
            //Console.WriteLine(x > y);   // false
            //Console.WriteLine(x >= y);  // false
            //Console.WriteLine(x <= y);  //true  

            //논리 연산자 
            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);
            ////a랑 b가 둘다 참이어야 함
            ////AND : 1 : 1   t
            ////      1 : 0   f
            ////      0 : 1   f
            ////      0 : 0   f
            //Console.WriteLine(a || b);
            ////OR  : 1 : 1   t
            ////      1 : 0   t
            ////      0 : 1   t
            ////      0 : 0   f
            //bool a = false;
            //bool b = false;
            ////NOT
            ////!a

            //b = !a;

            //Console.WriteLine(b); //true

            //비트연산자
            //int x = 5; // 0101
            //int y = 3; // 0011

            //Console.WriteLine(x & y); //AND : 1 (0001)
            //Console.WriteLine(x | y); //OR : 7 (0111)
            //Console.WriteLine(x ^ y); //XOR : 6 (0110)
            //Console.WriteLine(~x);    //NOT : -6

            //int value = 4; //0100
            //Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //오른쪽이동 : 2 (0010)

            //// 삼항 연산자
            //int a = 10, b = 20;
            //int max;

            //max = (a > b) ? a : b;
            //Console.WriteLine(max);
            //// (비교) ? 참 : 거짓 ;
            ///

            //int score = 75;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F입니다.");
            //}



            // 가지고 있는 소지금을 입력하세요
            // 0~100 무한의 대검
            // 101~200 카타나
            // 201~300 진은검
            // 301~400 집판검
            // 401~500 엑스칼리버
            // 501~600 유령검


            //Console.WriteLine("가지고 있는 소지금을 입력하세요 : ");
            //int money = int.Parse(Console.ReadLine());
            //string name = "멋사";

            //int att = 100;

            //if(money <= 100)
            //{
            //    att += 1;
            //    Console.WriteLine("무한의 대검을 얻었습니다!");
            //    Console.WriteLine($"캐릭터 이름: {name}");
            //    Console.WriteLine($"공격력: {att}");
            //}
            //else if(money > 100 && money <= 200)
            //{
            //    att += 2;
            //    Console.WriteLine("카타나를 얻었습니다!");
            //    Console.WriteLine($"캐릭터 이름: {name}");
            //    Console.WriteLine($"공격력: {att}");
            //}
            //else if (money > 200 && money <= 300)
            //{
            //    att += 3;
            //    Console.WriteLine("진은검을 얻었습니다!");
            //    Console.WriteLine($"캐릭터 이름: {name}");
            //    Console.WriteLine($"공격력: {att}");
            //}
            //else if (money > 300 && money <= 400)
            //{
            //    att += 4;
            //    Console.WriteLine("집판검을 얻었습니다!");
            //    Console.WriteLine($"캐릭터 이름: {name}");
            //    Console.WriteLine($"공격력: {att}");
            //}
            //else if (money > 400 && money <= 500)
            //{
            //    att += 5;
            //    Console.WriteLine("엑스칼리버를 얻었습니다!");
            //    Console.WriteLine($"캐릭터 이름: {name}");
            //    Console.WriteLine($"공격력: {att}");
            //}
            //else if (money > 500 && money <= 600)
            //{
            //    att += 6;
            //    Console.WriteLine("유령검를 얻었습니다!");
            //    Console.WriteLine($"캐릭터 이름: {name}");
            //    Console.WriteLine($"공격력: {att}");
            //}
            //else
            //{
            //    att += 7;
            //    Console.WriteLine("전설의검을 얻었습니다!");
            //    Console.WriteLine($"캐릭터 이름: {name}");
            //    Console.WriteLine($"공격력: {att}");
            //}

            // 오후문제1
            // 세 정수의 최대값 구하기 
            // 사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요
            // 요구사항:
            // 사용자에게 세 개의 정수를 입력받습니다.
            // if문을 사용하여 가장 큰 정수를 결정합니다.
            // 결과를 "최대값:X" 형식으로 출력합니다

            //Console.WriteLine("첫 번째 정수를 입력하세요");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("두 번째 정수를 입력하세요");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("세 번째 정수를 입력하세요");
            //int c = int.Parse(Console.ReadLine());

            //int max = 0;

            //if(a == b && b == c && a == c)
            //{
            //    max = a;
            //}
            //else if(a >= b && a >= c)
            //{
            //    max = a;
            //}
            //else if (b >= a && b > c)
            //{
            //    max = b;
            //}
            //else
            //{
            //    max = c;
            //}
            //Console.WriteLine("최대값: " + max);

            //문제 2.점수에 따른 학점 평가
            //문제 설명:
            //학생의 점수를 입력받아 아래 기준에 따라 학점을 출력하는 프로그램을 작성하세요.
            //90 이상: A 학점
            //80 이상 90 미만: B 학점
            //70 이상 80 미만: C 학점
            //60 이상 70 미만: D 학점
            //60 미만: F 학점

            //Console.WriteLine("점수를 입력하세요: ");
            //int score = int.Parse(Console.ReadLine());

            //if(score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else if(score >= 80 && score < 90)
            //{
            //    Console.WriteLine("B학점");
            //}
            //else if (score >= 70 && score < 80)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else if (score >= 60 && score < 70)
            //{
            //    Console.WriteLine("D학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}

            //문제 3.간단한 사칙연산 계산기
            //문제 설명:
            //사용자로부터 두 개의 숫자와 연산자(+, -, *, /)를 입력받아 해당 연산을 수행하고 결과를 출력하는 계산기 프로그램을 작성하세요.
            //요구사항:

            //두 개의 숫자와 연산자 기호를 입력받습니다.
            //if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
            //나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
            //결과는 “결과: X” 형식으로 출력합니다.

            Console.WriteLine("첫 번째 정수를 입력하세요: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 정수를 입력하세요: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("원하시는 연산자를 입력하세요: ");
            char oper = char.Parse(Console.ReadLine());

            float res = 0;

            if (oper == '+')
            {
                res = num1 + num2;
            }
            else if (oper == '-')
            {
                res = num1 - num2;
            }
            else if (oper == '*')
            {
                res = num1 * num2;
            }
            else if (oper == '/')
            {
                res = (float)num1 / num2;
            }

            Console.WriteLine($"{num1} {oper} {num2} = {res}");
        }
    }
}
