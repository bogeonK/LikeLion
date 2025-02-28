using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study20
{
    // 마린 클래스 만들기
    //이름, 미네랄 = 50
    //기본생성자, 인자있는 생성자

    class Marin
    {
        public string Name;
        public int Mineral;
        public Marin() //기본 생성자
        {
            Name = "마린";
            Mineral = 50;
        }
        public Marin(string _name, int _mineral) //인자있는 생성자
        {
            Name = _name;
            Mineral = _mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    // SCV 클래스 만들기
    //이름, 미네랄 = 50
    //기본생성자, 인자있는 생성자

    class SCV
    {
        public string Name;
        public int Mineral;
        public SCV() //기본 생성자
        {
            Name = "SCV";
            Mineral = 50;
        }
        public SCV(string _name, int _mineral) //인자있는 생성자
        {
            Name = _name;
            Mineral = _mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    //배럭클래스를 만드세요
    //Barrack 150
    //this 키워드를 이용해보자
    //this 자기자신을 가르킴
    class Barrack
    {
        public string Name;
        public int Mineral;

        public Barrack()
        {
            Name = "Barrack";
            Mineral = 150;
        }

        public Barrack(string Name, int Mineral) { 
            this.Name = Name;
            this.Mineral = Mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"건물이름 : {Name}  |  비용 : {Mineral}");
        }
    }

    //미네랄 클래스를 만드세요
    //Mineral 1500 기본으로 줌
    //7개가 시작부터 있음
    //클래스화

    //class Mineral
    //{
    //    public string Name;
    //    public int Basic;

    //    public Mineral()
    //    {
    //        Name = "미네랄";
    //        Basic = 1500;
            
    //    }

    //    public Mineral(string Name, int Basic)
    //    {
    //        this.Name = Name;
    //        this.Basic = Basic;
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"현재 미네랄 양 : {Basic}");
    //    }
    //}

    //class Person
    //{
    //    public string Name;
    //    public int Age;

    //    //기본 생성자
    //    //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
    //    //클래스와 같은 이름가지며, 반환형이 없음(void도 사용하지않음)
    //    //객체를 만들때 필요한 초기값을 설정할때 사용을 많이 한다.

    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //        Console.WriteLine("매개변수있는 생성자가 실행됨");
    //    }

    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"이름 : {Name}   | 나이 : {Age}");
    //    }
    //}

    
    // Game 클래스를 만들어보자
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral}  |  가스 : {gas}  |  인구수: {charCount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 클래스
            //
            //Person p1 = new Person("이름없음", 12); //객체 생성       instance
            //p1.ShowInfo();

            //Marin marin = new Marin();
            //SCV scv = new SCV();

            //Marin marin = new Marin("불꽃 테란", 50);
            //SCV scv = new SCV("일꾼", 50);

            //marin.ShowInfo();
            //scv.ShowInfo();

            //Barrack barrack = new Barrack();
            //barrack.ShowInfo();

            ////클래스의 배열
            //Mineral[] mineral = new Mineral[7];
            //for(int i=0; i<mineral.Length; i++)
            //{
            //    mineral[i] = new Mineral();
            //    mineral[i].ShowInfo();
            //}

            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();




        }
    }
}
