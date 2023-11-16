using System;


namespace Project_3
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) 
            {
                Console.WriteLine("It's an even number");
            }
            else 
            {
                Console.WriteLine("It's an odd number");
            }
            Console.ReadLine(); 
        }
    }
}
