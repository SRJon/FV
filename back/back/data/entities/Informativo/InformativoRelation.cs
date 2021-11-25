using Microsoft.EntityFrameworkCore;

namespace back.data.entities.Informativo
{
    public static class InformativoRelation
    {
        public static ModelBuilder InformativoRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Informativo>()
                .HasOne(e => e.Empresa);

            return modelBuilder;
        }
    }
}