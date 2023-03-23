using System;
using System.Security.Cryptography.X509Certificates;

namespace lab5
{
    internal class Program
    {

        public static Random rnd = new Random();
        static void Main()
        {

            char[,] map = new char[20, 20];
            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = '-';
                }


            Sheep[] sheeps = new Sheep[4];
            for (int i = 0; i < sheeps.Length; i++)
            {
                int xInit = rnd.Next(0, map.GetLength(0));
                int yInit = rnd.Next(0, map.GetLength(1));
                sheeps[i] = new Sheep(xInit, yInit, 100, 0);
            }

            Grass[] grass = new Grass[7];
            for (int j = 0; j < grass.Length; j++)
            {
                int GxInit = rnd.Next(0, map.GetLength(0));
                int GyInit = rnd.Next(0, map.GetLength(1));
                grass[j] = new Grass(GxInit, GyInit);
            }

                while (true)
                {
                    for (int i = 0; i < sheeps.Length; i++)
                    {
                        sheeps[i].GetPos(out int xS, out int yS);
                        map[xS, yS] = '-';
                        sheeps[i].Update();
                        sheeps[i].GetPos(out xS, out yS);
                        map[xS, yS] = sheeps[i].Sprite;




                    }


                    RenderMap(map);
                    Console.ReadKey();

                }

            }

            static void RenderMap(char[,] map)
            {
                Console.Clear();
                for (int y = 0; y < map.GetLength(1); y++)
                {

                    for (int x = 0; x < map.GetLength(0); x++)
                    {
                        Console.Write(map[x, y]);
                    }

                    Console.WriteLine();

                }


            }
        }

        class Grass
        {
            private int _x;
            private int _y;
            public char Sprite { get; set; }

            public Grass()
            {
                _x = 5;
                _y = 5;
                Sprite = 'G';
            }
        public Grass(int x, int y)
        {
            _x = x;
            _y = y;
        }

        }

    class Sheep
    {
        // Поля класса
        private int _health;
        private int _x;
        private int _y;

        public int Hunger { get; private set; }
        public char Sprite { get;}
        public int Health
        {
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > 100)
                    _health = 100;
                else
                    _health = value;
            }
            get
            {
                return _health;
            }
        }

        public Sheep()
        {
            _x = 5;
            _y = 5;
            _health = 100;
            Hunger = 0;

            
        }
        public char Sprit
        {
            get
            {
                if (Hunger >= 100)
                {
                    return 'x';
                }
                else
                {
                    return 'S';
                }
            }
        }
        public Sheep(int x, int y, int health, int hunger)
        {
            _x = x;
            _y = y;
            _health = health;
            Hunger = hunger;
           
        }

        public void Eat(int foodMass)
        {
            Hunger -= foodMass;
        }

        public void Update()
        {
            Hunger += 59;

            Move(Program.rnd.Next(0, 5));
        }

        private void Move(int direction)
        {


            if (direction == 1)
                _x += 1;
            else if (direction == 2)
                _y += 1;
            else if (direction == 3)
                _x -= 1;
            else if (direction == 4)
                _y -= 1;


        }
        
       
        public void GetPos(out int x, out int y)
            {
                x = _x;
                y = _y;
            }
        }


    }
