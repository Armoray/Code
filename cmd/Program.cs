using System;
using Code.Logic;

namespace cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу");

            User tom = new User();

            Console.WriteLine("Добро пожаловать в программу");
            Console.ReadLine();
            Console.WriteLine("Введите ваше имя");
            tom.name = Console.ReadLine();
            Console.WriteLine("Ваш пол");

            tom.gender = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
