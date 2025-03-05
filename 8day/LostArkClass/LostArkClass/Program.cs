using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LostArkClass
{
    class CharacterClass
    {
        public string Name;
        public int Health;

        public CharacterClass()
        {
            Name = "name";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이 ");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이 이동합니다.");
        }
    }
    class Warlord : CharacterClass
    {
        public Warlord()
        {
            Name = "워로드";
            Health = 120;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name}이(가) 공격합니다.");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다.");
        }
    }

    class Berserker : CharacterClass
    {
        public Berserker()
        {
            Name = "버서커";
            Health = 110;
        }

        public override void Attack()
        {
            Console.WriteLine();
        }
        public override void Move()
        {
            Console.WriteLine();
        }
    }

    class Skill
    {
        public string Name; //스킬 이름
        public int ManaCost;    // 마나 소모량
        public int Cooldown; //재사용 대기시간(밀리초)
        public int LastUsedTime; // 마지막 사용시간(TickCount 기준)

        public Skill(string name, int manaCast, int cooldown)
        {
            Name = name;
            ManaCost = manaCast;
            Cooldown = cooldown * 1000; //초를 밀리초로 변환
            LastUsedTime = 0; // 처음엔 사용하지 않은 상태
        }

        public bool CanUse(int playerMane)
        {
            int cuttentTime = Environment.TickCount;

            if (playerMane < ManaCost)
            {
                Console.WriteLine($"마나가 부족합니다! (필요MP : {ManaCost}");
                return false;
            }

            if (cuttentTime - LastUsedTime < Cooldown)
            {
                int remainingTime = (Cooldown - (cuttentTime - LastUsedTime)) / 1000;
                Console.WriteLine($"{Name} 스킬은 아직 사용할 수 없습니다! (남은 시간 : {remainingTime}초");
                return false;
            }
            return true;
        }

        public void use(ref int playerMana)
        {
            if (!CanUse(playerMana)) return;

            playerMana -= ManaCost;
            LastUsedTime = Environment.TickCount;

            Console.WriteLine($"{Name} 스킬 사용! (MP - {ManaCost})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int playerMana = 200;
            int c = 0;

            Warlord warlord = new Warlord();
            Berserker berserker = new Berserker();

            //스킬 목록(배열사용)
            Skill[] wSkill = new Skill[]
            {
                new Skill("버스트 캐넌", 20, 3),      //마나 20, 소모, 3초 쿨다운
                new Skill("차지 스팅거", 20, 3),        //마나 15, 소모, 2초 쿨다운
                new Skill("가디언의 낙뢰", 30, 5),        //마나 30, 소모, 5초 쿨다운
            };

            Skill[] bSkill = new Skill[]
            {
                new Skill("헬 블레이드", 10, 3),
                new Skill("레드 더스트", 10, 3),
                new Skill("소드 스톰", 30, 5),
            };

            Console.WriteLine($"직업을 선택하세요 : 1.버서커. 2.워로드");

            c = int.Parse(Console.ReadLine());

            while (true)
            {
                if (c == 2)
                {
                    Console.WriteLine($"현재 직업: {warlord.Name}");
                    Console.WriteLine($"현재 체력: {warlord.Health}");
                    Console.WriteLine($"현재 MP: {playerMana}");

                    Console.WriteLine("무엇을 할까? : 1.기본공격  2.스킬  3.이동");
                    int select = int.Parse(Console.ReadLine());
                    if (select == 1)
                    {
                        warlord.Attack();
                    }
                    else if (select == 2)
                    {
                        Console.WriteLine("사용 가능한 스킬: ");
                        for (int i = 0; i < wSkill.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {wSkill[i].Name} (MP {wSkill[i].ManaCost} +" +
                                $", 쿨다운 {wSkill[i].Cooldown / 1000}s)");
                        }
                        Console.WriteLine("0.종료");
                        Console.Write("사용할 스킬 번호를 입력하세요:");

                        try
                        {
                            int skillIndex = int.Parse(Console.ReadLine());

                            if (skillIndex == 0) break;

                            if (skillIndex > 0 && skillIndex <= wSkill.Length)
                            {
                                wSkill[skillIndex - 1].use(ref playerMana);     //플레이어 마나 참조
                            }
                            else
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("숫자를 입력하세요!");
                        }

                    }
                    else
                    {
                        warlord.Move();
                    }
                }
                if (c == 1)
                {
                    if (c == 2)
                    {
                        Console.WriteLine($"현재 직업: {berserker.Name}");
                        Console.WriteLine($"현재 체력: {berserker.Health}");
                        Console.WriteLine($"현재 MP: {playerMana}");

                        Console.WriteLine("무엇을 할까? : 1.기본공격  2.스킬  3.이동");
                        int select = int.Parse(Console.ReadLine());
                        if (select == 1)
                        {
                            berserker.Attack();
                        }
                        else if (select == 2)
                        {
                            Console.WriteLine("사용 가능한 스킬: ");
                            for (int i = 0; i < bSkill.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {bSkill[i].Name} (MP {bSkill[i].ManaCost} +" +
                                    $", 쿨다운 {bSkill[i].Cooldown / 1000}s)");
                            }
                            Console.WriteLine("0.종료");
                            Console.Write("사용할 스킬 번호를 입력하세요:");

                            try
                            {
                                int skillIndex = int.Parse(Console.ReadLine());

                                if (skillIndex == 0) break;

                                if (skillIndex > 0 && skillIndex <= bSkill.Length)
                                {
                                    bSkill[skillIndex - 1].use(ref playerMana);     //플레이어 마나 참조
                                }
                                else
                                {
                                    Console.WriteLine("잘못된 입력입니다.");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("숫자를 입력하세요!");
                            }

                        }
                        else
                        {
                            berserker.Move();
                        }
                        Console.WriteLine("---------------------------------------");

                    }

                }
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
