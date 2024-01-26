using System;

namespace NumberDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the low number: ");
            int l_number = int.Parse(Console.ReadLine());

            Console.Write("Enter the high number: ");
            int h_number = int.Parse(Console.ReadLine());

            int difference = h_number - l_number;
            Console.WriteLine($"The difference between {l_number} and {h_number} is: {difference}");

            Console.ReadLine();
        }
    }
}