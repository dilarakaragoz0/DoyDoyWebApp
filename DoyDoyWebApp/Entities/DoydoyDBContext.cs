using Microsoft.EntityFrameworkCore;

namespace DoyDoyWebApp.Entities
{
    public class DoydoyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=WIN-THV5NGOU0U3\SQLEXPRESS; database=DoydoyDBContext; Trusted_Connection =true");
        }
    }
}
