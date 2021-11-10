using back.data.entities.Enterprise;
using back.data.entities.Profile;
using back.data.entities.ProfileScreen;
using back.data.entities.Screen;
using back.data.entities.User;
using Microsoft.EntityFrameworkCore;

namespace back.ioc
{
    public static class EntitiesInjection
    {
        public static ModelBuilder EntitiesConfigurationInjection(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new TelaConfig());
            modelBuilder.ApplyConfiguration(new EmpresaConfig());
            modelBuilder.ApplyConfiguration(new PerfilConfig());
            modelBuilder.ApplyConfiguration(new PerfilTelaConfig());
            return modelBuilder;
        }
    }
}