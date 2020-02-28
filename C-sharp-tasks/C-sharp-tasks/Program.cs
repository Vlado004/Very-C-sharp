using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1;
            double number2;

            Console.WriteLine("Enter the first number:");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter the first number:");
            }

            Console.WriteLine("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Enter the second number:");
            }

            double result;
            try
            {
                result = number1 / number2;
            } catch(DivideByZeroException)
            {
                return;
            }

            int resultInInt;
            try
            {
                resultInInt = checked(Convert.ToInt32(result));
            } catch(System.OverflowException)
            {
                Console.WriteLine("Result is too large or too small");
                return;
            }

            Console.WriteLine(result.ToString("C"));
            Console.WriteLine(Convert.ToInt32(result));
            Console.WriteLine(result.ToString("E2"));
            Console.WriteLine(result.ToString("F"));
            Console.WriteLine(result.ToString("G"));
            Console.WriteLine(result.ToString("N"));
            Console.WriteLine(Convert.ToInt32(result).ToString("X"));
        }
    }
}