using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFParceiro
{
    public static class TGFPARRelation
    {
        public static ModelBuilder TGFPARRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TGFPAR>()
                .Property(p => p.Codparc)
                .HasColumnName("CODPARC")
                .HasColumnType("INT")
                .IsRequired();

            return modelBuilder;
        }
    }
}