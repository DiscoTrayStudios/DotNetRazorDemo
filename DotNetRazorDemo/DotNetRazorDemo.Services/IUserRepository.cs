using DotNetRazorDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetRazorDemo.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> getAllUsers();
        void addUser(User user);

        IEnumerable<Class> getAllClasses();
    }
}
