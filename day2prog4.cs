using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class day2prog4
    {
        public static int sumofdigit(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                int rem = number % 10;  
                sum = sum + rem;
                number /= 10;
            }
            return sum;
        }

        public static int reversing(int number)
        {
            int reverse = 0, rem;
            while( number > 0)
            {
                rem = number % 10;
                reverse = reverse*10 + rem;
                number /= 10;
            }

            return reverse;
        }

        public static double swapFirstLast(int number)
        {
            int temp, last, first, count = 0;
            double swap;
            temp = number;
            last = number % 10;
            count = (int)Math.Log10(temp);

            while(temp>=0)
            {
                temp /= 10;
            }
            first = temp;
            swap = (last*Math.Pow(10, count)+first) + (number -(first*Math.Pow(10, count)+last));

            return swap;
        }


        public static void Main()
        {
            int number, sum, rev; 
            double FirstLast;
            Console.WriteLine("Enter a Digit: ");
            number = Convert.ToInt32(Console.ReadLine());
            sum = sumofdigit(number);
            Console.WriteLine($"Sum of digit is: {sum}");
            rev = reversing(number);
            Console.WriteLine($"Reversed digit is: {rev}");
            FirstLast = swapFirstLast(number);
            Console.WriteLine($"After interchanging first and last number: {FirstLast}");
        }
    }
}
