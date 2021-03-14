using System;
using System.Collections.Generic;

namespace _2002
{
    class Program
    {
        static public List<User> Users = new List<User>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "register") Register(command[1], command[2]);
                else if (command[0] == "login") Login(command[1], command[2]);
                else if (command[0] == "logout") Logout(command[1]);
            }
        }

        public static void Register(string username, string password)
        {
            string result = "";
            bool isExist = false;

            foreach (var item in Users)
            {
                if (item.Username == username)
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist)
            {
                result = "fail: user already exists";
            }
            else
            {
                Users.Add(new User(username, password));
                result = "success: new user added";
            }

            Console.WriteLine(result);
        }

        public static void Login(string username, string password)
        {
            string result = "";

            bool isExist = false;

            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Username == username)
                {
                    isExist = true;
                    if (Users[i].Password != password)
                    {
                        result = "fail: incorrect password";
                    }
                    else if (Users[i].isLogin) result = "fail: already logged in";
                    else
                    {
                        Users[i].isLogin = true;
                        result = "success: user logged in";
                    }
                    break;
                }
            }

            if (!isExist) result = "fail: no such user";
            Console.WriteLine(result);
        }

        public static void Logout(string username)
        {
            string result = "";

            bool isExist = false;

            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Username == username)
                {
                    isExist = true;
                    if (!Users[i].isLogin) result = "fail: already logged out";
                    else
                    {
                        Users[i].isLogin = false;
                        result = "success: user logged out";
                    }
                    break;
                }
            }

            if (!isExist) result = "fail: no such user";
            Console.WriteLine(result);
        }
    }

    class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool isLogin { get; set; }

        public User(string _user, string _pass)
        {
            Username = _user;
            Password = _pass;
            isLogin = false;
        }
    }
}
