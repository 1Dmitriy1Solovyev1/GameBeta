using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Barrel : Unmoveable
    {
        public Barrel(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
        }

        public void Explode(PlayerHuman obj)
        {
            if(!obj.BodySlot.ExplodeImmunity)
            {
                Random random = new Random();

                GetDamage(random.Next(5, 20));

                Console.WriteLine("А бочка была красная! Порох взорвался и отнял у вас здоровье");
            }
            else
            {
                Console.WriteLine("Броня защитила вас от взрыва, но поцарапалась");
            }
        }
    }
}
