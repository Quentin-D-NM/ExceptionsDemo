using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            try
            {
                Console.WriteLine("Please enter num1: ");
                string num1str = Console.ReadLine();
                int num1 = int.Parse(num1str);

                Console.WriteLine("Please enter num2: ");
                string num2str = Console.ReadLine();
                int num2 = int.Parse(num2str);

                Console.WriteLine("Num1/Num2: {0}", num1 / num2);
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error!");
                Console.WriteLine("Its message is: " + e.Message);
                Console.WriteLine("Its StackTrace is: " + e.StackTrace);
                Console.WriteLine("Exception type: {0}", e.GetType());

            }

            Console.WriteLine("Goodbye!");
        }
    }
}
