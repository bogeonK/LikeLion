using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study18
{ 
    //struct Point
    //{
    //    public int x;
    //    public int y;

    //}

    struct Score
    {
        public string name;
        public int kor;
        public int eng;
        public int math;


    }

    class Program
    {
        static void Main(string[] args)
        {
            Score[] score = new Score[3];
            
            for(int i=0; i<3; i++)
            {
                Console.Write("이름 : ");
                score[i].name = Console.ReadLine();
                Console.Write("국어 : ");
                score[i].kor = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                score[i].eng = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                score[i].math = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("이름       국어       영어       수학");
            for (int i=0; i<3; i++)
            {
                Console.WriteLine($"{score[i].name}       {score[i].kor}       {score[i].eng}       {score[i].math}");
            }


            //Point[] points = new Point[2];

            //points[0].x = 10;
            //points[0].y = 10;

            //points[1].x = 20;
            //points[1].y = 20;

            //foreach(var point in points)
            //{
            //    Console.WriteLine($"Point: ({point.x}),({point.y})");
            //}


            //구조체를 이용해서 
            //학생 3명의 이름 성적을 받고 국어, 영어, 수학
            //출력하시오
            //이름        국어      영어      수학
            //홍길동       100       80        70
            //홍길란        90       10        20
            //홍길순        20       55        70


        }
    }
}
