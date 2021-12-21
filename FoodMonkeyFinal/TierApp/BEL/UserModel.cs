using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public int phone_number { get; set; }
        public string status { get; set; }
        public Nullable<int> NID_number { get; set; }
        public string area { get; set; }
        public string address { get; set; }
    }
}
