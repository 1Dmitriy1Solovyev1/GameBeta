using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class WeakEnemy : Enemies
    {
        public WeakEnemy(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                Name = GetRandomName();
            }
        }

        string GetRandomName()
        {
            Random random = new Random();

            string[] names = { "Гоблин", "Карлик" };

            string randomName = names[random.Next(0, names.Length)];

            return randomName;
        }
    }
}
