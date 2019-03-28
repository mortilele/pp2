using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSnake
{
    public class Matrix
    {
        static int Counter;
        static Random randomPosition = new Random();

        static int flowSpeed = 100;
        static int fastFlow = flowSpeed + 30;
        static int textFlow = fastFlow + 50;

        static ConsoleColor baseColor = ConsoleColor.DarkGreen;
        static ConsoleColor fadedColor = ConsoleColor.White;

        static string endText = "- || S || N || A || K || E || -";

        public Matrix() { }

        static char AsciiCharacters
        {
            get
            {
                int t = randomPosition.Next(10);
                if (t <= 2) return (char)('0' + randomPosition.Next(10));
                else if (t <= 4) return (char)('a' + randomPosition.Next(27));
                else if (t <= 6) return (char)('A' + randomPosition.Next(27));
                else return (char)(randomPosition.Next(32, 255));
            }
        }

        public void Start()
        {
            Console.Title = "Snake Game";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = baseColor;
            Console.Clear();
            Console.SetWindowSize(70, 27);
            Console.SetBufferSize(70, 27);
            Console.CursorVisible = false;
            int width, height;
            int[] y;
            Initialize(out width, out height, out y);
            while (true)
            {
                Counter++;
                ColumnUpdate(width, height, y);
                if (Counter > (3 * flowSpeed))
                    break;
            }
        }

        public static int YPositionFields(int yPosition, int height)
        {
            if (yPosition < 0) return yPosition + height;
            else if (yPosition < height) return yPosition;
            else return 0;
        }

        private static void Initialize(out int width, out int height, out int[] y)
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;
            y = new int[width];
            Console.Clear();

            for (int x = 0; x < width; ++x)
                y[x] = randomPosition.Next(height);
        }

        private static void ColumnUpdate(int width, int height, int[] y)
        {
            int x;
            if (Counter < flowSpeed)
            {
                for (x = 0; x < width; ++x)
                {
                    if (x % 10 == 1)
                        Console.ForegroundColor = fadedColor;
                    else
                        Console.ForegroundColor = baseColor;

                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(AsciiCharacters);

                    if (x % 10 == 9)
                        Console.ForegroundColor = fadedColor;
                    else
                        Console.ForegroundColor = baseColor;

                    int temp = y[x] - 2;
                    Console.SetCursorPosition(x, YPositionFields(temp, height));
                    Console.Write(AsciiCharacters);

                    int temp2 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp2, height));
                    Console.Write(" ");
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
            else if (Counter > flowSpeed && Counter < fastFlow)
            {
                for (x = 0; x < width; ++x)
                {
                    Console.SetCursorPosition(x, y[x]);
                    if (x % 10 == 9)
                        Console.ForegroundColor = fadedColor;
                    else Console.ForegroundColor = baseColor;

                    Console.Write(AsciiCharacters);

                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }

            else if (Counter > fastFlow)
            {
                for (x = 0; x < width; ++x)
                {
                    Console.SetCursorPosition(x, y[x]);
                    Console.Write(" ");

                    int temp1 = y[x] - 20;
                    Console.SetCursorPosition(x, YPositionFields(temp1, height));
                    Console.Write(" ");

                    if (Counter > fastFlow && Counter < textFlow)
                    {
                        if (x % 10 == 9)
                            Console.ForegroundColor = fadedColor;
                        else Console.ForegroundColor = baseColor;

                        int temp = y[x] - 2;
                        Console.SetCursorPosition(x, YPositionFields(temp, height));
                        Console.Write(AsciiCharacters);
                    }

                    Console.SetCursorPosition(width / 2-14, height / 2+1);
                    Console.Write(endText);
                    y[x] = YPositionFields(y[x] + 1, height);
                }
            }
        }
    }
}
