using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_과제
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int sum = 0;

            Console.Write("숫자 입력 : ");
            string[] input = Console.ReadLine().Split();

            for(int i=0; i<num.Length; i++)
            {
                num[i] = int.Parse(input[i]);
                sum += num[i];
               
            }

            Console.WriteLine("총 합 : " + sum);


        }
    }
}
