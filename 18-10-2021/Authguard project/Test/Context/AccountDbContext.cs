using Test.Model;
using Microsoft.EntityFrameworkCore;

namespace Test.Context
{
    public class AccountDbContext : DbContext
    {
        
        public AccountDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Account> accounts { get; set; }
    }
}