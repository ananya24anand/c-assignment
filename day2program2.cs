using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class day2program2
    {
        public static void MinMax(int a, int b, out int MinNum)
        {
            
            MinNum = Math.Min(a,b);

        }

        public static void Main()
        {
            Console.WriteLine("Enter 2 numbers : ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int MinNum;

            MinMax(n1, n2, out MinNum);

            Console.WriteLine($"The minimum number is {MinNum}" );
        }
    }
}
