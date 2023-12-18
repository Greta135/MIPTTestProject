using System;
using System.ComponentModel.Design;

namespace MIPTTestProject
{
    internal class Program_massive

    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число");
            string str = Console.ReadLine();
            int N;
            bool result = int.TryParse(str, out N);
            if (result == false) { return; }
            int[] x = new int[N];

            for (int i = 0; i < x.Length; i++)
            {
                int n = i + 1;
                Console.WriteLine("Введите число номер " + n + ":");
                x[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("\n Итоговый Массив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0:N} ", x[i]);
            }

            Console.Write("\n Конец просмотра массива");
            Console.ReadKey();


        }
    }
}
