using System;
using Lib;

namespace App
{
    class Program
    {
        static void Main()
        {
            var calculator = new FizzBuzzPopCalculator();
            string[] results = calculator.GenerateValues();
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
