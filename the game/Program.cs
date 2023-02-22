using System;

namespace the_game
{
    class Program
    {
        /* у игрока есть 3 параметра: здоровье, сила и ловкость. Причем сила и ловкость изначально принимает случайное значение. 
        Сила - количество наносимого противнику урона (принимает значения от 5 до 20);
        защита - это параметр, который позволяет сокращать наносимый ему урон (принимает значения от 5 до 20);
        автономно защита не работает, поэтому для защиты нужно выбирать действие "защита"
        
        (В обозначении кода цифра 1 всегда означает игрока, цифра 2 бота)
         */

        static string action1;
        static string action2;
        static void Main()
        {
            CreateMainCharacter();
            CreateAnOpposite();
        }

        static void CreateMainCharacter()
        {

            Console.WriteLine("напишите имя персонажа");
            string name = Console.ReadLine();
            int health1 = 100;
            Random rnd = new Random();
           int force1 = rnd.Next(7, 20);
            int protection1 = rnd.Next(5, 16);
            Console.WriteLine("Ваш персонаж: " + name);
            Console.WriteLine("Сила = " + force1);
            Console.WriteLine("Сила = " + protection1);
            Console.WriteLine("Здоровье = " + health1);
        }
        static void  CreateAnOpposite()
        {
            int health2 = 100;
            Random rnd = new Random();
            int force2 = rnd.Next(5, 20);
            int protection2 = rnd.Next(10, 20);
            Console.WriteLine("Ваш соперник: бот");
            Console.WriteLine("Сила = " + force2);
            Console.WriteLine("Сила = " + protection2);
            Console.WriteLine("Здоровье = " + health2);
            
        }

           static void Fight1()
            {
                Console.WriteLine("выберите действие: 1 - удар, 2 - оборона");
                action1 = Console.ReadLine();
                if (action1 == "1")
                {
                    health2 = health2 - force1; 

                }
                else if (action1 == "2")
            {
                health1 - health1 - force2 + protection1;
            }
            {
                
            }
            }
        }
        }
    

