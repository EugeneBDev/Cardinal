using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardinalProj.Data.Entityes
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public string email { get; set; } = null!;
        public string password { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string login { get; set; } = null!;
    }
}
