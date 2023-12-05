using System;

namespace MIPTTestProject
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
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