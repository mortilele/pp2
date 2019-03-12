using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace AdvancedSnake
{
    public class Interface
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
                game.Start();
            }
            if (cursor == 2)
            {
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

    }
}
