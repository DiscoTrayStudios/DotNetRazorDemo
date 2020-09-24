using DotNetRazorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetRazorDemo.Services
{
    public class UserRepository : IUserRepository
    {
        public List<User> _userContext;
        public UserRepository() {
            _userContext = new List<User>();
        }
        public void addUser(User user)
        {
            User newuser = new User()
            {
                id = new Guid(),
                firstName = user.firstName,
                lastName = user.lastName,
                age = user.age,
                city = user.city
            };
            _userContext.Add(newuser);
        }

        public IEnumerable<Class> getAllClasses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> getAllUsers()
        {
            return _userContext;
        }
    }
}
