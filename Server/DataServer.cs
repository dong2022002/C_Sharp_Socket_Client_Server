using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public static class DataServer
    {
        public static string portServer;
        public static List<User> listUser = new List<User>();
      
    }
    public class User
    {
        public string port { get; set; }
        public string Name { get; set; }

        public User(string port, string name)
        {
            this.port = port;
            this.Name = name;
        }
        public User()
        {

        }
    }
}
