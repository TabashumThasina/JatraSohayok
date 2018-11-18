using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatra
{
    public class NormalUser
    {
        private string fname,lname,contact,type,email;
        public string Type { set {type = value; } get { return this.type; } }
        public string Email { set { email = value; } get { return this.email; } }
        public string FName { set { fname = value; } get { return this.fname; } }
        public string LName { set { lname = value; } get { return this.lname; } }
        public string Contact { set { contact = value; } get { return this.contact; } }
    }
}
