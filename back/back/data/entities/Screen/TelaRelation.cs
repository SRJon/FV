using Microsoft.EntityFrameworkCore;

namespace back.data.entities.Screen
{
    public static class TelaRelation
    {
        public static ModelBuilder ScreenRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tela>()
                .HasOne(a => a.tela)
                .WithOne()
                .HasForeignKey<Tela>(a => a.TelaId);

            return modelBuilder;
        }
    }
}