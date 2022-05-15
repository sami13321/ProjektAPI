using Bilfabrik.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilfabrik.Services
{
    public class MontörService : IMontörService
    {
        private readonly DataContext _context;

        public MontörService(DataContext context)
        {
            _context = context;
        }



        public Montör GetMontörbyId(int id)
        {
            return _context.Montörer.Find(id);

        }


        public bool DeleteMontör(int id)
        {
            var montör = GetMontörbyId(id);
            if (montör != null)
            {
                _context.Montörer.Remove(montör);
                _context.SaveChanges();
            }
            return true;
        }


        public bool UpdateMontör(int id, Montör user)
        {
            var montör = GetMontörbyId(id);
            if (montör != null)
            {
                montör.Bana = user.Bana;
                montör.Lag = user.Lag;
                montör.Name = user.Name;
                _context.Montörer.Update(montör);
                _context.SaveChanges();
            }
            return true;
        }


        public List<Montör> GetAllMontörer()
        {
            return _context.Montörer.ToList();
        }

        //get montör by name
        public Montör GetMontörByName(string name)
        {
            return _context.Montörer.Where(m => m.Name == name).FirstOrDefault();
        }



    }
}
