using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class assign4
    {
        static void Main()
        {
            Console.WriteLine("Enter a string : ");

            string sentence = Console.ReadLine();
            int count = 0;

            foreach (char c in sentence)
            {
               
                if (c != ' ' || c != '\n' || c != '\t')
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("The number of words is: " + count.ToString());
        }
    }
}
