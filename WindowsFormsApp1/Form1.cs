using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pass : Form
    {
      
        public class NUser
        {
            public string name { get; set; }
            public string pass { get; set; }
            public NUser(string nm, string ps)
            {
                name = nm;
                pass = ps;
            }
        }
        NUser gago = new NUser("gag", "11");
        NUser samo = new NUser("sam", "22");
        NUser mukuch = new NUser("mukuch", "33");
        NUser hihi = new NUser("Hi", "ha");

        List<NUser> userL = new List<NUser>();
        public List<NUser> test()
        {
            userL.Add(gago);
            return userL;
        }
       

        public pass()
        {
            InitializeComponent();

           List<NUser> test()
            {
                this.userL.Add(gago);
                this.userL.Add(samo);
                this.userL.Add(mukuch);
                this.userL.Add(hihi);
                return userL;
            }
            test();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Agree(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string userName = login.Text;
            string password = passBox.Text;
            bool check = checkBox1.Checked;
            bool userOk = false;
            if (check)
            {
            
                foreach (NUser user in userL)
                {
                    if (user.name == userName && user.pass == password)
                    {
                        userOk = true;                        
                      break;
                    }

                }
                if (userOk == true)
                {
                    label2.Text = "successfully logged in, " + userName;
                    MessageBox.Show("successfully logged in, " + userName);
                  
                } else
                    {
                        MessageBox.Show("wrong password, " + userName +  " try again.");
                    }
               
                 
                
            }else
            {
                MessageBox.Show("You Should be agree :/");
              
               
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            if (check)
            {
                this.login.ReadOnly = false;
                this.passBox.ReadOnly = false;
            } else
            {
                this.login.ReadOnly = true;
                this.passBox.ReadOnly = true;
         
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
       
            string H = " ";
            
            foreach (NUser user in userL)
            {
            
                H += " name: " + user.name + " passw: " + user.pass +  " //" ;
                if (userL.IndexOf(user) == userL.Count )
                break;
            }
            MessageBox.Show(H);

            }
        }
    }

