using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NUser
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public NUser(string nm, string ps)
        {
            Username = nm;
            Pass = ps;
        }
    }
}
