using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype 
{
    internal class Sword : Weapon
    {
        public Sword(string name, string material, int damage, int durability, int maxDurability) : 
        base(name, damage, durability, maxDurability)
        {
            Material = material;
        }

        public string Material { get; set; }

        public override string ToString()
        {
            return $"{Material} {Name}\n Урон - {Damage}\n Состояние - {Durability}\n";
        }
    }
}
