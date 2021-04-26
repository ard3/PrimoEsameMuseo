using Microsoft.EntityFrameworkCore;

namespace PrimoEsame.Reperti_del_museo
{
    public class BancaDati : DbContext
    {
        public DbSet<Reperto> reperti { get; set; }

        public BancaDati(DbContextOptions options) : base(options)
        { }

    }
}
