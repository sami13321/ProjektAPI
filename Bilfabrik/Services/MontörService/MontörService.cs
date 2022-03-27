using Bilfabrik.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bilfabrik.Services.MontörService
{
    public class MontörService : IMontörService
    {
        private readonly DataContext _context;

        public MontörService(DataContext context)
        {
            _context = context;
        }

        public bool Add(Montör NewUser)
        {
            List<User> användare = _context.Users.ToList();
            foreach (var user in användare)
            {
                if (user.Employee == EmployeeClass.Montör)
                {
                    NewUser.Id = user.Id;
                    NewUser.Namn = user.Name;
                    _context.Montörer.Add(NewUser);
                    _context.SaveChanges();
                  
                }
            }

            return true;
        }







    }
}
