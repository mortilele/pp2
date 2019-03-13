using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace AdvancedSnake
{
    public class UserList
    {
        public List<UserData> users;
        public UserList() { users = new List<UserData>(); }
    }
}
