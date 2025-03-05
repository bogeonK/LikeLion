using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace study26
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Charlie", "Alice", "Bob" };
            //var sortedNames = names.OrderBy(n => n);

            //foreach(var name in sortedNames)
            //{
            //    Console.WriteLine(name);
            //}
            // A로 시작하는 첫번째 문자열을 찾는 코드
            //var firstName = names.First(n => n.StartsWith("A"));



            ////메서드구문, 쿼리 구문
            //int[] nums = { 5, 3, 8, 1 };

            ////메서드 구문
            //var sortedMeshod = nums.OrderBy(n => n);

            ////쿼리 구문
            //var sortedQuery = from n in nums
            //                  orderby n
            //                  select n;

            //Console.WriteLine("메소드 구문: ");
            //foreach (var n in sortedMeshod)
            //    Console.WriteLine(n);

            //Console.WriteLine("쿼리 구문: ");
            //foreach (var n in sortedQuery)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] words = { "apple", "banana", "cherry" };

            ////Select()로 길이 추출

            //var lengths = words.Select(w => w.Length);

            //foreach(var length in lengths)
            //{
            //    Console.WriteLine(length);
            //}


            //string[] words = { "apple", "banana", "cherry" };

            //var upperWords = words.Select(w => w.ToUpper());

            //foreach(var word in upperWords)
            //{
            //    Console.WriteLine(word);
            //}

            //int[] data = { 1, 2, 3, 4, 5 };
            //int sum = 0;

            //foreach (var d in data)
            //    sum += d;

            //Console.WriteLine($"Sum : {sum}");

            //int[] data = { 1, 2, 3, 4, 5 };

            //int count = data.Length;  //개수

            //Console.WriteLine($"Cout : {count}");

            //int[] data = { 55, 76, 65 };
            //int max = data.Max();

            //Console.WriteLine($"Max :  {max}");


            //int[] data = { 55, 76, 45 };

            //int min = data.Min();

            //Console.WriteLine($"Min : {min}");

            //int[] data = { 10, 12, 20, 25, 30 };
            //int target = 13;
            //int nearest = data[0];

            //foreach(var d in data)
            //{
            //    if (Math.Abs(d - target) < Math.Abs(nearest - target))
            //        nearest = d;
            //}

            //Console.WriteLine("주어진 리스트");
            //foreach (var i in data)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine($"{target}에 가장 가까운 수 : {nearest}");


            //int[] score = { 90, 80, 50, 80, 60 };

            //for(int i=0; i<score.Length; i++)
            //{
            //    int rank = 1;

            //    for(int j=0; j<score.Length; j++)
            //    {
            //        if (score[j] > score[i])
            //            rank++;
            //    }
            //    Console.WriteLine($"Score : {score[i]}, Rank : {rank}");
            //}

            //int[] data = { 5, 2, 8, 1, 9 };
            //Array.Sort(data);

            //foreach (var d in data)
            ////    Console.WriteLine(d);

            //int[] data = { 5, 2, 8, 1, 9 };
            //int target = 8;
            //int index = -1;

            //for(int i =0; i<data.Length; i++)
            //{
            //    if (data[i] == target)
            //    {
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine("주어진 리스트");
            //for(int i =0; i<data.Length; i++)
            //{
            //    Console.WriteLine(data[i]);
            //}
            //Console.WriteLine($"검색할 값 : {target}");
            //Console.WriteLine(index >= 0 ? $"인덱스를 찾았습니다! {index}" : "찾지 못했습니다.");


            //그룹화하기 : GROUP 알고리즘
            //데이터를 특정 기준으로 그룹화하기
            //// 문자열 배열 선언 (과일 이름 리스트)
            //string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };
            //// LINQ의 GroupBy()를 사용하여 첫 글자를 기준으로 그룹화
            //var groups = fruits.GroupBy(f => f[0]); //첫 글자로 그룹화
            //                                        // 각 그룹을 순회하며 출력
            //foreach (var group in groups)
            //{
            //    // 그룹의 Key (첫 글자) 출력
            //    Console.WriteLine($"Key : {group.Key}");
            //    // 해당 그룹에 속한 모든 요소 출력
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($" {item}");
            //    }

            //}

        }
    }
}
