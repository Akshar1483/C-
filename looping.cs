using System;

namespace NumberDifferenceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int l_number;

            do
            {
                Console.Write("Enter a positive low number: ");
                l_number = int.Parse(Console.ReadLine());

                if (l_number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }

            } while (l_number <= 0);

            int h_number;

            do
            {
                Console.Write("Enter a high number greater than the low number: ");
                h_number = int.Parse(Console.ReadLine());

                if (h_number <= l_number)
                {
                    Console.WriteLine("Invalid input. Please enter a number greater than the low number.");
                }

            } while (h_number <= l_number);

            int difference = h_number - l_number;
            Console.WriteLine($"The difference between {l_number} and {h_number} is: {difference}");

            Console.ReadLine();
        }
    }
}
