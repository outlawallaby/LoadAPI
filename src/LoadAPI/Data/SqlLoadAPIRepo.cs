using System.Collections.Generic;
using LoadAPI.Models;
using System.Linq;

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
            throw new System.NotImplementedException();
        }

        public void DeleteLoad(Load load)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public void UpdateLoad(Load load)
        {
            throw new System.NotImplementedException();
        }
    }
}