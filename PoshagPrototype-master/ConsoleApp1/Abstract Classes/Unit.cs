using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактынй класс описывающий бойцов
    /// </summary>
    internal abstract class Unit : IAction
    {
        public Unit(string name, int health, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;

            if (health > maxHealth)
            {
                Health = maxHealth;
            }
            else
            {
                Health = health;
            }
        }

        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество здоровья
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// Максимальное кол-во здоровья
        /// </summary>
        public int MaxHealth { get; set; }

        /// <summary>
        /// Инвентарь персонажа
        /// </summary>
        public List<Loot> Inventory { get; set; }

        public void Destroy()
        {
            if (Health <= 0)
            {
                Console.WriteLine("Противник погиб!");
            }
        }

        public int GetDamage(int damage)
        {
            Health -= damage;
            return Health;
        }

        public void Cure(int treatment)
        {
            if (Health >= MaxHealth)
            {
                Console.WriteLine("У противника полное здоровье!");
                Health = MaxHealth;
            }
            else
            {
                Health += treatment;
            }
        }

        public override string ToString()
        {
            return $"Юнит - {Name}\nЗдоровье = {Health}\n";
        }
    }
}