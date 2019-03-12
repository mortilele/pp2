using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvancedSnake
{
    public class Wall:GameObject
    {
        public string[] levels =
        {
            "../../level1.txt",
            "../../level2.txt",
            "../../level3.txt",
            "../../level4.txt",
            "../../level5.txt"
        };
        public int current = 0;
        public Wall() { }
        public Wall(char sign, ConsoleColor color) : base(0, 0, sign, color)
        {
            body = new List<Point>();
        }

        public void LoadLevel(int current)
        {
            this.current = current;
            body = new List<Point>();
            for (int i = 0; i <= 68; i++)
            {
                body.Add(new Point(i, 0));
                body.Add(new Point(i, 19));
            }
            for (int i = 0; i <= 19; i++)
            {
                body.Add(new Point(0, i));
                body.Add(new Point(68, i));
            }

            string filename = levels[current];
            StreamReader sr = new StreamReader(filename);
            string[] rows = sr.ReadToEnd().Split('\n');
            for (int i = 0; i < rows.Length; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    if (rows[i][j] == '#')
                        body.Add(new Point(j, i));
        }
    }
}
