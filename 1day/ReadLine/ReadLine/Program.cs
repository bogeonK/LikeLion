using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            float ruinSkill = 0.0f;
            float cardGet = 0.0f;
            float ulti = 0.0f;
            float maxMp = 0.0f;
            float recovMp = 0.0f;
            float nRecovMp = 0.0f;
            float move = 0.0f;
            float riding = 0.0f;
            float trans = 0.0f;
            float coolDown = 0.0f;


            Console.Write("루인 스킬 피해를 입력하세요 : ");
            ruinSkill = float.Parse(Console.ReadLine());
            Console.Write("카드 게이지 획득량을 입력하세요 : ");
            cardGet = float.Parse(Console.ReadLine());
            Console.Write("각성기 피해를 입력하세요 : ");
            ulti = float.Parse(Console.ReadLine());
            Console.Write("최대 마나를 입력하세요 : ");
            maxMp = float.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량을 입력하세요 : ");
            recovMp = float.Parse(Console.ReadLine());
            Console.Write("비 전투 중 마나 회복량을 입력하세요 : ");
            nRecovMp = float.Parse(Console.ReadLine());
            Console.Write("이동속도를 입력하세요 : ");
            move = float.Parse(Console.ReadLine());
            Console.Write("탈 것 속도를 입력하세요 : ");
            riding = float.Parse(Console.ReadLine());
            Console.Write("운반속도를 입력하세요 : ");
            trans = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소를 입력하세요 : ");
            coolDown = float.Parse(Console.ReadLine());

            Console.WriteLine($"루인 스킬 피해     : {ruinSkill}%");
            Console.WriteLine($"카드 게이지 획득량     : {cardGet}%");
            Console.WriteLine($"각성기 피해     : {ulti}%");
            Console.WriteLine($"최대 마나     : {maxMp}");
            Console.WriteLine($"전투 중 마나 회복량     : {recovMp}");
            Console.WriteLine($"비 전투 중 마나 회복량     : {nRecovMp}");
            Console.WriteLine($"이동속도     : {move}%");
            Console.WriteLine($"탈 것 속도     : {riding}%");
            Console.WriteLine($"운반속도     : {trans}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소     : {coolDown}%");

        }
    }
}
