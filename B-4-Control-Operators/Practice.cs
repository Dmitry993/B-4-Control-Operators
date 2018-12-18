using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            var time = DateTime.Now.TimeOfDay;
            if (time.Hours < 12)
            {
                Console.WriteLine("Доброе утро, Ольга!");
            }
            else if (time.Hours > 11 & time.Hours < 19)
            {
                Console.WriteLine("Добрый день, Ольга!");
            }
            else
            {
                Console.WriteLine("Добрый вечер, Ольга!");
            }
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            int y = int.Parse(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("Значения равны");
            }
            else if (x > y)
            {
                Console.WriteLine("Значение X больше Y на " + (x - y));
            }
            else
            {
                Console.WriteLine("Значение X меньше Y на " + (y - x));
            }
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("Значение X больше Y на " + (x - y));
                if (y == 0)
                {
                    Console.WriteLine("Значение Y равно 0");
                }
            }
            else if (x < y)
            {
                Console.WriteLine("Значение Y больше X на " + (y - x));
                if (x == 0)
                {
                    Console.WriteLine("Значение X равно 0");
                }
            }
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            Console.WriteLine("Ваше число простое? ");
            string answer1 = Console.ReadLine();
            if (answer1.ToLower().Equals("да"))
            {
                Console.WriteLine("Ваше число четное? ");
                string answer3 = Console.ReadLine();
                if (answer3.ToLower().Equals("да"))
                {
                    Console.WriteLine("Это число 2");
                }
                else
                {
                    Console.WriteLine("Ваше число больше 4? ");
                    string answer4 = Console.ReadLine();
                    if (answer4.ToLower().Equals("да"))
                    {
                        Console.WriteLine("Это число 5");
                    }
                    else
                    {
                        Console.WriteLine("Это число 3");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ваше число четное? ");
                string answer2 = Console.ReadLine();
                if (answer2.ToLower().Equals("да"))
                {
                    Console.WriteLine("Это число 4");
                }
                else
                {
                    Console.WriteLine("Это число 1");
                }
            }
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var day = DateTime.Today;
            var dayOfWeek = (int)day.DayOfWeek;
            switch (dayOfWeek)
            {
                case 0:
                    Console.WriteLine("Доброго воскресенья, Ольга!");
                    break;
                case 1:
                    Console.WriteLine("Доброго понедельника, Ольга!");
                    break;
                case 2:
                    Console.WriteLine("Доброго вторника, Ольга!");
                    break;
                case 3:
                    Console.WriteLine("Доброй среды, Ольга!");
                    break;
                case 4:
                    Console.WriteLine("Доброго четверга, Ольга!");
                    break;
                case 5:
                    Console.WriteLine("Доброй пятницы, Ольга!");
                    break;
                case 6:
                    Console.WriteLine("Доброй субботы, Ольга!");
                    break;
            }
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            for (int i = 0; ; i++)
            {
                var button = Console.ReadKey();
                switch (button.KeyChar)
                {
                    case 'W':
                    case 'w':
                        Console.WriteLine("\nВверх;");
                        break;
                    case 'A':
                    case 'a':
                        Console.WriteLine("\nВлево;");
                        break;
                    case 'S':
                    case 's':
                        Console.WriteLine("\nВниз;");
                        break;
                    case 'D':
                    case 'd':
                        Console.WriteLine("\nВправо;");
                        break;
                    default:
                        Console.WriteLine("\nНеверное направление;");
                        break;
                }
            }
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - четное;");
                }
                else
                {
                    Console.WriteLine(i + " - нечетное;");
                }
            }
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i >= 0; i--)
            {
                if (i % 3 == 0 & i != 0)
                {
                    Console.WriteLine(i + " - делится на 3 без остатка;");
                }
            }
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            char letter = 'A';
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(letter);
                }
            }

        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Привет, мир!");
            }
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            string[] arr = { " отправились обедать,", "Один поперхнулся,", ", поев, клевали носом,",
                "Один не смог проснуться,", " в Девон ушли потом,", "Один не возвратился,",
                " дрова рубили вместе,", "Зарубил один себя - и", " пошли на пасеку гулять,",
                "Одного ужалил шмель,", " судейство учинили,", "Засудили одного,", " пошли купаться в море,",
                "Один попался на приманку,", " в зверинце оказались,", "Одного схватил медведь,", " легли на солнцепеке,"
            };
            int num = 10;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{num} негритят" + arr[i]);
                num--;
                i++;
                if (num == 1)
                {
                    Console.WriteLine("Один сгорел - и вот один, несчастный, одинокий.\n" +
                                      "Последний негритенок поглядел устало,\n" +
                                      "Он пошел повесился, и никого не стало.");
                    break;
                }
                Console.WriteLine(arr[i] + $" их осталось {num}.");

            }
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = 0; i > -11; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " - четное;");
                }
                else
                {
                    Console.WriteLine(i + " - нечетное;");
                }
            }
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            byte count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Equals('a') || word[i].Equals('A'))
                {
                    count++;
                }
            }
            Console.WriteLine("Количество букв \"а\" равно: " + count);
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = alphabet.Length - 1; i >= 0; i--)
            {
                Console.Write(alphabet[i] + " ");
            }
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            int i = 1;
            while (i++ < 20)
            {
                Console.WriteLine(i++);
            }
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
            int i = 1;
            while (i < 20)
            {
                Console.WriteLine(i++);
                i++;
            }
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            byte i = 0;
            while (i < 6)
            {
                Console.WriteLine("Привет, мир!");
                i++;
            }
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            int i = 0;
            int result = 1;
            while (i < 10)
            {
                result *= 2;
                i++;
                Console.WriteLine($"2 в степени {i} равно " + result);
            }
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            int result = 0;
            while (result != 4)
            {
                Console.WriteLine("Сколько будет 2 + 2?");
                int answer = int.Parse(Console.ReadLine());
                result = answer;
            }

            Console.WriteLine("Правильно!");
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            int player = 0;
            while (player < 25)
            {
                Console.WriteLine("Введите число от 1 до 6:");
                int answer = int.Parse(Console.ReadLine());
                player += answer;
                if (player >= 25)
                {
                    Console.WriteLine("Игра закончена!");
                }
            }
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void B4_P21_25_While_DiceGameMultiplePlayers()
        {
            int player1 = 0;
            int player2 = 0;
            while (player1 < 25 & player2 < 25)
            {
                Console.WriteLine("Игрок 1. Введите число от 1 до 6:");
                int answer1 = int.Parse(Console.ReadLine());
                player1 += answer1;
                Console.WriteLine("Игрок 1 на шаге " + player1);
                if (player1 >= 25)
                {
                    Console.WriteLine("Игрок 1 победил!");
                    break;
                }
                Console.WriteLine("Игрок 2. Введите число от 1 до 6:");
                int answer2 = int.Parse(Console.ReadLine());
                player2 += answer2;
                Console.WriteLine("Игрок 2 на шаге " + player2);
                if (player2 >= 25)
                {
                    Console.WriteLine("Игрок 2 победил!");
                }
            }
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            int num1 = 1;
            int num2 = 100;
            int mid = 50;
            while (num1 != mid)
            {
                Console.WriteLine($"Ваше число больше {mid}? ");
                string answer1 = Console.ReadLine();
                if (answer1.ToLower().Equals("да"))
                {
                    num1 = mid + 1;
                    mid = (num1 + num2) / 2;
                }
                else
                {
                    num2 = mid;
                    mid = (num1 + num2) / 2;
                }
            }
            Console.WriteLine("Ваше число четное? ");
            string answer2 = Console.ReadLine();
            if (num1 % 2 == 0 && answer2.ToLower().Equals("да"))
            {
                Console.WriteLine($"Ваше число {num1}");
            }
            else if (num1 % 2 == 0 && answer2.ToLower().Equals("да"))
            {
                Console.WriteLine($"Ваше число {num2}");
            }
            else
            {
                int num = num1 % 2 != 0 ? num1 : num2;
                Console.WriteLine($"Ваше число {num}");
            }
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите оператор:");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            if (symbol == '+')
            {
                Console.WriteLine("Ответ: " + num1 + num2);
            }
            else if (symbol == '-')
            {
                Console.WriteLine("Ответ: " + (num1 - num2));
            }
            else if (symbol == '/')
            {
                Console.WriteLine("Ответ: " + num1 / num2);
            }
            else if (symbol == '*')
            {
                Console.WriteLine("Ответ: " + num1 * num2);
            }
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {

            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите оператор:");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    Console.WriteLine("Ответ: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Ответ: " + (num1 - num2));
                    break;
                case '/':
                    Console.WriteLine("Ответ: " + (num1 / num2));
                    break;
                case '*':
                    Console.WriteLine("Ответ: " + (num1 * num2));
                    break;
            }

        }

        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            string word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
