using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class MediumEnemy : Enemies
    {
        public MediumEnemy(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                Name = GetRandomName();
            }
        }

        static string GetRandomName()
        {
            Random random = new Random();

            string[] names = { "Гоблин", "Молодой бандит" };

            string randomName = names[random.Next(0, names.Length)];

            return randomName;
        }
    }
}
