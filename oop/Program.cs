using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(3, -5);
            Fraction b = new Fraction(3, 5);
            Fraction c = new Fraction(3, 1);
            Fraction d = new Fraction(3.1);
            Fraction e = new Fraction(3.1, 3.4);
            Fraction f = new Fraction(3.7, -3.3);
            Fraction res = a * b;
            //double res_double = res;
            if (a == b)
                Console.WriteLine("Дроби рівні");
            if (a != b)
                Console.WriteLine("Дроби нерівні");
            if (a > b)
                Console.WriteLine("Перший дріб більший за Другий");
            if (a < b)
                Console.WriteLine("Перший дріб менший за Другий");
            if (a >= b)
                Console.WriteLine("Перший дріб більший за Другий або рівний йому");
            if (a <= b)
                Console.WriteLine("Перший дріб менший за Другий або рівний йому");
            Console.WriteLine(res);
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"4 * d = {4 * d}");
            Console.WriteLine($"a > b = {a > b}");
            Console.WriteLine($"a < b = {a < b}");
            Console.WriteLine($"a >= b = {a >= b}");
            Console.WriteLine($"a <= b = {a <= b}");
            Console.WriteLine($"a == b = {a == b}");
            Console.WriteLine($"a != b = {a != b}");
            Console.WriteLine($"a + c = {a + c}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"2 * a = {2 * a}");
            Console.WriteLine($"e / d = {e / d}");
            Console.WriteLine($"2 <= c = {2 <= c}");
            Console.WriteLine($"a != 2.4 = {a != 2.4}");
            Console.WriteLine($"1 > b = {1 > b}");
            Console.WriteLine($"1 < b = {1 < c}");

            Console.ReadKey();
        }
    }
}
