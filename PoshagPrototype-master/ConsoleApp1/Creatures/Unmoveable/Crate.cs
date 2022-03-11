using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Crate : Unmoveable
    {
        public Crate(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
        }
    }
}
