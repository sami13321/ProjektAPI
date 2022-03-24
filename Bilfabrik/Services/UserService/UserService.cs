using Bilfabrik.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bilfabrik.Services
{
    public class UserService : IUserService
    {

        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public User c { get; private set; }

        public List<User> Add(User NewUser)
        {
            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return _context.Users.ToList();
        }

        public List<User> GetallUsers()
        {

            return _context.Users.ToList();

        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(c => c.Id == id);
        }

        public EmployeeClass GetEmployeeClass(int id)
        {
            return _context.Users.FirstOrDefault(c => c.Id == id).Employee;
        }

        public List<User> DeleteUserById(int id)
        {
            _context.Users.Remove(GetUserById(id));
            _context.SaveChanges();
            return _context.Users.ToList();

        }
      
    }
}
