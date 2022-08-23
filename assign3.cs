using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class assign3
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string : ");

            string sentence = Console.ReadLine();
            string vowels = "aeiouAEIOU";
            int vowelCount = 0;

            for(int i=0; i<sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    ++vowelCount;
                }
            }
            Console.WriteLine("Number of vowels = " + vowelCount.ToString());
        }
    }
}
