using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class Warning
    {
        /// <summary>
        /// Метод выводящий сообщение об ошибке о неправильном значении
        /// </summary>
        public static void ShowWarning()
        {
            Console.WriteLine("Вы ввели неправильное числовое значение значение." +
                "Попробуйте ещё раз");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод выводящий сообщение об ошибке о выходе за пределы листа
        /// </summary>
        public static void ShowOutOfRange()
        {
            Console.WriteLine("Нет предмета под таким номером!");
        }
    }
}
