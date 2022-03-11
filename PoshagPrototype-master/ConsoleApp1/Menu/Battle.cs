using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Battle
    {
        //Метод, в котором описывается процесс битвы с персонажем-человеком
        public static void Fight(PlayerHuman player)
        {
            int countOfDamage = 0;

            Enemies[] enemies = new Enemies[5];

            int numOfEnemy = enemies.Length - 1;

            Random random = new Random();

            //Заполнение массива врагами рандомного типа
            FillUnitArray(enemies, enemies.Length, random.Next(0, 2));

            while (numOfEnemy != -1)
            {
                int answer = -1;

                Console.WriteLine(player);
                Console.WriteLine(enemies[numOfEnemy]);
                Console.WriteLine("Сделайте выбор\n" +
                    "1. Ударить\n" +
                    "2. Открыть инвентарь\n" +
                    "3. Выйти из игры");

                answer = MainMenu.InitAndCheckAsw();

                switch (answer)
                {
                    case 1:
                        if (player.WeaponSlot1.Durability > 0)
                        {
                            countOfDamage += player.WeaponSlot1.Damage;
                            enemies[numOfEnemy].GetDamage(player.WeaponSlot1.Damage);
                        }
                        else
                        {
                            Console.WriteLine("Оружие в правой руке сломалось! Замените его");
                        }

                        if (player.WeaponSlot2.Durability > 0)
                        {
                            countOfDamage += player.WeaponSlot2.Damage;
                            enemies[numOfEnemy].GetDamage(player.WeaponSlot2.Damage);
                        }
                        else
                        {
                            Console.WriteLine("Оружие в левой руке сломалось! Замените его");
                        }

                        player.GetDamage(enemies[numOfEnemy].WeaponSlot1.Damage);
                        break;
                    case 2:
                        player.ShowInventoryMenu();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }

                if (enemies[numOfEnemy].Health <= 0)
                {
                    enemies[numOfEnemy].Destroy();
                    enemies[numOfEnemy].GetEnemyItems(player);
                    numOfEnemy--;

                    if (numOfEnemy == -1)
                        break;
                }

                player.Destroy(countOfDamage, enemies[numOfEnemy]);

                Console.Clear();
            }

            Console.WriteLine("Враги побеждены");
        }

        /// <summary>
        /// Метод заполняющий массив с врагами. На выбор дается 3 типа врагов.
        /// </summary>
        /// <param name="typeOfEnemy">Тип врагов:
        /// <br> 0 - слабые </br>
        /// <br> 1 - средние </br>
        /// <br> 2 - сильные </br></param>
        private static void FillUnitArray(Unit[] arr, int count, int typeOfEnemy)
        {
            Random random = new Random();

            SystemException systemException = new SystemException("Нет такого типа врагов");

            switch (typeOfEnemy)
            {
                case 0:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new WeakEnemy("", 25, 25);
                        arr[i].Inventory = new List<Loot>();

                        //Добавление молота в инвентарь, меча в первый слот
                        (arr[i] as Enemies).WeaponSlot1 = new Sword("Меч", "Железный", random.Next(6, 15), random.Next(20, 30), 30);

                    }
                    break;
                case 1:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new MediumEnemy("", 50, 50);

                        //Добавление меча в первый слот
                        (arr[i] as Enemies).WeaponSlot1 = new Sword("Меч", "", random.Next(6, 15), random.Next(20, 30), 30);
                    }
                    break;
                case 2:
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = new StrongEnemy("", 100, 100);

                        //Добавление молота в первый слот
                        (arr[i] as Enemies).WeaponSlot1 = new Hammer("Меч", random.Next(12, 20), random.Next(20, 30), 30); ;
                    }
                    break;
                default:
                    Console.WriteLine(systemException);
                    break;
            }
        }
    }
}
