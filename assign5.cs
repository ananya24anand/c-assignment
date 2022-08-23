using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class assign5
    {
        public static string first_last(string ustr)
        {
           int len = ustr.Length;
            return ustr[len - 1] + ustr.Substring(1, len - 2) + ustr[0];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string ustr = first_last(Console.ReadLine());
            Console.WriteLine($"new String: {ustr}");

        }
       
    }
}