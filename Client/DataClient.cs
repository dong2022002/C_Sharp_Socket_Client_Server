using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class DataClient
    {
        public static string portClient;
        public static string ip;
        public static string user;
        public static string password;
        public static List<Account> dataLogin = new List<Account>();

        public static void createUserData()
        {
            dataLogin.Clear();
            dataLogin.Add(new Account("dong","123"));
            dataLogin.Add(new Account("Vu", "123"));



        }
    }
    public class Account
    {
    public string user { get; set; }
    public string password { get; set; }
        public Account(string user,string password)
        {
            this.user = user;
            this.password = password;
        }
}
    
}
