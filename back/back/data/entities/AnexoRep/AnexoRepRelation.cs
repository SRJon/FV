using Microsoft.EntityFrameworkCore;

namespace back.data.entities.AnexoRep
{
    public static class AnexoRepRelation
    {
        public static ModelBuilder AnexoRepRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnexoRep>()
                .HasOne(e => e.Empresa);

            return modelBuilder;
        }
    }
}