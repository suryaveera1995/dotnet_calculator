using System;
using consoleApp;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator add = new Calculator();
            var Total = add.Sum(5,4);
            Console.WriteLine(Total);

            var Difference = add.Diff(5,4);
            Console.WriteLine(Difference);

            var Division = add.Divi(4,2);
            Console.WriteLine(Division);

            var Multiplication = add.Mul(5,5);
            Console.WriteLine(Multiplication);
        }
    }
}
