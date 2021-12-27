using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddUser : Form
    {

        public AddUser()
        {
            InitializeComponent();
        }
       
       
        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            var usercontroller = new UserController(name);


            if (usercontroller.IsNewUser)
            {
                string password = textBox5.Text;
                int Height = Convert.ToInt32(textBox2.Text);
                int Weight = Convert.ToInt32(textBox3.Text);
                string Gender = textBox1.Text;
                usercontroller.SetNewUserData(Gender, Weight, Height, password);
                this.Close();
            }
            else
            {
                MessageBox.Show("Данный пользователь существует");
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
           Main Caller = new Main();
        Caller.Enabled = true;
           

        }

    }
}
