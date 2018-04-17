using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PairsGame.Models;

namespace PairsGame.ViewModels
{
    public class UserViewModel
    {
        public ObservableCollection<User> existentUsers { get; set; }
        public ObservableCollection<string> existentAvatars { get; set; }

        public UserViewModel()
        {
            existentUsers = new ObservableCollection<User>()
            {
                new User() {Name = "moana" , Avatar ="./Resources/Jerry.png"},
                new User() {Name = "joana", Avatar = "./Resources/Baby_Tom.png"}
            };

        }

    }
}
