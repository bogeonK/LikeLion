using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 콘솔 창 크기 설정
            Console.SetWindowSize(80, 25);

            // 콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false; // 커서 숨기기

            Console.Clear(); //화면 지우기
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("┃            숫자야구 게임에 오신 것을 환영합니다!           ┃");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 18);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 19);
            Console.WriteLine("┃                                                            ┃");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);
            Console.Clear();

            int count = 9;
            Random rand = new Random();
            int[] baseBall = new int[3];
            int index = 0;

            while (index < 3)
            {
                int num = rand.Next(1, 10);
                bool checkedNum = false;

                for(int i=0; i<index; i++)
                {
                    if (baseBall[i] == num)
                    {
                        checkedNum = true;
                        break;
                    }
                }

                if (checkedNum == false)
                {
                    baseBall[index] = num;
                    index++;
                }
            }

            while (count>0)
            {
                int Strike = 0;
                int Ball = 0;
                bool Out = false;


                Console.WriteLine("정수 세개를 입력하세요!");
                int[] pred = Console.ReadLine().Split().Select(int.Parse).ToArray();

                bool[] checkedBall = new bool[pred.Length];

                for (int i=0; i<baseBall.Length; i++)
                {
                    for(int j=0; j<pred.Length; j++)
                    {
                        if (i == j && baseBall[i] == pred[j])
                        {
                            Strike += 1;
                            Out = true;
                        }
                        else if(i != j && baseBall[i] == pred[j])
                        {
                            Ball += 1;
                            Out = true;
                           
                        }
                    }
                    if (Out == false)
                    {
                        
                    }
                }
                if (Out == false)
                {
                    Console.WriteLine("아웃!");
                    count -= 1;
                    Console.WriteLine("남은 횟수 : " + count);

                }
                else if(Strike == 3)
                {
                    Console.WriteLine("스트라이크!!!");
                    Thread.Sleep(500);
                    Console.WriteLine("컴퓨터가 뽑은 숫자" + baseBall[0] + baseBall[1] + baseBall[2]);
                    Thread.Sleep(500);
                    Console.WriteLine("승리하셨습니다!! 게임을 종료합니다!!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{Strike}스트라이크 {Ball}볼");
                    count -= 1;
                    Console.WriteLine("남은 횟수 : " + count);
                }

            }
            if (count == 0)
            {
                Console.WriteLine("경기가 종료되었습니다.");
            }
        }
    }
}
