using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        public int player1Score = 0;
        public int player2Score = 0;
        public int bulletCount = 0;

        public float angle;

        public float power;

        public bool isPlayer1;

        public BULLET[] playerBullet = new BULLET[1];

        public Player(bool isPlayer1) // 생성자
        {
            this.isPlayer1 = isPlayer1;
            // 플레이어 좌표위치 초기화
            if (isPlayer1)
            {
                playerX = 5;
                playerY = 45;
            }
            else
            {
                playerX = 150; // 플레이어 2는 오른쪽에서 시작
                playerY = 45;
            }


            for (int i = 0; i < 1; i++) // 총알 초기화
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
                playerBullet[i].speedY = 0; // 초기 속도 0
            }
        }

        public bool GameMain(bool isPlayer1, bool isTurn)
        {
            if (isTurn)
            {
                bool turnSwitch = KeyControl(isPlayer1);
                // 조작 후에 캐릭터도 항상 그려주기
                if (isPlayer1) Player1Draw();
                else Player2Draw();

                return turnSwitch;  // Enter 키 눌렀으면 true
            }
            else
            {
                // 턴이 아닌 플레이어도 화면에는 항상 보이도록 그려줌
                if (isPlayer1) Player1Draw();
                else Player2Draw();

                return false;  // 턴 교대 없음
            }
        }

        private bool KeyControl(bool isPlayer1)
        {
            int pressKey;  // 정수형 변수선언 키값 받을거임

            if (Console.KeyAvailable)    // 키가 눌렷을때 true
            {
                pressKey = _getch();    // 아스키값 왼쪽 오른쪽

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }
                if (isPlayer1)
                {
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
                            if (angle > 45)
                                angle = 45;
                            break;

                        case 80: // 아래쪽 화살표 (각도 감소)
                            angle -= 5;
                            if (angle < 0)
                                angle = 0;
                            break;

                        case 32:    // 스페이스바
                                    // 총알 발사
                            if (bulletCount > 0)
                            {
                                for (int i = 0; i < 1; i++)
                                {
                                    // 미사일이 false 발사가능
                                    if (playerBullet[i].fire == false)
                                    {
                                        playerBullet[i].fire = true;
                                        bulletCount--;

                                        // 발사 각도 계산 (라디안 변환)
                                        double radian = angle * (Math.PI / 180.0);

                                        power = 5.4f;
                                        // 포탄 속도 설정 (x, y 방향)
                                        playerBullet[i].speedX = (float)(Math.Cos(radian) * power);
                                        playerBullet[i].speedY = -(float)(Math.Sin(radian) * power); // 위쪽으로 발사

                                        // 플레이어 앞에서 미사일 쏘기 + 5
                                        playerBullet[i].x = playerX + 5;
                                        playerBullet[i].y = playerY + 1;

                                        break;
                                    }
                                }
                            }
                            break;

                        case 13:
                            return true;
                    }

                }
                else
                {
                    // 플레이어2 조작
                    switch (pressKey)
                    {
                        case 75: // ←
                            playerX--;
                            if (playerX < 75) playerX = 75;
                            break;
                        case 77: // →
                            playerX++;
                            if (playerX > 150) playerX = 150;
                            break;
                        case 72: // ↑
                            angle += 5;
                            if (angle > 45) angle = 45;
                            break;
                        case 80: // ↓
                            angle -= 5;
                            if (angle < 0) angle = 0;
                            break;
                        case 32: // Spacebar
                            if (bulletCount > 0)
                            {
                                for (int i = 0; i < 1; i++)
                                {
                                    // 미사일이 false 발사가능
                                    if (playerBullet[i].fire == false)
                                    {
                                        playerBullet[i].fire = true;
                                        bulletCount--;

                                        // 발사 각도 계산 (라디안 변환)
                                        double radian = angle * (Math.PI / 180.0);

                                        power = 5.4f;
                                        // 포탄 속도 설정 (x, y 방향)
                                        playerBullet[i].speedX = -(float)(Math.Cos(radian) * power);
                                        playerBullet[i].speedY = -(float)(Math.Sin(radian) * power); // 위쪽으로 발사

                                        // 플레이어 앞에서 미사일 쏘기 + 5
                                        playerBullet[i].x = playerX + 5;
                                        playerBullet[i].y = playerY + 1;

                                        break;
                                    }
                                }
                            }
                            break;
                        case 13: // Enter
                            return true; // 턴 전환 신호
                    }
                }
            }
            return false;
        }

        private void Player1Draw()
        {
            string[] player = new string[]
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

        }

        private void Player2Draw()
        {
            string[] player = new string[]
            {
                " ──■■",
                "  ■■■",
                "  ◎ ◎"
            };

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어X, 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }

        }


        public void BulletDraw(int enemyX, int enemyY, bool isMyTurn)
        {
            // 중력
            float gravity = 0.2f;
            string bullet = "◎";

            for (int i = 0; i < playerBullet.Length; i++)
            {
                if (playerBullet[i].fire)
                {
                    playerBullet[i].speedY += gravity;
                    playerBullet[i].x += (int)playerBullet[i].speedX;
                    playerBullet[i].y += (int)playerBullet[i].speedY;

                    if (playerBullet[i].x >= 0 && playerBullet[i].x < Console.WindowWidth &&
                        playerBullet[i].y >= 0 && playerBullet[i].y < Console.WindowHeight)
                    {
                        Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);
                        Console.Write(bullet);
                    }
                    else
                    {
                        // 화면 밖으로 나가면 탄환 소멸
                        playerBullet[i].fire = false;
                        continue;
                    }

                    if (playerBullet[i].y >= enemyY - 3 && playerBullet[i].y <= enemyY + 3 &&
                        playerBullet[i].x >= enemyX - 4 && playerBullet[i].x <= enemyX + 4)
                    {
                        //충돌시
                        playerBullet[i].fire = false;

                        if (isMyTurn)
                        {
                            if (this.isPlayer1)
                            {
                                player1Score += 100;
                            }
                            else
                            {
                                player2Score += 100;
                            }
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

                Console.OutputEncoding = Encoding.UTF8;

                Console.SetWindowSize(160, 50);
                Console.SetBufferSize(160, 50);

                Console.Clear();
                String asciiArt = @"
█████████   ██████████   ██████████      ██████████████   ██████████         ███████████  █████████████  █████████████
█████████   ██████████   ████████████    ██████████████   ████████████       ███████████  █████████████  █████████████
████       ████    ████  ████     █████       ████        ████     █████     ████         ████           ████
████       ████    ████  ████     █████       ████        ████     █████     ████         ████           ████
█████████  ████    ████  ████████████         ████        ████████████       ████████     █████████████  █████████████
█████████  ████    ████  ████████████         ████        ████████████       ████████     █████████████  █████████████
████       ████    ████  ████     ████        ████        ████     ████      ████                  ████           ████
████       ████    ████  ████      ████       ████        ████      ████     ████                  ████           ████
████         ████████    ████       ████      ████        ████       █████   ███████████  █████████████  █████████████
████         ████████    ████        ████     ████        ████        █████  ███████████  █████████████  █████████████
";

                Console.WriteLine(asciiArt);

                Console.SetCursorPosition(55, 12);
                Console.WriteLine("-- 아무키나 누르면 시작 --");

                Console.ReadKey(true);

                Player player1 = new Player(true);
                Player player2 = new Player(false);

                bool isPlayer1Turn = true;

                player1.bulletCount = 1;
                player2.bulletCount = 0;

                int dwTime = Environment.TickCount;

                while (true)
                {
                    if (dwTime + 50 < Environment.TickCount)
                    {
                        dwTime = Environment.TickCount;
                        Console.Clear();

                        bool turnSwitch1 = player1.GameMain(true, isPlayer1Turn);
                        bool turnSwitch2 = player2.GameMain(false, !isPlayer1Turn);


                        if (turnSwitch1 || turnSwitch2)
                        {
                            isPlayer1Turn = !isPlayer1Turn;
                            if (isPlayer1Turn)
                            {
                                player1.bulletCount = 1;
                                player2.bulletCount = 0;
                            }
                            else
                            {
                                player1.bulletCount = 0;
                                player2.bulletCount = 1;
                            }
                        }

                        player1.BulletDraw(player2.playerX, player2.playerY, isPlayer1Turn);
                        player2.BulletDraw(player1.playerX, player1.playerY, !isPlayer1Turn);

                        string turnText = isPlayer1Turn ? "플레이어 1 턴" : "플레이어 2 턴";
                        Console.SetCursorPosition(80, 0);
                        Console.Write(turnText);

                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine($"[Player1] 발사각도: {player1.angle}°    ");
                        Console.SetCursorPosition(135, 0);
                        Console.WriteLine($"[Player2] 발사각도: {player2.angle}°    ");

                        Console.SetCursorPosition(80, 2);
                        Console.WriteLine($"Player1 Score: {player1.player1Score}");
                        Console.SetCursorPosition(80, 3);
                        Console.WriteLine($"Player2 Score: {player2.player2Score}");

                        Console.SetCursorPosition(0, 2);
                        Console.WriteLine($"[Player1 남은 포탄]: {player1.bulletCount}");
                        Console.SetCursorPosition(135, 2);
                        Console.WriteLine($"[Player2 남은 포탄]: {player2.bulletCount}");

                        if (player1.player1Score >= 500)
                        {
                            Console.Clear();
                            Console.WriteLine("플레이어1 승리!");
                            break;
                        }
                        else if (player2.player2Score >= 500)
                        {
                            Console.Clear();
                            Console.WriteLine("플레이어2 승리!");
                            break;
                        }
                    }
                }

            }
        }
    }
}

