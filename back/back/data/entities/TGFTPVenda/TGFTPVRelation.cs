using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFTPVenda
{
    public static class TGFTPVRelation
    {
        public static ModelBuilder TGFTPVRelationConfiguring(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TGFTPV>().HasKey(u => new { u.Codtipvenda, u.Dhalter });
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codtipvenda).HasColumnName("CODTIPVENDA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Dhalter).HasColumnName("DHALTER");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Descrtipvenda).HasColumnName("DESCRTIPVENDA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Subtipovenda).HasColumnName("SUBTIPOVENDA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.CodTab).HasColumnName("CODTAB");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Ativo).HasColumnName("ATIVO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Vendamin).HasColumnName("VENDAMIN");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Vendamax).HasColumnName("VENDAMAX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.TaxaJuro).HasColumnName("TAXAJURO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Tiptaxa).HasColumnName("TIPTAXA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Tipjuro).HasColumnName("TIPJURO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Grupoautor).HasColumnName("GRUPOAUTOR");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Valprazocliente).HasColumnName("VALPRAZOCLIENTE");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Baseprazo).HasColumnName("BASEPRAZO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Comissao).HasColumnName("COMISSAO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Fixavenc).HasColumnName("FIXAVENC");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Emiteboleta).HasColumnName("EMITEBOLETA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Emitedupl).HasColumnName("EMITEDUPL");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Aprestransp).HasColumnName("APRESTRANSP");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codctactb_1).HasColumnName("CODCTACTB_1");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codctactb_2).HasColumnName("CODCTACTB_2");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Nunota).HasColumnName("NUNOTA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Baixa).HasColumnName("BAIXA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.DescMax).HasColumnName("DESCMAX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Prazomedmax).HasColumnName("PRAZOMEDMAX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Prazomax).HasColumnName("PRAZOMAX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Somaprazocliente).HasColumnName("SOMAPRAZOCLIENTE");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Podeconsumidor).HasColumnName("PODECONSUMIDOR");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codobspadrao).HasColumnName("CODOBSPADRAO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codusu).HasColumnName("CODUSU");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codformdescmax).HasColumnName("CODFORMDESCMAX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Lucromin).HasColumnName("LUCROMIN");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Descprom).HasColumnName("DESCPROM");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Percminentrada).HasColumnName("PERCMINENTRADA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Nroparcelas).HasColumnName("NROPARCELAS");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Prazomaxpriparc).HasColumnName("PRAZOMAXPRIPARC");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codformdescmaxitens).HasColumnName("CODFORMDESCMAXITENS");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Codtcf).HasColumnName("CODTCF");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Flex).HasColumnName("FLEX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.MargemMin).HasColumnName("MARGEMMIN");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Modelopgto).HasColumnName("MODELOPGTO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.TaxaJurSim).HasColumnName("TAXAJURSIM");
            modelBuilder.Entity<TGFTPV>().Property(p => p.TipoJurSim).HasColumnName("TIPOJURSIM");
            modelBuilder.Entity<TGFTPV>().Property(p => p.PercDesagFlex).HasColumnName("PERCDESAGFLEX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.CompraMax).HasColumnName("COMPRAMAX");
            modelBuilder.Entity<TGFTPV>().Property(p => p.PrazoMin).HasColumnName("PRAZOMIN");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Editasimulacao).HasColumnName("EDITASIMULACAO");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Exptes).HasColumnName("EXPTES");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Expgrs).HasColumnName("EXPGRS");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Txparcadm).HasColumnName("TXPARCADM");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Integraeconect).HasColumnName("INTEGRAECONECT");
            modelBuilder.Entity<TGFTPV>().Property(p => p.FormarECbtoSocin).HasColumnName("FORMARECBTOSOCIN");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Fastusa).HasColumnName("FASTUSA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.VencPrefixped).HasColumnName("VENCPREFIXPED");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Arredprimeiraparc).HasColumnName("ARREDPRIMEIRAPARC");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Truncparcela).HasColumnName("TRUNCPARCELA");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Ad_Librepresentate).HasColumnName("AD_LIBREPRESENTATE");
            modelBuilder.Entity<TGFTPV>().Property(p => p.TimQtdParc).HasColumnName("TIMQTDPARC");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Ad_Codemp).HasColumnName("AD_CODEMP");
            modelBuilder.Entity<TGFTPV>().Property(p => p.Ad_Tipo).HasColumnName("AD_TIPO");

            return modelBuilder;
        }
    }
}