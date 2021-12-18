
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


            Console.WriteLine("Добро пожаловать в программу");
            string Name = ProverkaString("Имя");
            int Height = ProverkaInt("Рост", 100, 230);
            int Weight = ProverkaInt("Вес", 35, 200);
            string Gender = gender();
            Console.ReadLine();


            User tom1 = new User(Name);
            User tom = new User(Name, Height, Weight, Gender);




            Console.WriteLine($"Имя { tom.name }  Рост {tom.height} Вес {tom.weight} Пол {tom.gender}");
            Console.ReadLine();
            int ProverkaInt(string name, int min, int max)
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
            string ProverkaString(string name)
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
            string gender()
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



            List<User> user = new List<User>();
            List<User> user1 = new List<User>();

            user.Insert(0, tom);
            user.Add(tom1);

 

            Console.ReadLine();


            foreach (User p in user1)
            {
                Console.WriteLine(p.name);
            }

            Console.ReadLine();





           

            
        }
    }
}
