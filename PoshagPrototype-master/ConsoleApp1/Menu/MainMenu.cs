using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoshagPrototype
{
    internal class MainMenu
    {
        private static int _answer;
        private static bool _safe = true;

        private static void ShowLogo()
        {
            string _logo = @"
▄▄▄▄· ▄▄▄ .▄▄▄▄▄ ▄▄▄·             
▐█ ▀█▪▀▄.▀·•██  ▐█ ▀█             
▐█▀▀█▄▐▀▀▪▄ ▐█.▪▄█▀▀█             
██▄▪▐█▐█▄▄▌ ▐█▌·▐█ ▪▐▌            
·▀▀▀▀  ▀▀▀  ▀▀▀  ▀  ▀             
";

            Console.WriteLine(_logo);
        }

        public static int InitAndCheckAsw()
        {
            int value = -1;
            bool safe = true;

            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Warning.ShowWarning();
                Console.Clear();
                safe = false;
            }

            if (safe)
            {
                return value;
            }
            else
            {
                return -1;
            }
        }

        public static void ShowMenu()
        {
            while (true)
            {
                _safe = true;

                ShowLogo();

                Console.WriteLine("Добро пожаловать в прототип Пошага." +
                    "\n1. Начать игру" +
                    "\n2. Показать правила" +
                    "\n3. Выйти");

                _answer = InitAndCheckAsw();

                switch (_answer)
                {
                    default:
                        Console.WriteLine("Такого варианта нет");
                        break;
                    case 2:
                        ShowRules();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }

                if (_answer == 1)
                {
                    break;
                }

            }
        }

        private static void ShowRules()
        {
            Console.Clear();

            Console.WriteLine("Правила и обьяснение игры:" +
                "\nЭта игра - последовательная боевка с врагами разной сложности." +
                "\nНа выбор дается 3 героя с разной историей и характеристиками " +
                "\n(подробнее о каждом герое в самой игре)" +
                "\n\nЕсть 3 типа врагов: Easy, medium и hight. " +
                "\nС каждого врага может упасть лут в виде брони или оружия");

            Console.ReadKey();

            Console.Clear();
        }

        public static int ChoicePlayer()
        {
            while (true)
            {
                _safe = true;

                Console.Clear();
                ShowLogo();

                Console.WriteLine("Выберите бойца");
                Console.WriteLine("1. Воин - воин легко справиться с толпой монстров. Особенности – ближний бой, хорошая выносливость." +
                    "\nВ арсенале много массовых атак. В качестве оружия использует меч, парные клинки, кастеты. "); 

                Console.WriteLine("\n2. Волшебник - маг повелевает разными стихиями и умеет контролировать разум противника." +
                    "\nОсобенности – красивые заклинания, огромная мощь, контролирующие умения." +
                    "\nМощные умения долго кастуются, но наносят огромный урон.");

                Console.WriteLine("\n3. Стрелок - лучник имеет много общего с магом." +
                    "\nОсобенности – дальний бой, массовые умения, ослабляющие ловушки." +
                    "\n Расправиться с врагом стрелку поможет арбалет, пистолет, лук, пушка." +
                    "\n\nЗа кого будем играть?");

                _answer = InitAndCheckAsw();

                if (_safe)
                {
                    switch (_answer)
                    {
                        default:
                            Console.WriteLine("Такого варианта нет");
                            break;
                        case 1:
                            return 1;
                        case 2:
                            return 2;
                        case 3:
                            return 3;
                    }
                }
            }
        }
    }
}
