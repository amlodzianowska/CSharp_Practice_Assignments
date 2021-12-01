using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human player = new Human("Elon");
            Human enemy = new Human("Musk");
            player.Attack(enemy);
            
        }
    }
}
