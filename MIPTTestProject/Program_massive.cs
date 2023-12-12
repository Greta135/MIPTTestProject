using System;
using System.ComponentModel.Design;

namespace MIPTTestProject
{
    internal class Program_massive

    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите число номер один");
                x[i] = Convert.ToInt32(Console.ReadLine());
              
            }

            Console.Write("\nИтоговый Массив:");
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0:N} ", x[i]);
            }

            Console.Write("\n\nКонец просмотра массива");
            Console.ReadKey();

        }
    }
    }
