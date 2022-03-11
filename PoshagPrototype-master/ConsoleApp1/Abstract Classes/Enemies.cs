using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal abstract class Enemies : Unit
    {
        public Enemies(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                GetRandomName();
            }
        }

        public Weapon WeaponSlot1 { get; set; }

        new public void Destroy()
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} уничтожен!");
            }
        }

        public void GetEnemyItems(Player player)
        {
            int answer = -1;

            while (true)
            {
                Console.WriteLine("Подобрать лут?" +
                 $"\n{WeaponSlot1}" +
                 $"\n1. Да" +
                 $"\n2. Нет");

                try
                {
                    answer = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Warning.ShowWarning();
                    Console.Clear();
                }

                if (answer == 1)
                {
                    player.Inventory.Add(WeaponSlot1);

                    break;
                }
                if (answer == 2)
                {
                    break;
                }
            }
        }

        static string GetRandomName()
        {
            Random random = new Random();

            string[] names = { "Волк", "Лис", "Молодой бандит" };

            string randomName = names[random.Next(0, names.Length)];

            return randomName;
        }
    }
}
