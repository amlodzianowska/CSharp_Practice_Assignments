using System;
using System.Collections.Generic;

namespace HungryNinja
{
class Ninja
    {
        private int calorieIntake;

        public bool isFull
        {
            get
            {
                if (calorieIntake < 1200)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public Ninja()
        {
            calorieIntake = 0;
        }
        public void Eat(Food item)
        {
            if (!isFull)
            {
                calorieIntake += item.Calories;
                Console.WriteLine($"Ninja ate {item.Name}, it had {item.Calories}");
            }
            else
            {
                Console.WriteLine("Ninja is full, no more food!");
            }
        }

        public void ateSoFar()
        {
            Console.WriteLine($"Ninja ate {calorieIntake} in total.");
        }
    }


}