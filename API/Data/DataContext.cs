using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {}
            public DbSet<SystemUser> SystemUsers {get;set;}
            public DbSet<Worker> Workers {get;set;}        
    }
}