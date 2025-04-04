﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 10, y = 10;

            //while (true)
            //{
            //    Console.Clear(); // 화면지우기

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("●");  // 현재 위치 출력

            //    keyInfo = Console.ReadKey(true); // 키 입력 받기 (화면 출력 x)

            //    // 방향키 입력에 따른 좌표 변경
            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow: if (y > 0) y--; break;
            //        case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //        case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //        case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //        case ConsoleKey.Escape: return; // ESC로 종료
            //    }
            //}
            
            
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; // 배열 문자열로 플레이어 그리기

            int playerX = 0;
            int playerY = 12;

            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            ConsoleKeyInfo keyInfo;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds;    // 1/1000       1000일때 1초



            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; // 현재시간 가져오기
                Console.Clear();

                if (currentSecond - prevSecond >= 100)
                {

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열 배열 출력
                        Console.WriteLine(player[i]);
                    }
                    keyInfo = Console.ReadKey(true); // 키 입력 받기 (화면 출력 x)

                    // 방향키 입력에 따른 좌표 변경
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return; // ESC로 종료
                    }

                    prevSecond = currentSecond;     //이전 시간 업데이트
                }

            }

        }
    }
}
