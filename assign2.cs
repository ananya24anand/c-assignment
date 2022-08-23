using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class assign2
    {
        static void Main()
        {
       

            Console.WriteLine("Enter 2 numbers : ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The minimum number is " + Math.Min(n1, n2));
        }
    }
}
