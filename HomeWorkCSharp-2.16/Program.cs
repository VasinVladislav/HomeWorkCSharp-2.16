using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.16. Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.
            Console.WriteLine("Программа для вычисления площади боковой поверхности и объёма прямоугольного параллелепипеда по длинам его сторон.");
        imputA:
            Console.Write("Введите длину стороны \"a\": ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
            imputB:
                Console.Write("Введите длину стороны \"b\": ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b > 0)
                {
                imputH:
                    Console.Write("Введите длину стороны \"h\": ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    if (h > 0)
                    {
                        double V = a * b * h;
                        double S = 2 * h * (a + b);
                        Console.WriteLine($"Объём прямоугольного параллелепипеда равен: {V}\nПлощадь боковой поверхности прямоугольного параллелепипеда равна: {S}");
                        return;
                    }
                    Console.WriteLine("Введено неверное значение");
                    goto imputH;
                }
                Console.WriteLine("Введено неверное значение");
                goto imputB;
            }
            Console.WriteLine("Введено неверное значение");
            goto imputA;
        }
    }
}
