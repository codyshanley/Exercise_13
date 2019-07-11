using System;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = num; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }

                for (int j = 0; j <= num; j++)
                {
                    Console.WriteLine(j);
                }

                Console.Write("Would you like to continue? (y/n)");
                string cont = Console.ReadLine().ToLower();

                if (cont != "y")
                {
                    break;
                }
            }
        }
    }
}
