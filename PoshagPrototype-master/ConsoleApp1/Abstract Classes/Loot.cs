using System;
using System.Collections.Generic;

namespace PoshagPrototype
{
    /// <summary>
    /// Абстрактный класс Добыча
    /// </summary>
    internal class Loot : ILoot
    {
        public void RemoveItem(int index, List<Loot> obj)
        {
            while (true)
            {
                bool isSafe = true;

                Console.WriteLine("Введите номер предмета, который вы хотите выкинуть (вернуть предмет назад нельзя!)");

                try
                {
                    index = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    isSafe = false;
                    Warning.ShowWarning();
                }

                if (isSafe)
                {
                    //Нет реализации
                    break;
                }
            }

            if (index >= 0 || index <= obj.Count)
            {
                obj.RemoveAt(index);
            }
            else
            {
                Warning.ShowOutOfRange();
            }
        }

        public Loot UseItem()
        {
            return this;
        }
    }
}