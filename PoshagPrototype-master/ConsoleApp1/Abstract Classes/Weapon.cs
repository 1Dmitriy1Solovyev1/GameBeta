using System;
using System.Collections.Generic;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Оружие
    /// </summary>
    internal abstract class Weapon : Loot, IAction
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public string Name { get; set; }

        protected Weapon(string name, int damage, int durability, int maxDurability)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            MaxDurability = maxDurability;

            if (Durability > MaxDurability)
            {
                Durability = MaxDurability;
            }
        }

        public void Cure(int treatment)
        {
            Durability += treatment;

            if(Durability > MaxDurability)
            {
                Durability = MaxDurability;

                Console.WriteLine("Оружие как новое!");
            }

            Console.WriteLine("Вы заточили оружие");
        }

        public int GetDamage(int damage)
        {
            Durability -= damage;
            return Durability;
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Name}\n Урон - {Damage}\n Состояние - {Durability}\n";
        }
    }
}