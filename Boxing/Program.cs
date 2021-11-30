using System;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Boxing();
        }

        static void Boxing()
        {
            List<object> box = new List<object>();
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");
            int sum = 0;
            foreach (object item in box)
            {
                Console.WriteLine(item);
                if (item is int)
                {
                    int num = (int)item;
                    sum = sum + num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
