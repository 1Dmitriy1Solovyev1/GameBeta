using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Chestplate : Armor
    {
        public Chestplate(string name, int durability, int maxDurability, bool explodeImmunity) : 
        base(name, durability, maxDurability)
        {
            ExplodeImmunity = explodeImmunity;
        }

        public bool ExplodeImmunity { get; set; }
    }
}
