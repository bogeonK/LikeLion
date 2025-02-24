using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 이진수를 변수로 변환
            //Console.Write("2진수를 입력하세요:");
            //string binartInput = Console.ReadLine(); // 문자열 입력받디
            //int decimalValue = Convert.ToInt32(binartInput, 2); // 2진수 -> 10진수 변환

            //// 정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수
            //Console.WriteLine($"입력한 이진수 {binartInput}");
            //Console.WriteLine($"10진수로 변환 {decimalValue}");
            //Console.WriteLine($"다시 2진수로 변환 {binaryOutput}");
            //컨트롤 + k + c       u
            //컨트롤 쉬프트 + /

            //var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25;   //정수로 추론
            //var inStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이: {age}, 학생 여부: {inStudent}");

            //default 키워드 사용한 기본값 설정
            //int defaultInt = default; //기본값 0 
            //string defaultString = default; //기본값 : null
            //bool defaultBool = default; //기본값 : false

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");


            //int a = 5, b = 3;
            //int sum = 0;

            //sum = a + b; //산술 연산자 사용

            //Console.WriteLine($"합 : {sum}"); //출력 : 8

           
            bool isEqual = false; // 거짓 0
            int a = 5;
            int b = 2;

            //관계형 연산자
            isEqual = (a == b); //a랑 b가 같은가?
            Console.WriteLine("같은가? " + isEqual);

        }
    }
}
