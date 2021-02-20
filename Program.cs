using System;

namespace Multiple_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count;

            for (count = 1; count <= number; count++)
            {
                if (count % 3 == 0)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine(count);
                }   
            }
         
            





           // number % 3 = 0 finding multiple of 3?
        }
    }
}
