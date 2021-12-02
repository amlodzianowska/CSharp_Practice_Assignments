using System;
using System.Collections.Generic;

namespace HungryNinja
{
class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Carbonarra", 1000, false, false),
                new Food("Focaccia", 1150, false, false),
                new Food("Spaghetti Bolognese", 1200, false, false),
                new Food("Margheritta", 975, false, false),
                new Food("Panna Cotta", 540, false, true),
                new Food("Tiramisu", 450, false, true),
                new Food("Canestrelli", 600, false, true)
            };
        }

        public void showMenu()
        {
            foreach (Food f in Menu)
            {
                Console.WriteLine(f.Name);
            }
        }
        public Food Serve()
        {
            Random rand = new Random();
            int count = Menu.Count;
            return (Menu[rand.Next(count)]);
        }

        
        

    }
}


