using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class PlayerHuman : Player, IAction
    {
        public PlayerHuman(string name, int health, int maxHealth) : base(name, health, maxHealth)
        {
            if (name == "")
            {
                Name = GetName();
            }
        }

        public Weapon WeaponSlot2 { get; set; }

        string GetName()
        {
            Random random = new Random();

            string[] names = { "Genoa", "Tiv", "Peep", "Hagalbar", "Talis", "Antia" };

            string name = names[random.Next(0, names.Length)];

            return name;
        }

        public void ShowInventoryMenu()
        {
            while (true)
            {
                int answer = -1;

                Console.Clear();

                Console.WriteLine(ToString());
                Console.WriteLine($"Оружие в правой руке - {WeaponSlot1}");
                Console.WriteLine($"Оружие в левой руке - {WeaponSlot2}");
                Console.WriteLine($"Броня на теле - {BodySlot}");
                Console.WriteLine($"Шлем - {HelmetSlot}");

                Console.WriteLine("--------------");
                foreach (ILoot items in Inventory)
                {
                    Console.WriteLine(items);
                }
                Console.WriteLine("--------------");

                Console.WriteLine("Что вы хотите сделать?" +
                    "\n1. Поместить оружие в слот" +
                    "\n2. Поместить броню в слот" +
                    "\n3. Подлечиться (+15 хп)" +
                    "\n4. Вернуться в бой");

                answer = MainMenu.InitAndCheckAsw();

                switch(answer)
                {
                    case 1:
                        //Поместить оружие в выбранный слот
                        break;
                    case 2:
                        //Поместить броню в выбранный слот
                        break;
                    case 3:
                        Cure(15);
                        break;
                }

                if(answer == 4)
                {
                    break;
                }
            }
        }

        private void ChoiceWeapon()
        {
            Console.Clear();

            int answer = -1;

            foreach (Loot items in Inventory)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("1. Выберите оружие из инвентаря...");

            answer = MainMenu.InitAndCheckAsw();

            if(answer != -1)
            {

            }
        }

        /// <summary>
        /// Выдает начальное снаряжение выбранному игроку
        /// Создаёт инвентарь
        /// </summary>
        public override void GetStartInventory()
        {
            Inventory = new List<Loot>();

            WeaponSlot1 = new Sword("Меч", "Стальной", 7, 25, 30);
            WeaponSlot2 = new Sword("Меч", "Старый ржавый", 5, 10, 10);
            BodySlot = new Chestplate("Балахон", 10, 14, false);
            HelmetSlot = new Helmet("Повязка на голову", 4, 5); 
        }

        public override string ToString()
        {
            return $"Вы человек - {Name}\n Здоровье = {Health}\n";
        }
    }
}
