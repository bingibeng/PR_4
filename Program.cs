using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args)// точка входа в программу
        {
            Console.Title = "Практическая работа № 4";

            double a, b, Y; // объявление переменных
            double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11;

            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите a = "); // ввод исходных данных
            a = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double
            Console.Write("Введите b = "); // ввод исходных данных
            b = Convert.ToDouble(Console.ReadLine()); // явное приведение к типу double

            // расчет значения выражения
            v1 = Math.Sqrt(a * b) + a;
            v2 = Math.Sqrt(Math.Pow(a, 2) + (a * b));
            v3 = v1 / v2;
            v4 = Math.Sqrt(Math.Pow(b, 2) + (a * b));
            v5 = Math.Sqrt(a * b) + b;
            v6 = v4 / v5;
            v7 = v3 - v6;
            v8 = Math.Pow(v7, -2);
            v9 = Math.Sqrt(Math.Pow(a, 3) * b) + Math.Sqrt(Math.Pow(b, 3) * a);
            v10 = 2 * a * b;
            v11 = v9 / v10;

            Y = v8 - v11;

            // вывод результата на экран
            Console.WriteLine("Результат: Y = {0: #.#####}", Y);
            Console.ReadKey(); // задержка экрана консоли
        }
    }
}
