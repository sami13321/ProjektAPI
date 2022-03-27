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

        public bool Add(User NewUser)
        {
            _context.Users.Add(NewUser);
            

            if (NewUser.Employee == EmployeeClass.Montör)
            {

                Montör NewUser1 = new Montör();
                NewUser1.Id = NewUser.Id;
                NewUser1.Namn = NewUser.Name;
                NewUser1.Bana = 0;
                NewUser1.Lag = 0;

                _context.Montörer.Add(NewUser1);
               

            }
            _context.SaveChanges();
            return true;
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
