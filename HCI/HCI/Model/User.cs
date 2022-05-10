using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public UserType Type { get; set; }

        public User()
        {

        }

        public User(string name, string surname, UserType type)
        {
            Name = name;
            Surname = surname;
            Type = type;
        }
    }
}
