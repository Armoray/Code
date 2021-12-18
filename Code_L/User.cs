using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Code_L
{
    [Serializable]
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


        public User(string Name)
        {
            name = Name;
        }

        public void SaveUser(List<User> user)
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("Users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, user);
            }
        }
        List<User> GetUsersData()
        {
            var formatter = new BinaryFormatter();
            //var formatter = new DataContractJsonSerializer();
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
