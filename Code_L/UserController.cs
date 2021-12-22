using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Code_L
{
    public class UserController
    {
        public List<User> Users;
        public User CurrentUser;
        public bool IsNewUser = false;

        public UserController(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentException("Имя пользователя не может быть пустым", nameof(userName));
            }

            Users = GetUsersData();

            CurrentUser = Users.SingleOrDefault(u => u.name == userName);

            if (CurrentUser == null)
            {
                CurrentUser = new User(userName);
             Users.Add(CurrentUser);

                IsNewUser = true;
                Save();
            }
        }



        public void SetNewUserData(string genderName, int weight, int height)
        {
            //проверка
            CurrentUser.gender = genderName;
            CurrentUser.height = weight;
            CurrentUser.weight = height;
            Save();


        }
        private List<User> GetUsersData()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("Users.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)

                {
                    return (List<User>)formatter.Deserialize(fs);
                }
                else
                {
                    return new List<User>();
                }
            }            
        }
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("Users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);
            }
        }



        public  int ProverkaInt(string name, int min, int max)
        {
            int p;
            while (true)
            {
                Console.WriteLine("Введите ваш " + name);
                if (((int.TryParse(Console.ReadLine(), out p))) & (p > min) & (p < max))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Не коректный " + name);
                }
            }

            return p;
        }
        public string ProverkaString(string name)
        {
            string s;
            while (true)
            {
                Console.WriteLine("Введите параметр " + name);
                s = Console.ReadLine();
                if ((s.All(Char.IsLetter)) & (s.Length > 2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Не коректный параметр " + name);
                }
            }
            return s;







        }
        public string gender()
        {
            string text = "a";
            while (true)
            {
                Console.WriteLine("Введите ваш пол:\n1: Мужчина\n2: Женщина");
                switch (Console.ReadLine())
                {
                    case "1":
                        text = "Мужчина";
                        break;
                    case "2":
                        text = "Женщина";
                        break;
                }
                if (text != "a")
                {
                    break;
                }
            }
            return text;
        }
    }
}

 