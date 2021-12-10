using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TSIEndereco
{
    public static class TSIENDRelation
    {
        public static ModelBuilder TSIENDRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TSIEND>().Property(p => p.Codend).HasColumnName("CODEND");
            modelBuilder.Entity<TSIEND>().Property(p => p.Nomeend).HasColumnName("NOMEEND");
            modelBuilder.Entity<TSIEND>().Property(p => p.Tipo).HasColumnName("TIPO");
            modelBuilder.Entity<TSIEND>().Property(p => p.Dtalter).HasColumnName("DTALTER");
            modelBuilder.Entity<TSIEND>().Property(p => p.Descricaocorreio).HasColumnName("DESCRICAOCORREIO");
            modelBuilder.Entity<TSIEND>().Property(p => p.Codlogradouro).HasColumnName("CODLOGRADOURO");
            modelBuilder.Entity<TSIEND>().Property(p => p.Nuversao).HasColumnName("NUVERSAO");

            return modelBuilder;
        }
    }
}