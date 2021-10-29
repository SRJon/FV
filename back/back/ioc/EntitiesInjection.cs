using back.data.entities.User;
using Microsoft.EntityFrameworkCore;

namespace back.ioc
{
    public static class EntitiesInjection
    {
        public static ModelBuilder EntitiesConfigurationInjection(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            return modelBuilder;
        }
    }
}