using Bilfabrik.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bilfabrik.Services
{
    public class UserService : IUserService
    {
        private static List<User> users = new List<User>
       {
           new User { Id= 1, Name = "Sami", Age =  18, Email = "sami03@live.se"},
           new User { Id= 2, Name = "Alex", Age = 27, Email = "Alex@gmail.se", Employee= EmployeeClass.Produktionsledare}
       };

        public User c { get; private set; }

        public List<User> Add(User NewUser)
        {
            users.Add(NewUser);
            return users;
        }

        public List<User> GetallUsers()
        {

            return users;

        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(c => c.Id == id);
        }

      
    }
}
