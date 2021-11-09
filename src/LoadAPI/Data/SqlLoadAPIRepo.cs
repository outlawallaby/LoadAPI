using System.Collections.Generic;
using LoadAPI.Models;
using System.Linq;
using System;

namespace LoadAPI.Data
{
    public class SqlLoadAPIRepo : ILoadAPIRepo
    {
        private readonly LoadContext _context;
        public SqlLoadAPIRepo(LoadContext context)
        {
            _context=context;
        }
        public void CreateLoad(Load load)
        {
            if(load==null)
            {
                throw new ArgumentNullException(nameof(load));
            }
            _context.LoadItems.Add(load);
        }

        public void DeleteLoad(Load load)
        {
            if(load ==null)
            {
                throw new ArgumentNullException(nameof(load));
            }
            _context.LoadItems.Remove(load);
        }

        public IEnumerable<Load> GetAllLoads()
        {
            return _context.LoadItems.ToList();
        }

        public Load GetLoadById(int id)
        {
            return _context.LoadItems.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateLoad(Load load)
        {
           
        }
    }
}