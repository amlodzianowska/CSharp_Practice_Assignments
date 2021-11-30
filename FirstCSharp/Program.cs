using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            loop from 1 to 5 including 5
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("this is second loop");

            for (int i = 1; i <= 100; i++)
            {
            if (i%3==0 && i % 5==0)
            {
                continue;
            }

            else if (i%3==0 || i % 5==0)
            {
                Console.WriteLine(i);
            }
            }
            // Fizz buzz
            Console.WriteLine("=============== This is FizzBuzz==================");
            for (int i = 1; i <= 100; i++)
            {
            if (i%3==0 && i % 5==0)
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (i%3==0 )
            {
                Console.WriteLine("Fizz");
            }

            else if (i % 5==0)
            {
                Console.WriteLine("Buzz");
            }
            }

            int j = 1;
            Console.WriteLine("FizzBuzz using while loop");
            while (j<100)
            {
            if (j % 3==0 && j % 5==0)
            {
                Console.WriteLine("FizzBuzz");
            }

            else if (j%3==0 )
            {
                Console.WriteLine("Fizz");
            }

            else if (j % 5==0)
            {
                Console.WriteLine("Buzz");
            }
            j++;
            }

        }
    }
}
