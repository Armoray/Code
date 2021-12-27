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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        private void создатьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;


            AddUser _AddUser = new AddUser();
            _AddUser.Show();

        }

        private void прочитатьПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<User> alluser;
            alluser = UserController.Get_all();
            foreach (User b in alluser)
            {
                listBox1.Items.Add(b);
            }

           
        }
    }
}
