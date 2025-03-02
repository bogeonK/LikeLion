using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{

    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
        public float speedX;
        public float speedY;
    }


    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;  //플레이어 X좌표
        public int playerY;  //플레이어 Y좌표

        public float angle; 

        public float power;

        public BULLET[] playerBullet = new BULLET[1];

        public Player() // 생성자
        {
            // 플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 20;

            for (int i = 0; i < 1; i++) // 총알 초기화
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
                playerBullet[i].speedY = 0; // 초기 속도 0
            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();

            //플레이어를 그려준다.
            PlayerDraw();

        }

        private void KeyControl()
        {
            int pressKey;  // 정수형 변수선언 키값 받을거임

            if (Console.KeyAvailable)    // 키가 눌렷을때 true
            {
                pressKey = _getch();    // 아스키값 왼쪽 오른쪽

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 75:    // 왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;

                        break;

                    case 77:    // 오른쪽 화살표키
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;

                    case 72: // 위쪽 화살표 (각도 증가)
                        angle += 5;
                        if (angle > 90) 
                            angle = 90;
                        break;

                    case 80: // 아래쪽 화살표 (각도 감소)
                        angle -= 5;
                        if (angle < 10) 
                            angle = 10;
                        break;

                    case 32:    // 스페이스바
                        // 총알 발사
                        for (int i = 0; i < 20; i++)
                        {
                            // 미사일이 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;

                                // 발사 각도 계산 (라디안 변환)
                                double radian = angle * (Math.PI / 180.0);

                                power = 4f;
                                // 포탄 속도 설정 (x, y 방향)
                                playerBullet[i].speedX = (float)(Math.Cos(radian) * power);
                                playerBullet[i].speedY = -(float)(Math.Sin(radian) * power); // 위쪽으로 발사

                                // 플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                
                                break;
                            }
                        }
                        break;
                }
            }
        }
        private void PlayerDraw()
        {
            String[] player = new string[]
            {
                " ■■──",
                "■■■",
                "◎ ◎"
            };  // 배열 문자열로 플레이어 그리기


            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어X, 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }
            // 현재 발사 각도 표시
            Console.SetCursorPosition(0, 0);
            Console.Write($"발사 각도: {angle}° ");
        }

        public void BulletDraw()
        {
            string bullet = "◎";
            float gravity = 0.2f; // 중력 가속도

            for (int i = 0; i < 1; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet[i].x + 5, playerBullet[i].y - 1);
                    Console.Write(bullet);

                    
                    playerBullet[i].y += (int)playerBullet[i].speedY; // 위 아래 이동
                    playerBullet[i].speedY += gravity; // 중력 적용



                    playerBullet[i].x += (int)playerBullet[i].speedX; // 속도에 따라 이동

                    if (playerBullet[i].x > 74 || playerBullet[i].y > 23)
                    {
                        playerBullet[i].fire = false; // 미사일 false 다시 준비상태
                    }
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(160, 25);
            Console.SetBufferSize(160, 25);

            Player player = new Player();

            int dwTime = Environment.TickCount;

            while (true)
            {
                if (dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    player.GameMain();

                    player.BulletDraw();
                }
            }

        }
    }
}

