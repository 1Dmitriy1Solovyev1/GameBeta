using System;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Броня
    /// </summary>
    internal abstract class Armor : Loot, IAction
    {
        protected Armor(string name, int durability, int maxDurability)
        {
            Name = name;
            Durability = durability;
            MaxDurability = maxDurability;
        }

        public string Name { get; set; }
        public int MaxDurability { get; set; }
        public int Durability { get; set; }

        public void Cure(int treatment)
        {
            Durability += treatment;

            if (Durability > MaxDurability)
            {
                Durability = MaxDurability;

                Console.WriteLine("Броня и так блестит, ремонт не нужен!");
            }

            Console.WriteLine("Вы отремонтировали броню");
        }

        public int GetDamage(int damage)
        {
            return MaxDurability -= damage;
        }

        public void Destroy()
        {
            if (Durability <= 0)
            {
                Console.WriteLine("Броня сломалась!");
            }
        }

        public override string ToString()
        {
            return $"{Name}\n состояние - {Durability}\n";        
        }
    }
}