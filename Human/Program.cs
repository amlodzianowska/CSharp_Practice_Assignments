using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja p1 = new Ninja("Elon");
            Wizard p2 = new Wizard("Musk");
            Samurai p3 = new Samurai("Fluffy");
            p1.Attack(p2);
            p3.Attack(p1);
            p2.Attack(p3);
            p3.Meditate();
            p1.Steal(p2);
            
        }
    }
}
