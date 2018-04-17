using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsGame.Models
{
    public  class User
    {

        public User()
        {
            Name = "";
            Avatar = "";
        }

        public User(string name, string avatarPath)
        {
            Name = name;
            Avatar = avatarPath;
        }
        public string Name { get; set; }
        public string Avatar { get; set; }
    }
}
