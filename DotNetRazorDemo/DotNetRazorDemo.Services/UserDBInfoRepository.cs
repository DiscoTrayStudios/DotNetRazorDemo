
using DotNetRazorDemo.Models;
using DotNetRazorDemo.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDemo.Services
{
    public class UserDBInfoRepository : IUserRepository
    {
        AppDbContext _dbContext;
        public UserDBInfoRepository(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public void addUser(User user)
        {
            User newUser = new User() {
                firstName = user.firstName,
                lastName = user.lastName,
                age = user.age,
                city = user.city
            };
            _dbContext.Add(newUser);
            _dbContext.SaveChanges();
        }

        public IEnumerable<User> getAllUsers()
        {
            List<User> users = new List<User>();
            foreach (var user in _dbContext.Users)
            {
                users.Add(new User()
                {
                    id = user.id,
                    firstName = user.firstName,
                    lastName = user.lastName,
                    age = user.age,
                    city = user.city
                }) ;
            }
            return users;
        }

        public User deleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public void updateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
