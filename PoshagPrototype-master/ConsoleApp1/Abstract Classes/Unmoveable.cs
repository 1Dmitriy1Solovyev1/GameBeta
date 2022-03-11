using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal abstract class Unmoveable : Unit
    {
        public Unmoveable(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            
        }

        new public void Destroy()
        {
            Console.WriteLine($"{Name} разрушен(а)!");
        }

        public void GetLoot(Player player, Unmoveable prop)
        {

        }

        public override string ToString()
        {
            return $"{Name}\nОсталось прочности - {Health}\n";
        }
    }
}
