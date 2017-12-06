using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
             SecondTask();
             ThirdTask();
             FourthTask();
            FifthTask();
             SexthTask();
             SevethTask();
            //EighthTask();
            
        }

        //private static void EighthTask()
        //{
        //    bool x, y;
           
        //}

        private static void SevethTask()
        {
            int number = 456;
            int x = number/100 *100 + number %10 *10 + number /10 %10;
            Console.WriteLine(x + " Первоначальное число х");


        }

        private static void SexthTask()
        {
            Console.WriteLine("Введите четырехзначное число:");
            int number = int.Parse(Console.ReadLine());
            int sum = number / 1000 + number / 100 % 10 + number / 10 % 10 + number % 10;
            Console.WriteLine(sum + " -Cумма его цифр");
            int proiz = (number / 1000) * (number / 100 % 10) * (number / 10 % 10) * (number % 10);
            Console.WriteLine(proiz + " -Произведение его цифр");

        }

        private static void FifthTask()
        {
            Console.WriteLine("Введите двухзначное число:");
            int number = int.Parse(Console.ReadLine());
            int a = number / 10;
            Console.WriteLine(a + " -Число десятков");
            int b = number % 10;
            Console.WriteLine(b + " -Число единиц");
            int sum = a + b;
            Console.WriteLine(sum + " -Cумма его цифр");
            int proiz = a * b;
            Console.WriteLine(proiz + " -Произведение его цифр");
            
        }

        private static void FourthTask()
        {
            int someDay = 234;
            int oneWeek = 7;
            int week = someDay / oneWeek;
            Console.WriteLine(week + " полных недель прошло за 234 дня.");
        }

        private static void ThirdTask()
        {
            Console.WriteLine("Введите расстояние в сантиметрах");
            int sm = int.Parse(Console.ReadLine());
            const int metr1 = 100;
            int metr = sm / metr1;
            Console.WriteLine("Полное кол-во метров: " + metr);
        }

        private static void SecondTask()
        {
            Console.WriteLine("Введите радиус окружности");
            float r = float.Parse(Console.ReadLine());
            float d = r * 2;
            var C = d * Math.PI;
            Console.WriteLine("Длина окружности равна: " + C);
            var S = Math.PI * Math.Pow(r, r);
            Console.WriteLine("Площадь круга равна: " + S);
        }

        private static void FirstTask()
        {
            string data = "Введите значение х: ";
            Console.WriteLine(data);
            int x = int.Parse(Console.ReadLine());
            var y = 7 * x * x - 3 * x + 4;
            Console.WriteLine("значения функции y=7x^2-3x+4 = " + y);
           
        }
    }
}
