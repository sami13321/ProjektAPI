using Bilfabrik.Models;

namespace Bilfabrik.Services.LagledareService
{
    public class LagledareService : ILagledareService
    {
        private readonly DataContext _context;

        public LagledareService(DataContext context)
        {
            _context = context;
        }

        public bool Add(Lagledare lagledare)
        {
            _context.Lagledare.Add(lagledare);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var lagledare = _context.Lagledare.Find(id);
            if (lagledare == null) return false;
            _context.Lagledare.Remove(lagledare);
            _context.SaveChanges();
            return true;
        }


    }
}
