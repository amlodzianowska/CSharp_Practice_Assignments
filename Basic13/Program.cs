using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] {-1,20,-3,4,5};
            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(nums);
            FindMax(nums);
            GetAverage(nums);
            OddArray();
            Console.WriteLine(GreaterThanY(nums, 3));
            SquareArrayValues(nums);
            EliminateNegatives(nums);
            MinMaxAverage(nums);
            ShiftValues(nums);
            NumToString(nums);
        }

        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i =1; i <=255; i++)
            {
                Console.Write(i);
            }
        }

        public static void PrintOdds()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i<=255; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i<=255; i++)
            {
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i<numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int average = sum/numbers.Length;
            Console.WriteLine("Average: " + average);
        }
        public static void OddArray()
        {
            int[] arr = new int[255/2];
            int j = 0;
            for (int i = 1; i<=10; i++)
            {
                if (i%2==1)
                {
                    arr[j] = i;
                    j++;
                }
            }
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int number = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    number++;
                }
            }
            return number;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = numbers[i]*numbers[i];
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];

                if (min > numbers[i])
                {
                    min = numbers[i];
                }

                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            int average = sum/numbers.Length;
            Console.WriteLine("Min: " + min + " Max: " + max + " Average: "+ average);
        }

        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i<numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    numbers[i] = 0;
                }
                else
                {
                numbers[i] = numbers[i+1];
                }
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] arr = new object[numbers.Length];
            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    arr[i] = "Dojo";
                }
                else 
                {
                    arr[i] = numbers[i];
                }
            }
            return arr;
        }

    }
}
