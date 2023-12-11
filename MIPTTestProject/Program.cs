using System;

namespace MIPTTestProject
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            string str = Console.ReadLine();
            int i;
            bool result = int.TryParse(str, out i);

            string st = Console.ReadLine();
            int j;
            bool resultj = int.TryParse(st, out j);
            
            int sum = calculator.Sum(i , j);

            Console.WriteLine("Our sum is");
            Console.WriteLine(sum);
            

            int diff = calculator.Diff(i, j);

            Console.WriteLine("Our difference is");
            Console.WriteLine(diff);
            

            int multipl = calculator.Multiply(i, j);

            Console.WriteLine("Our multiply is");
            Console.WriteLine(multipl);

            int sub = calculator.Subtract(i, j);

            Console.WriteLine("Our subtract is");
            Console.WriteLine(sub);
            Console.ReadLine();

        }
    }
}
