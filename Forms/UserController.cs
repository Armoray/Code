using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Forms
{
    public class UserController
    {
        public List<User> Users;
        public User CurrentUser;
        public bool IsNewUser = false;

        public UserController(string userName)
        {
            if ((userName.Length == 0))
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



      
        public void SetNewUserData(string genderName, int weight, int height, string password)
        {
            //проверка
            CurrentUser.gender = genderName;
            CurrentUser.height = weight;
            CurrentUser.weight = height;
            CurrentUser.password = password;
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



        

        static public List<User> Get_all()
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

 