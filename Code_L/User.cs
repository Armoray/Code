using System;
using System.Collections.Generic;
using System.Text;

namespace Code_L
{   [Serializable]
    public class User
    {

        public string name;
        public int height;
        public int weight;
        public string gender;


        public User(string Name,
                 int Haight,
                 int Weight,
                 string Gender)
        {
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
            return name + " " + height + " " + weight + " " + gender;
        }

    }
}
