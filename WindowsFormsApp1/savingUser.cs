using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class savingUser
    {
       public void saving(string name, string username, string password)
        {
            string SL = "";
            SL = name + "^^toplabs^^" + username + "^^toplabs^^" + Environment.NewLine;
            File.WriteAllText("users.toplabs",SL);

        }
    }
}
