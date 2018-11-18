using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatra
{
    public class SignUpG :NormalUser
    {
        private string gender, nid, state, address, country, refpername, refpercontact, refperrelation, area, food, age, charge, lan1, lan2, a;

        public string Gender{  set { gender = value; } get { return this.gender; } }
        public string Nid { set { nid = value; } get { return this.nid; } }
        public string State { set { state = value; } get { return this.state; } }
        public string Address { set { address = value; } get { return this.address; } }
        public string Country { set { country = value; } get { return this.country; } }
        public string Age { set { age = value; } get { return this.age; } }
        public string RefPersonName { set { refpername = value; } get { return this.refpername; } }
        public string RefPersonContact { set { refpercontact = value; } get { return this.refpercontact; } }
        public string RefPersonRelation { set { refperrelation = value; } get { return this.refperrelation; } }
        public string Area { set { area = value; } get { return this.area; } }
        public string Food { set { food = value; } get { return this.food; } }
        public string Charge { set { charge = value; } get { return this.charge; } }
        public string Lan1 { set { lan1 = value; } get { return this.lan1; } }
        public string Lan2 { set { lan2 = value; } get { return this.lan2; } }
        public string aval { set { a = value; } get { return this.a; } }



    }
}
