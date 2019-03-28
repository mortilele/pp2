using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace AdvancedSnake
{
    public class Interface : Game
    {
        public string[] menu =
        {
            "Continue",
            "New Game",
            "Scoreboard",
            "Load Level",
            "Exit"
        };

        public int[] levels =
        {
            0,
            1,
            2,
            3,
            4
        };

        public int cursor = 0;

        public Interface() { }

        public void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(27, 9);
            Console.WriteLine("W E L C O M E");
            Console.SetCursorPosition(26, 18);
            Console.WriteLine("Made by Akhmetov");
            int x = 30, y = 11;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.ForegroundColor = ConsoleColor.White;
                if (i == cursor)
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(menu[i]);
            }
            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            if (KeyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Open(cursor);
            }
            if (KeyInfo.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            ChangeCursor(KeyInfo);
            ShowMenu();
        }

        public void ChangeCursor(ConsoleKeyInfo KeyInfo)
        {
            if (KeyInfo.Key == ConsoleKey.DownArrow)
            {
                cursor++;
                if (cursor >= 5)
                    cursor = 0;
            }
            if (KeyInfo.Key == ConsoleKey.UpArrow)
            {
                cursor--;
                if (cursor < 0)
                    cursor = 4;
            }
        }

        public void Open(int cursor)
        {
            if (cursor == 0)
            {
                Game contgame = GameContinue();
                contgame.Start();
            }
            if (cursor == 1)
            {
                Game game = new Game();
                game.Register();
            }
            if (cursor == 2)
            {
                ShowScores();
            }
            if (cursor == 3)
            {
                cursor = 0;
                ShowLevels();
            }
            if (cursor == 4)
            {
                Environment.Exit(0);
            }
        }

        public void ShowScores()
        {
            Console.Clear();
            UserList userlist = Get();
            int x = 27, y = 10;
            Console.SetCursorPosition(x+3, y++);
            Console.WriteLine("Scoreboard");
            for (int i = 0; i < Math.Min(5, userlist.users.Count); i++)
            {
                Console.SetCursorPosition(x, ++y);
                Console.WriteLine("{0}| {1} - {2}", i+1, userlist.users[i].username, userlist.users[i].userscore);
            }
            Console.ReadKey();
        }

        public Game GameContinue()
        {
            FileStream fs = new FileStream("loader.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Game));
            Game gameloader = xs.Deserialize(fs) as Game;
            fs.Close();
            return gameloader;
        }

        public void ShowLevels()
        {
            Console.Clear();
            int x = 30, y = 11;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.ForegroundColor = ConsoleColor.White;
                if (i == cursor)
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Level - {0}",levels[i]+1);
            }
            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            if (KeyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Game game = new Game();
                game.wall.LoadLevel(levels[cursor]);
                game.Start();
            }
            if (KeyInfo.Key == ConsoleKey.Escape)
                ShowMenu();
            ChangeCursor(KeyInfo);
            ShowLevels();
        }

        public void Shtori()
        {/*Animation of Shtori
            Console.Clear();
            for (int j = 0; j <= 35; j++)
            {

                for (int i = 0; i < 25; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.WriteLine("|");
                    Console.SetCursorPosition(69 - j, i);
                    Console.WriteLine("|");
                }
            }
            */
            int n = 26;
            int m = 68;
            int x_0 = 4;
            int y_0 = 2;
            int x = 4;
            int y = 2;
            while (x_0 != m && y_0 != n) 
            {
                if (y == y_0)
                {
                    while (x < m)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(x, y_0);
                        Console.Write("@");
                        x++;
                        Thread.Sleep(1);
                    }
                    y_0++;
                }
                if (x == m)
                {
                    while (y < n)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(m - 1, y);
                        Console.Write("@");
                        y++;
                        Thread.Sleep(2);
                    }
                    m--;
                }
                if (y == n)
                {
                    while (x > x_0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(x - 1, n - 1);
                        Console.Write("@");
                        x--;
                        Thread.Sleep(1);
                    }
                    n--;
                }
                if (x == x_0)
                {
                    while (y > y_0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(x_0, y - 1);
                        Console.Write("@");
                        y--;
                        Thread.Sleep(2);
                    }
                    x_0++;
                }
            }

          
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.DarkBlue ;
            for (int j = 35; j >= 0; j--)
            {
                for (int i = 2; i < 26; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(69 - j, i);
                    Console.WriteLine(" ");
                }
                Thread.Sleep(50);
            }
            Console.Clear();
            TextAnimate();
        }

        public void TextAnimate()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(27, 9);
            string text = "W E L C O M E";
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(80);
                Console.Write(text[i]);
            }
            Thread.Sleep(500);
            ShowMenu();
        }
    }
}
