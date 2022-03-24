using Bilfabrik.Models;
using System.Collections.Generic;

namespace Bilfabrik.Services
{
    public interface IUserService
    {

        List<User> GetallUsers();

        User GetUserById(int id);

        List<User> Add(User NewUser);

        EmployeeClass GetEmployeeClass(int id);

        List<User> DeleteUserById(int id);



    }
}
