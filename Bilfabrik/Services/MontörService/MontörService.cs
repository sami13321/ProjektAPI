using Bilfabrik.Models;
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

        public List<User> Add(Montör NewUser)
        {

            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return _context.Users.ToList();
        }

    }
}
