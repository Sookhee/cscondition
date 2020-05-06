using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            // 홀수 짝수 구분하기
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다 :D");
            }
            else
            {
                Console.WriteLine("홀수 입니다 :D");
            }

            //현재 시간 구하기
            Console.WriteLine("Year : " + DateTime.Now.Year);
            Console.WriteLine("Month : " + DateTime.Now.Month);
            Console.WriteLine("Day : " + DateTime.Now.Day);
            Console.WriteLine("Hour : " + DateTime.Now.Hour);
            Console.WriteLine("Minute : " + DateTime.Now.Minute);
            Console.WriteLine("Second : " + DateTime.Now.Second);

            //오전과 오후 구분하기
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침밥 먹을 시간입니다!");
            }
            else if(DateTime.Now.Hour < 15)
            {
               Console.WriteLine("점심밥 먹을 시간입니다!");
            }
            else
            {
                Console.WriteLine("저녁밥 먹을 시간입니다!");
            }

            //switch 예제
            switch(input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다!");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다!");
                    break;
            }

            Console.Write("이번 달은 몇 월인가요? : ");
            int input2 = int.Parse(Console.ReadLine());
            switch (input2)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다");
                    break;

            }

            //삼항연산자
            Console.WriteLine(input > 0 ? "자연수입니다" : "자연수가 아닙니다");
            Console.WriteLine(input % 2 == 0 ? "짝수입니다" : "홀수입니다");

            //조건문 조건에 메서드 사용하기

            //Contains
            Console.WriteLine("COM : 안녕하세요^^? ");
            Console.Write("나 : ");
            String line = Console.ReadLine();
            if (line.Contains("안녕"))
            {
                Console.WriteLine("COM : 만나서 반가워요*^^*");
            }
            else
            {
                Console.WriteLine("COM : 인사 안해요? :(");
            }

            //Key

            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key) {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                default:
                    Console.WriteLine("잘못 누르셨습니다.");
                    //이 안에 switch문을 한번 더 쓸 수도 있음
                    break;
            }

            switch (info.KeyChar)
            {
                case (char)38:
                    Console.WriteLine("위로 이동");
                    break;
                case '가':
                    Console.WriteLine("가");
                    break;
            }

        }
    }
}
