using System;
using System.Collections.Generic;
using System.Text;

namespace Forms
{   [Serializable]
    public class User
    {
        public string password;
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public string gender { get; set; }


        public User(string Name,
                 int Haight,
                 int Weight,
                 string Gender,
                 string Password)
        {
            password = Password;
            name = Name;
            height = Haight;
            weight = Weight;
            gender = Gender;
        }

        public User (string Name)
        {
            name = Name;
        }

        public override string ToString()
        {
            return name + " " + height + " " + weight + " " + gender +  " " + password;
        }

    }
}
