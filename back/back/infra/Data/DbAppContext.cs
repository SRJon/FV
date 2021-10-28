using Microsoft.EntityFrameworkCore;

namespace back.infra
{
    public class DbAppContext : DbContext
    {

        public DbAppContext(DbContextOptions<DbAppContext> options) : base(options)
        {

        }




    }
}