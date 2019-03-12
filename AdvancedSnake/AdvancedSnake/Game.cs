using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace AdvancedSnake
{
    public class Game
    {
        List<GameObject> g_objects;
        public bool IsAlive;
        public Snake snake;
        public Wall wall;
        public Food food;
        public int timer = 300;
        public Game()
        {

            IsAlive = true;
            g_objects = new List<GameObject>();
            snake = new Snake(20, 13, 'o', ConsoleColor.White);
            food = new Food(2, 2, '@', ConsoleColor.DarkRed);
            wall = new Wall('#', ConsoleColor.Green);
            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);
            while (food.IsCollisionWithObject(snake) && food.IsCollisionWithObject(wall))
                food.Generate();
            wall.LoadLevel(wall.current);
        }

        public Game(Snake snake, Wall wall, Food food)
        {
            IsAlive = true;
            g_objects = new List<GameObject>();
            this.snake = snake;
            this.food = food;
            this.wall = wall;
            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);
            while (food.IsCollisionWithObject(snake) && food.IsCollisionWithObject(wall))
                food.Generate();
            wall.LoadLevel(wall.current);
        }
        public void Draw()
        {
            foreach (GameObject g in g_objects)
                g.Draw();
        }

        public void ShowStatusBar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(5, 20);
            Console.WriteLine("Current Level : {0}", wall.current+1);
            Console.SetCursorPosition(5, 21);
            Console.WriteLine("Record : {0}", snake.body.Count);
        }

        public void ShowDeath()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(29, 12);
            Console.WriteLine("--GAME OVER--");
            Console.SetCursorPosition(29, 13);
            Console.WriteLine("_____________");
            Console.SetCursorPosition(29, 14);
            Console.WriteLine("Your score: {0}", snake.body.Count);
        }

        public void Start()
        {
            IsAlive = true;
            Thread th = new Thread(MovingON);
            food.Draw();
            wall.Draw();
            snake.Draw();
            ShowStatusBar();
            th.Start();
            while (IsAlive)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    IsAlive = false;
                }
                else if (KeyInfo.Key == ConsoleKey.S)
                {
                    Game savegame = new Game(snake, wall, food);
                    savegame.Save(savegame);
                }
                else
                snake.ChangeDirection(KeyInfo);
            }
        }

        public void Save(Game game)
        {
            if (File.Exists("loader.xml"))
                File.Delete("loader.xml");
            FileStream fs = new FileStream("loader.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Game));
            xs.Serialize(fs, game);
            fs.Close();
        }

        public void MovingON()
        {
            while (IsAlive)
            {
                snake.Clear();
                snake.SnakeMove();
                snake.Draw();
                if (snake.IsCollisionWithObject(food))
                {
                    if (timer > 100)
                        timer -= 50;
                    if (snake.body.Count % 5 == 0 && wall.current < 4)
                    {
                        wall.Clear();
                        wall.current++;
                        wall.LoadLevel(wall.current);
                        wall.Draw();
                    }
                    while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                        food.Generate();
                    food.Draw();
                    snake.body.Add(new Point(0, 0));
                    ShowStatusBar();
                }
                if (snake.IsCollisionWithSnake())
                {
                    ShowDeath();
                    IsAlive = false;
                }
                if (snake.IsCollisionWithObject(wall))
                {
                    ShowDeath();
                    IsAlive = false;
                }
                Thread.Sleep(timer);
            }
        }
    }
}
