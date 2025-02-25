using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = int.Parse(Console.ReadLine());
            //// switch문
            //switch(day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다");
            //        break;
            //}


            //캐릭터를 선택하세요 (1. 검사 2.마법사 3.도적)
            //스위치문 사용

            //검사
            //공격력 100
            //방어력 90

            //마법사
            //공격력 110
            //방어력80

            //도적
            //공격력115
            //방어력70

            //Console.WriteLine("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적)");
            //int ch = int.Parse(Console.ReadLine());

            //string chClass = " ";
            //int att = 0;
            //int def = 0;

            //switch(ch)
            //{
            //    case 1:
            //        chClass = "검사";
            //        att = 100;
            //        def = 90;
            //        break;
            //    case 2:
            //        chClass = "마법사";
            //        att = 110;
            //        def = 80;
            //        break;
            //    case 3:
            //        chClass = "도적";
            //        att = 115;
            //        def = 70;
            //        break;
            //    default:
            //        Console.WriteLine("해당 캐릭터는 존재하지 않습니다.");
            //        break;
            //}

            //if (ch == 1 || ch == 2 || ch == 3)
            //{
            //    Console.WriteLine($"직업: {chClass}");
            //    Console.WriteLine($"공격력: {att}");
            //    Console.WriteLine($"방어력: {def}");
            //}


            //// 반복문
            //for(int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("숫자: " + i);

            //}

            //0부터 9까지 출력하기
            //for문 활용하기
            //for (int i=0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1~10 합 구하기
            //int sum = 0;
            //for(int i=1; i<11; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int count = 1; //초기화

            //while(count <= 5) //조건식
            //{
            //    Console.WriteLine("count :  " + count);

            //    count++; //증가, 감소

            //    if(count == 3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }
            //}

            //Console.WriteLine("count: " + count);

            //// 랜덤 
            //Random rand = new Random(); // Random객체 생성

            //// 0이상 10미만의 랜덤 정수 생성
            //int randomNumber = rand.Next(0, 10); // 0~9
            //Console.WriteLine("0이상 10미만의 랜덤 정수: " + randomNumber);

            //대장장이 키우기
            //도끼등급 SSS 10%
            //도끼등급 SS 40%
            //도끼등급 S 50%

            //Random rand = new Random(); //랜덤값을 뽑는 문장
            //int rnd = 0;

            //for(int i =0; i<20; i++)
            //{
            //    rnd = rand.Next(1, 101); // 1~100

            //    if (rnd >= 1 && rnd <= 10)
            //    {
            //        Console.WriteLine("도끼등급 SSS");
            //    }
            //    else if (rnd >= 11 && rnd <= 50) 
            //    {
            //        Console.WriteLine("도끼등급 SS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("도끼등급 S");
            //    }
            //    Thread.Sleep(500); // 0.5초 정도로 뽑아라
            //}



            //do while
            //1회 무조건 실행하고 while문과 같이 조건진행

            //int x = 5;

            //do
            //{
            //    Console.WriteLine("최소 한번은 실행됩니다.");
            //    x--;
            //} while (x > 0);


            //break 문
            //반복문을 탈출할 수 있다.

            //for(int i=1; i<=10; i++)
            //{
            //    if(i == 5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}


            //continue
            //현재 반복을 거넌뛰고 다음 반복으로 넘어간다

            //for(int i=1; i<=10; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i); //홀수만 출력
            //}


            //goto

            //int n = 1;

            //start:

            //if(n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //레이블로 이동
            //}



        }
    }
}
