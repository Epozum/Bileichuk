using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr9
{

    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(7);
            Fraction b = new Fraction(5);
            Console.WriteLine($"a = {a.get_digit()}");
            Console.WriteLine($"b = {b.get_digit()}");

            Console.WriteLine($"a + b = {a + b}");

            Console.WriteLine($"a - b = {a - b}");

            Console.WriteLine($"a * b = {a * b}");

            Console.WriteLine($"a / b = {a / b}");

            Console.WriteLine($"a > b = {a > b}");

            Console.WriteLine($"a >= b = {a >= b}");

            Console.WriteLine($"a < b = {a < b}");

            Console.WriteLine($"a <= b = {a <= b}");

            Console.WriteLine($"a == b = {a == b}");

            Console.WriteLine($"a != b = {a != b}");





            Console.ReadLine();
        }
    }
}