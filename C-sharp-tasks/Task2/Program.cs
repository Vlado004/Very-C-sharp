using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 15;
            long number2 = long.MaxValue;

            try
            {
                number1 = checked(Convert.ToInt32(number2) + number1);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }

        }
    }
}