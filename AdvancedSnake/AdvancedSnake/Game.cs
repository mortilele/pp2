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
        public bool IsAlive;
        public Snake snake;
        public Wall wall;
        public Food food;
        public int timer = 300;
        public string username;

        public Game()
        {
            IsAlive = true;
            username = "UNKNOWN";
            snake = new Snake(20, 13, 'o', ConsoleColor.White);
            food = new Food(2, 2, '@', ConsoleColor.DarkRed);
            wall = new Wall('#', ConsoleColor.Green);
            while (food.IsCollisionWithObject(snake) && food.IsCollisionWithObject(wall))
                food.Generate();
            wall.LoadLevel(wall.current);
        }

        public Game(Snake snake, Wall wall, Food food, string username)
        {
            IsAlive = true;
            this.username = username;
            this.snake = snake;
            this.food = food;
            this.wall = wall;
            while (food.IsCollisionWithObject(snake) && food.IsCollisionWithObject(wall))
                food.Generate();
            wall.LoadLevel(wall.current);
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
                    Game savegame = new Game(snake, wall, food, username);
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
                if (snake.IsCollisionWithSnake() || snake.IsCollisionWithObject(wall))
                {
                    ShowDeath();
                    IsAlive = false;
                }
                Thread.Sleep(timer);
            }
        }

        public void ShowStatusBar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(5, 20);
            Console.WriteLine("Current Level : {0}", wall.current + 1);
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
            UserList uslist = Get();
            bool present = false;
            for (int i = 0; i < uslist.users.Count; i++)
            {
                if (uslist.users[i].username == username)
                {
                    present = true;
                    if (uslist.users[i].userscore < snake.body.Count)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(19, 16);
                        Console.WriteLine("Congratulations! You beat own record!");
                        Console.SetCursorPosition(28, 17);
                        Console.WriteLine("Previous record: {0}", uslist.users[i].userscore);
                        uslist.users[i].userscore = snake.body.Count;
                    }
                    break;
                }
            }
            if (!present)
            {
                UserData rec = new UserData(username, snake.body.Count);
                uslist.users.Add(rec);
            }
            SaveUser(uslist);
        }

        public void SaveUser(UserList users)
        {
            if (File.Exists("users.xml"))
                File.Delete("users.xml");
            SortScore(users);
            FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(UserList));
            xs.Serialize(fs, users);
            fs.Close();
        }

        public void SortScore(UserList userlist)
        {
            for (int i = 0; i < userlist.users.Count - 1; i++)
                for (int j = 0; j < userlist.users.Count - 1 - i; j++)
                {
                    if (userlist.users[j].userscore < userlist.users[j + 1].userscore)
                    {
                        UserData temp = userlist.users[j];
                        userlist.users[j] = userlist.users[j + 1];
                        userlist.users[j + 1] = temp;
                    }
                }
        }

        public void Register()
        {
            Console.SetCursorPosition(26, 13);
            Console.WriteLine("Please, enter your name:");
            Console.SetCursorPosition(33, 14);
            username = Console.ReadLine();
            Console.Clear();
            Start();
        }

        public UserList Get()
        {
            if (!File.Exists("users.xml"))
            {
                UserData rec = new UserData(username, 1);
                UserList u = new UserList();
                u.users.Add(rec);
                SaveUser(u);
                return u;
            }
            else
            {
                FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(UserList));
                UserList userlist = xs.Deserialize(fs) as UserList;
                fs.Close();
                return userlist;
            }
        }

    }
}
