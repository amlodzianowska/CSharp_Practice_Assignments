using System;

namespace HungryNinja
{
    class Food
    {
    public string Name;
    public int Calories;
    // Foods can be Spicy and/or Sweet
    public bool IsSpicy; 
    public bool IsSweet;

    public Food(string name, int cal, bool spcy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spcy;
            IsSweet = sweet;
        }
    }
}