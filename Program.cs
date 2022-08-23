namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int result;

            Console.WriteLine("Enter the 3 numbers : ");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());  
            num3 = int.Parse(Console.ReadLine());

            result = num1 * num2 * num3;

         
            Console.WriteLine("The multiplication result is " + result.ToString());

        }
    }
}