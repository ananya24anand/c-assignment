namespace Tutorial
{
    internal class Program
    {
        public static int threeNumMultiplication(int num1, int num2, int num3)
        {
            int result = num1 * num2 * num3;
            return result;
        }

        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int res;

            Console.WriteLine("Enter the 3 numbers : ");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());


            res = threeNumMultiplication(num1, num2, num3); 

            Console.WriteLine($"Multiplication result is {res}");
        }
    }
}