using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 4;
            // RandomArray();
            // CoinFlip();
            Console.WriteLine(TossMultipleCoins(num));
            // Names();
        }

        public static void RandomArray()
        {
            Random rand = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = rand.Next(5,26);
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public static string CoinFlip()
        {
            Random rand = new Random();
            string[] coin = new string[] {"Heads", "Tails"};
            string result = coin[rand.Next(2)];
            return result;
        }

        public static double TossMultipleCoins(int num)
        {
            int heads = 0;
            for (int i=0; i < num; i++)
            {
                string flip = CoinFlip();
                if (flip == "Heads")
                {
                    heads++;
                }
            }
            Console.WriteLine("This is heads: " + heads);
            Console.WriteLine("This is num: " + num);
            return (double)heads/num;
        }

        public static List<string> Names()
        {
            string[] names = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            List<string> namesList = new List<string>();
            foreach (string name in names)
            {
                int letterCount = 0;
                foreach (char letter in name)
                {
                    letterCount++;
                }
                if (letterCount > 5)
                {
                    namesList.Add(name);
                }
            }
            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }
            return namesList;
        }
    }
}
