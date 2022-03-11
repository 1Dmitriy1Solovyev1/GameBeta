using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal abstract class Player : Unit, IAction
    {
        public Player(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
        }

        public Weapon WeaponSlot1 { get; set; }
        public Chestplate BodySlot { get; set; }
        public Helmet HelmetSlot { get; set; }

        public abstract void GetStartInventory();

        new public void Cure(int treatment)
        {
            if (Health >= MaxHealth)
            {
                Health = MaxHealth;
                Console.WriteLine("Вы здоровы!");
            }
            else
            {
                Health += treatment;

                if(Health > MaxHealth)
                {
                    Health = MaxHealth;

                    Console.WriteLine("Вы полностью выздоровели!");
                }

                Console.WriteLine("Вы попросили противника подождать и перевязали свои раны");
            }
        }

        public void AskLowHP()
        {
            int answer;

            //Тестовая реализация сообщения о скорой смерти и предложения вылечиться
            if (Health < Health * 0.3)
            {
                Console.WriteLine("Осталось мало здоровья! Хотите принять лекарство?" +
                    "\n1. - Да" +
                    "\n2. - Нет");

                answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    //Логика лечения
                }
                else if (answer == 2)
                {
                    Console.WriteLine("Чтож, тогда удачи");
                }
                else
                {
                    Warning.ShowWarning();
                }

                Console.Clear();
            }
        }

        public void Destroy(int allDamage, Enemies currentEnemy)
        {
            if (Health <= 0)
            {
                Console.WriteLine("Вы умерли" +
                $"\nВы нанесли {allDamage} урона за всю игру." +
                $"\nВас убил {currentEnemy.Name}" +
                $"\nОружием {currentEnemy.WeaponSlot1}");

                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();

                Environment.Exit(0);
            }
        }

        new public int GetDamage(int damage)
        {
            Health -= damage;
            return Health;
        }

        public void ShowInventory(Unit obj)
        {
            Console.WriteLine($"Оружие в правой руке - {WeaponSlot1}");
            Console.WriteLine($"Броня на теле - {BodySlot}");
            Console.WriteLine($"Шлем - {HelmetSlot}");

            foreach (Loot items in obj.Inventory)
            {
                Console.WriteLine(items);
            }
        }

        public override string ToString()
        {
            return $"Вы - {Name}\n Здоровье = {Health}\n";
        }
    }
}
