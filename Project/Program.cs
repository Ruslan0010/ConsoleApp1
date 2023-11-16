using System;


namespace Project_1
{
     class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            Console.WriteLine("Enter the first number:");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            secondValue = double.Parse(Console.ReadLine());
            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("The result of the sum of two numbers : " +  result);
            Console.ReadLine();
        }
    }
}
