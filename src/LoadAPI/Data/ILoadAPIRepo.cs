using System.Collections.Generic;
using LoadAPI.Models;

namespace LoadAPI.Data
{
    public interface ILoadAPIRepo
    {
        bool SaveChanges();

        IEnumerable<Load> GetAllLoads();
        Load GetLoadById(int id);
        void CreateLoad(Load load);
        void UpdateLoad(Load load);
        void DeleteLoad(Load load);
    }
}