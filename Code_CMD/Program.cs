
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Code_L;



namespace Code_CMD
{
    class Program
    {
        static void Main(string[] args)
        {


            bool exit=false;
            int fu;
            Console.WriteLine("Добро пожаловать в программу");
            while (exit == false)
            {
                Console.WriteLine("1: Прочитать пользователей");
                Console.WriteLine("2: Новый пользователь");
                Console.WriteLine("3: Выйти из программы");
                fu=Convert.ToInt16(Console.ReadLine());

                switch (fu)
                {
                    case 1:
                        List<User> user = GetUsersData();
                        foreach (User p in user) 
                        {
                            Console.WriteLine(p);
                        }
                            
                            break;

                    case 2:
                        NewUser();
                        break;

                    case 3:
                        exit = true;
                        break;

                }


            }
           
            void NewUser()
            {
                Console.WriteLine("Введите имя пользователя");
                string name = Console.ReadLine();
                var usercontroller = new UserController(name);

                if (usercontroller.IsNewUser)
                {                     
                    //string Name = ProverkaString("Имя");
                    int Height = usercontroller.ProverkaInt("Рост", 100, 230);
                    int Weight = usercontroller.ProverkaInt("Вес", 35, 200);
                    string Gender = usercontroller.gender();
                    usercontroller.SetNewUserData(Gender,Weight,Height);
                }
                Console.WriteLine(usercontroller.CurrentUser);
                Console.ReadLine();
            }

             List<User> GetUsersData()
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
        }
    }
}
