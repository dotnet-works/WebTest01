using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserRoot
    {
        public IList<User> users { get; set; }
    }

    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string hobby { get; set; }
    }
}
