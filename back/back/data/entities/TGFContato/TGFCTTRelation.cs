using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFContato
{
    public static class TGFCTTRelation
    {
        public static ModelBuilder TGFCTTRelationConfiguring(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TGFCTT>().HasKey(u => new { u.Codparc, u.CodContato });

            modelBuilder.Entity<TGFCTT>().Property(p => p.Codparc).HasColumnName("CODPARC");
            modelBuilder.Entity<TGFCTT>().Property(p => p.CodContato).HasColumnName("CODCONTATO");
            modelBuilder.Entity<TGFCTT>().Property(p => p.NomeContato).HasColumnName("NOMECONTATO");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Apelido).HasColumnName("APELIDO");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Cargo).HasColumnName("CARGO");
            modelBuilder.Entity<TGFCTT>().Property(p => p.CodEnd).HasColumnName("CODEND");
            modelBuilder.Entity<TGFCTT>().Property(p => p.NumEnd).HasColumnName("NUMEND");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Complemento).HasColumnName("COMPLEMENTO");
            modelBuilder.Entity<TGFCTT>().Property(p => p.CodBai).HasColumnName("CODBAI");
            modelBuilder.Entity<TGFCTT>().Property(p => p.CodCid).HasColumnName("CODCID");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Cep).HasColumnName("CEP");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Telefone).HasColumnName("TELEFONE");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Ramal).HasColumnName("RAMAL");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Fax).HasColumnName("FAX");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Email).HasColumnName("EMAIL");
            modelBuilder.Entity<TGFCTT>().Property(p => p.DtNasc).HasColumnName("DTNASC");
            modelBuilder.Entity<TGFCTT>().Property(p => p.CPF).HasColumnName("CPF");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Prioridade).HasColumnName("PRIORIDADE");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Ativo).HasColumnName("ATIVO");
            modelBuilder.Entity<TGFCTT>().Property(p => p.DtCad).HasColumnName("DTCAD");
            modelBuilder.Entity<TGFCTT>().Property(p => p.Celular).HasColumnName("CELULAR");

            return modelBuilder;
        }
    }
}