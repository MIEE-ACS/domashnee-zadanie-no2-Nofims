using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Ввелите число х : ");
            double x = double.Parse(Console.ReadLine());


            if (x < -9)

            {
                Console.WriteLine($"Функция не определена в этом значении!");
            }


            else if (x >= -9 && x <= -7)
            {
                while (x <= -7)
                {
                    Console.WriteLine($"y = {0}  x={x}");
                    x += 0.2;
                }
               
            }
            else if (x > -7 && x <= -3)
            {
                while (x <= -3)
                {
                    double y = x + 7;
                    Console.WriteLine($"y = {y:.000}  x={x}");
                    x += 0.2;
                }
            }
            else if (x > -3 && x <= -2)
            {
                while (x <= -2)
                {

                    Console.WriteLine($"y = {4}  x={x}");
                    x += 0.2;
                }
            }
            else if (x > -2 && x <= 2)
            {
                while (x <= 2)
                {
                    double y = x * x;
                    Console.WriteLine($"y = {y:.000}  x={x}");
                    x += 0.2;
                }
            }
            else if (x > 2 && x <= 4)
            {
                while (x <= 4)
                {
                    double y = -2 * x + 8;
                    Console.WriteLine($"y = {y:.000}  x={x}");
                    x += 0.2;
                }
            }
            else if (x > 4 && x <= 7)
            {
                while (x <= 7)
                {
                    Console.WriteLine($"y = {0}  x={x}");
                    x += 0.2;
                }
            }
            if (x > 7 )

            {
                Console.WriteLine($"Функция не определена в этом значении!");
            }



            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных!");
            }


        }
    }
}

