using SocialNetLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetLibrary.Models
{
    internal class UserManager
    {
        List<User> _users;

        public UserManager(List<User> users)
        {
            _users = users;
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public User GetUser(int id)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == id) return _users[id];
            }
            return null;
        }

        public void DeleteUser(int id)
        {
            for(int i = 0; i < _users.Count; i++)
            {
                if(_users[i].Id == id) _users.RemoveAt(id);
            }

        }

        public void EditUser(int id)
        {
            //реализовать редактирование
        }
    }
}
