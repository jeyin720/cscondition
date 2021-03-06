﻿using System;
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
            Console.WriteLine("숫자 입력: ");
            var input = int.Parse(Console.ReadLine());

            /*
            if (input % 2 == 0)
            {
                Console.WriteLine("짝수 입니다!");
            }
            if(input %2==1)
            {
                Console.WriteLine("홀수 입니다!");
            }
            */

            /*
            switch(input%2)
            {
                case 0:
                    Console.WriteLine("짝수 입니다!");
                    break;
                case 1:
                    Console.WriteLine("홀수 입니다!");
                    break;
            }
            */

            Console.WriteLine(input % 2 == 0 ? "짝수입니다" : "홀수입니다");


            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            if(DateTime.Now.Hour<11)
            {
                Console.WriteLine("오전입니다");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다");
            }

            Console.Write("이번 달은 몇 월인가요: ");
            int month = int.Parse(Console.ReadLine());
            switch(month)
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
                default:
                    Console.WriteLine("어디 사니?");
                    break;
            }

            ConsoleKeyInfo info = Console.ReadKey();
            switch(info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로이동");
                    break;
            }
        }
    }
}
