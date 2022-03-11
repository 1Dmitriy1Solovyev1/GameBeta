using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal interface IAction
    {
        /// <summary>
        /// Метод для описания поломки, смерти, разрущения обьекта
        /// </summary>
        void Destroy();

        /// <summary>
        /// Метод для описания уменьшения здоровья обьекта, в последствии взаимодействия с чем-то 
        /// </summary>
        /// <param name="damage">Входящий урон</param>
        int GetDamage(int damage);

        /// <summary>
        /// Метод для описания увелечения здоровья обьекта, в последствии взаимодействия с чем-то
        /// </summary>
        /// <param name="treatment">Количество лечения</param>
        void Cure(int treatment);
    }
}
