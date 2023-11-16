using System;


namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;
            Console.WriteLine("Enter the first number:");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number ");
            thirdValue = double.Parse(Console.ReadLine());
            double sumRusult = firstValue + secondValue + thirdValue;
            double multResult = firstValue * secondValue * thirdValue;
            Console.WriteLine("Summation result : " + sumRusult);
            Console.WriteLine("Multiplication result: " + multResult);
            Console.ReadLine();
        }
    }
}
