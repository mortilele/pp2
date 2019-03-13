using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSnake
{
    public class UserData
    {
        public string username;
        public int userscore;

        public UserData() { }
        public UserData(string username, int userscore)
        {
            this.username = username;
            this.userscore = userscore;
        }
    }

}
