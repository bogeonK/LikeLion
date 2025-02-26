using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열, 0부터시작한다

            //int[] num = new int[3]; //3개 메모리 만들겠다

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 3 }; //간단한 선언과 초기화, 공백원소일 시 0으로 채워야함
            //int[] numbers2 = new int[3]; //크기만 지정
            //int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언

            //for (int i=0; i < 3; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for(int i=0; i<3; i++)  //인덱스로 돌리기 때문에 int형 사용
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //3명의 국어,영어, 수학 점수를 입력받고 총점과 평균을 출력하세요
            //int[] kor = new int[3];
            //int[] eng = new int[3];
            //int[] math = new int[3];
            //int[] sum = new int[3];
            //float[] aver = new float[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("학생성적을 입력하세요 : ");

            //    Console.Write("국어 : ");
            //    kor[i] = int.Parse(Console.ReadLine());

            //    Console.Write("영어 : ");
            //    eng[i] = int.Parse(Console.ReadLine());

            //    Console.Write("수학 : ");
            //    math[i] = int.Parse(Console.ReadLine());

            //    sum[i] = kor[i] + eng[i] + math[i];
            //    aver[i] = (float)sum[i] / 3;
            //}

            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine($"{i+1}번학생");
            //    Console.WriteLine($"국어: {kor[i]} | 영어 : {eng[i]} | 수학 : {math[i]}");
            //    Console.WriteLine($"총점 : {sum[i]}  |  평균 : {aver[i].ToString("F2")}");
            //}

            //1차원 배열
            //int[] score = new int[3];
            //score[0] = 1;
            //score[1] = 2;
            //score[2] = 3;

            //for(int i=0; i<score.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}:{score[i]}");
            //}


            //double value = 123.456789;
            ////소수점 자릿수 설정하는 포맷
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점둘째자리 : {value:F2} ");
            //Console.WriteLine(String.Format("수소점 둘째 자리: {0:F2}", value));
            ////소수점 없이 정수 출력
            //Console.WriteLine(value.ToString("F0"));


            //double value = 123124124.12323;

            //Console.WriteLine(value.ToString("N2"));

            //2차원 배열 선언
            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < 2; i++)
            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] matrix = new int[2][];

            //matrix[0] = new int[3];
            //matrix[1] = new int[3];

            ////값 입력
            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;

            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;

            ////출력
            //for(int i = 0; i<matrix.Length; i++)
            //{
            //    for(int j=0; j< matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //가변 배열
            Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5};
            jaggedArray[2] = new int[] { 6 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");


        }
    }
}
