using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal interface ILoot
    {
        /// <summary>
        /// Метод для описания удаления предмета
        /// </summary>
        void RemoveItem(int index, List<Loot> obj);

        /// <summary>
        /// Метод для описания использования предмета
        /// </summary>
        Loot UseItem();
    }
}
