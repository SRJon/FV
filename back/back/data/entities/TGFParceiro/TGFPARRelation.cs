using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFParceiro
{
    public static class TGFPARRelation
    {
        public static ModelBuilder TGFPARRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TGFPAR>().Property(p => p.Codparc).HasColumnName("CODPARC");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Codvend).HasColumnName("CODVEND");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Nomeparc).HasColumnName("NOMEPARC");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Razaosocial).HasColumnName("RAZAOSOCIAL");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Tippessoa).HasColumnName("TIPPESSOA");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Codparcmatriz).HasColumnName("CODPARCMATRIZ");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Codend).HasColumnName("CODEND");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Numend).HasColumnName("NUMEND");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Complemento).HasColumnName("COMPLEMENTO");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Codbai).HasColumnName("CODBAI");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Codcid).HasColumnName("CODCID");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Codreg).HasColumnName("CODREG");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Cep).HasColumnName("CEP");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Caixapostal).HasColumnName("CAIXAPOSTAL");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Telefone).HasColumnName("TELEFONE");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Ramal).HasColumnName("RAMAL");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Fax).HasColumnName("FAX");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Email).HasColumnName("EMAIL");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Identinscestad).HasColumnName("IDENTINSCESTAD");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Inscestadnauf).HasColumnName("INSCESTADNAUF");
            modelBuilder.Entity<TGFPAR>().Property(p => p.Cgc_cpf).HasColumnName("CGC_CPF");

            return modelBuilder;
        }
    }
}