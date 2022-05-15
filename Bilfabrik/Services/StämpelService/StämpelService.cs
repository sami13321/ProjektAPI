using Bilfabrik.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bilfabrik.Services.StämpelService
{
    public class StämpelService: IStämpelService
    {
        private readonly DataContext _context;

        public StämpelService(DataContext context)
        {
            _context = context;
        }

        public bool AddStämpel(Stämpel stämpel, int userid)
        {
            stämpel.Timestamp = DateTime.Now;
            _context.Stämpel.Add(stämpel);
            _context.SaveChanges();

            int id = stämpel.Id;

            _context.StämpeltoUsers.Add(new StämpeltoUser { StämpelId = id, UserId = userid });
            _context.SaveChanges();

            return true;

        }

        
        public StämpeltoUser GetStämpel(int userid)
        {
            return _context.StämpeltoUsers.Where(m => m.UserId == userid).FirstOrDefault();
           
        }

        public bool StämpelUt(int userid)
        {
            var stämpel = _context.StämpeltoUsers.Where(m => m.UserId == userid).FirstOrDefault();
            var stämpelid = stämpel.StämpelId;
            var stämpel2 = _context.Stämpel.Where(m => m.Id == stämpelid).FirstOrDefault();
            stämpel2.OutTimestamp = DateTime.Now;
            _context.Stämpel.Update(stämpel2);
            _context.SaveChanges();
            return true;


        }

    }
}
