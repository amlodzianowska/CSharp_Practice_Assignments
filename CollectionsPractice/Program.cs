using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BasicArrays();
            ListOfFlavors();
            UserInfoDictionary();
        }
        
        public static void BasicArrays()
        {
            //Create an array to hold integer values 0 through 9
            int[] numArray = new int[10];
            for (int i = 1; i < numArray.Length; i++)
            {
                numArray[i] = i;
            }

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};

            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[10];
            for (int i = 0; i < boolArray.Length; i++)
            {
                if (i%2==0)
                {
                    boolArray[i]=true;
                }
            }
            foreach (bool val in boolArray)
            {
                Console.WriteLine(val);
            }
        }
        public static void ListOfFlavors()
        {
            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("strawberry");
            flavors.Add("coconut");
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("pecan");

            Console.WriteLine($"There are {flavors.Count} ice cream flavors.");
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine($"There are {flavors.Count} ice cream flavors now.");
        }

        public static void UserInfoDictionary()
        {
            //Create a dictionary that will store both string keys as well as string values
            string[] nameArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            List<string> flavors = new List<string>();
            Random rand = new Random();
            flavors.Add("strawberry");
            flavors.Add("coconut");
            flavors.Add("chocolate");
            flavors.Add("vanilla");
            flavors.Add("pecan");
            Dictionary<string,string> user = new Dictionary<string,string>();
            for (int i = 0; i < nameArray.Length; i++)
            {
                user.Add(nameArray[i], flavors[rand.Next(flavors.Count)]);
            }
            foreach (KeyValuePair<string,string> entry in user)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }

    }
}
