using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            result();
            Console.ReadKey();
        }

        static void result()
        {
            Calc Calculator = new Calc();
            Console.WriteLine("Введите выражение:");
            string regul = Console.ReadLine();
            Console.WriteLine($"Результат: {Calculator.Calculate(regul)}");
            result();
        }
    }
}
