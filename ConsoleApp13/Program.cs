using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        class Скорость
        {
            private double mc;
            public Скорость(double мс)
            {
                this.mc = мс;
            }
            public static implicit operator double(Скорость v)
            {
                return v.mc;
            }
            public static implicit operator int(Скорость v)
            {
                return (int)v.mc;
            }
        }
        static void Main(string[] args)
        {
            int sum1 = Add(2, 3);
            int sum2 = Add(2, 3, 4);
            double sum3 = Add(3.9, 4.1);
            Console.WriteLine("Результатом сложения является: {0}, {1}, {2}", sum1, sum2, sum3);
            pereg x = new pereg(211, 1);
            pereg y = new pereg(10, 8);
            pereg sum = x + y;
            Console.WriteLine("Перегрузка(сумма): " + sum);
            Скорость v1 = new Скорость(25);
            double Скоростьdou = v1;   //Это будет неявное преобразование типа
            Console.WriteLine("Скорость в метрах в секунду (double): " + Скоростьdou);
            int Скоростьint = (int)v1;   //Это будет явное преобразование типа
            Console.WriteLine("Скорость в метрах в секунду (int): " + Скоростьint);
            Console.ReadKey();
        }
        // Далее уже начнётся перегрузка методов
        static int Add(int a, int b)
        { return a + b; }
        static int Add(int a, int b, int c)
        { return a + b + c; }
        static double Add(double a, double b)
        { return a + b; }
        // На этом перегрузка методов закончилась
        // Перегрузка метода
        class pereg // Клас перегрузки
        {
            public int Q { get; set; }
            public int P { get; set; }
            public pereg(int q, int p)
            { Q = q; P = p; }
            public static pereg operator +(pereg x, pereg y)
            {
                return new pereg(x.Q + y.Q, x.P + y.P);
            }
            public override string ToString()
            {
                return $"({Q},{P})";
            }
        }
    }
}
