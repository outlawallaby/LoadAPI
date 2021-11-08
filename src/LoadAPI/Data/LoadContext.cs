using Microsoft.EntityFrameworkCore;
using LoadAPI.Models;

namespace LoadAPI.Data
{
    public class LoadContext: DbContext
    {
        public LoadContext(DbContextOptions<LoadContext>options):base(options)
        {

        }
        public DbSet<Load> LoadItems{get;set;}
    }
}