using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace study21
{
    //class Person
    //{
    //    private string name; // 내부 변수 (main함수에서 쓸 수 없음)

    //    //값 설정하기(Setter)
    //    public void SetName(string newName)
    //    {
    //        name = newName;
    //    }

    //    //값 가져오기 (Getter)
    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}

    //class Person
    //{
    //    private string name; // 내부 변수 (main함수에서 쓸 수 없음)

    //    public string Name // 프로퍼티
    //    {
    //        get { return name; } // Getter
    //        set { name = value; } // Setter
    //    }

    //}


    ////프로퍼티 자동 구현
    //class Person
    //{
    //    private int count = 100;
    //    public string Name { get; set; }    // 자동 구현 프로퍼티

    //    public int Count
    //    {
    //        get { return count; } // 읽기만 가능
    //    }

    //    public float Balance { get; private set; } //외부 변경 불가

    //    public void AddBal()
    //    {
    //        Balance += 100;
    //    }
    //}

    //프로퍼티 자동 구현
    class Marin
    {
        public string Name { get; set; }    // 자동 구현 프로퍼티
        public int Mineral { get; set; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            //c#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드)또는
            //**프로퍼티(Property)**를 사용할 수 있음
            Marin p = new Marin();
            p.Name= "마린";
            p.Mineral = 50;
            
            Console.WriteLine("이름 : " + p.Name + " 미네랄 : " + p.Mineral);
        }
    }
}
