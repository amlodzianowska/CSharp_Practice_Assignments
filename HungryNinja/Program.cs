using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b1 = new Buffet();
            // b1.showMenu();
            b1.Serve();
            object dish = b1.Serve();
            Ninja n1 = new Ninja();
            n1.Eat(b1.Serve());
            n1.Eat(b1.Serve());
            n1.ateSoFar();
        }
    }
}
