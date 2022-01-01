using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Notenverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            User user1 = new User("wvs-ffm");
            LoginOperations.addUser(user1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                String x = Username.Text;

                if (LoginOperations.check(x))
                {
                    Form2 Form = new Form2();
                    Form.Show();
                    this.Hide();
                }

                else
                {
                    ERROR.Text = "User stimmt nicht überein";
                }
            }
        }
    }

    class User
    {
        private String username;
        
        public User(String username)
        {
            this.username = username;
        }
        #region set/get
        public String getUsername()
        {
            return this.username;
        }



        public void setUsername(String n)
        {
            this.username = n;
        }
        #endregion
    }
    class LoginOperations
    {
        static private List<User> logList = new List<User>();

        #region Listfunctions
        static public void addUser(User n)
        {
            logList.Add(n);
        }

        static public bool check(String n)
        {

            foreach (User x in logList)
            {
                if (x.getUsername() == n)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
