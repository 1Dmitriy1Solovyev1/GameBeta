using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Helmet : Armor
    {
        public Helmet(string name, int durability, int maxDurability) : base(name, durability, maxDurability)
        {
        }
    }
}
