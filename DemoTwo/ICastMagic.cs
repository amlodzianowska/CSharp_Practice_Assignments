using System;

namespace DemoTwo
{
    interface ICastMagic
    {
        //in interfaces these shouldn't be redular fields, instead we make them "autoimplemented properties"
        public int mana {get;set;}
        public void castSpell(string move);
    }
}