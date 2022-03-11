using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Hammer : Weapon
    {
        public Hammer(string name, int damage, int durability, int maxDurability) : 
        base(name, damage, durability, maxDurability)
        {
        }
    }
}
