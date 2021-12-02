using System;
using System.Collections.Generic;

namespace DemoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior fluffy = new Warrior("Fluffy");
            fluffy.showStats();
            Mage son = new Mage("Son of Anton");
            son.showStats();
            son.castSpell("fireball");
            Warlock zorbo = new Warlock("Zorbo");
            List<Character> allCharacters = new List<Character>();
            allCharacters.Add(fluffy);
            allCharacters.Add(son);
            allCharacters.Add(zorbo);
            List<ICastMagic> allMagicUsers = new List<ICastMagic>();
            allMagicUsers.Add(son);
            allMagicUsers.Add(zorbo)
        }
    }
}
