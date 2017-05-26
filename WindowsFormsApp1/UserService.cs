using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApp1
{
    public class UserService
    {
        public bool Bool = false;

        public NUser register(string name, string username, string password)
        {
            NUser user = new NUser(username, password)
            {
                Name = name,
            };
            string userString = "";

            if (File.Exists("userList.toplabs"))
            {
                string s = File.ReadAllText("userList.toplabs");
                userString = s + user.Name + "^^toplabs^^" + user.Username + "^^toplabs^^" + user.Pass + Environment.NewLine;

            }

            else
            userString = user.Name + "^^toplabs^^" + user.Username + "^^toplabs^^" + user.Pass + Environment.NewLine;
           
            File.WriteAllText("userList.toplabs", userString);
            return user;
            
           
        } 
        public bool userCheck(string username, string password)
        {
            //String[] result;
            string[] s = File.ReadAllLines("userList.toplabs");
            String[] pattern = new String[] { "^^toplabs^^" };
            

            foreach (string line in s)
            {
               string[] r = line.Split(pattern, StringSplitOptions.None);
                NUser user = new NUser(r[1], r[2])
                {
                    Name = r[0],
                };
                if (user.Username == username && user.Pass == password)
                {
                    Bool = true;
                }
                else Bool = false;
            }
            return Bool;
        }
    }
}
