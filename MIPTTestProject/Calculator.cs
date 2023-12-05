using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPTTestProject
{
    internal class Calculator
    {
        public int Sum(int i, int j) // i + j 
        {
            int sum_i_j = i + j;
            int sum = sum_i_j;
            return sum; 
        }
        public int Diff(int i, int j) // i - j 
        {
            int diff_i_j = i - j;
            int diff = diff_i_j;
            return diff;
        }
        public int Multiply(int i, int j) // i * j 
        {
            int multipl_i_j = i * j;
            int multipl = multipl_i_j;
            return multipl;
        }
        public int Subtract(int i, int j) // i / j 
        {
            int sub_i_j = i / j;
            int sub = sub_i_j;
            return sub;
        }
    }
}
