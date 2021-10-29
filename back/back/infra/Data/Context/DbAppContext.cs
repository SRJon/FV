using back.data.entities.User;
using Microsoft.EntityFrameworkCore;

namespace back.infra
{
    public class DbAppContext : DbContext
    {


        public DbAppContext(DbContextOptions<DbAppContext> options)
        : base(options)
        {
        }


        public DbSet<Usuario> Usuario { get; set; }

    }
}