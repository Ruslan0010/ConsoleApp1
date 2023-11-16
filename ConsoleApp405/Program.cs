using System;


namespace Project_0
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToCad = 1.37;
            double UsdToUah = 36.31;
            double USD;
            Console.WriteLine("Enter the amount in U.S. dollars: ");
            USD = double.Parse(Console.ReadLine());
            Console.WriteLine(USD + "USD = " + USD * UsdToCad + "CAD");
            Console.WriteLine(USD + "USD = " + USD * UsdToUah + "UAH");
            Console.ReadLine();
        }
    }
}
