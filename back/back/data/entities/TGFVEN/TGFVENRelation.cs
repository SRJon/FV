using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace back.data.entities.TGFVEN
{
    public static class TGFVENRelation
    {
        public static ModelBuilder TGFVENRelationConfiguring(this ModelBuilder modelBuilder)
        {
            #region "Relação entity <> sankhya"
            modelBuilder.Entity<TGFVEN>().Property(p => p.codvend).HasColumnName("CODVEND");
            modelBuilder.Entity<TGFVEN>().Property(p => p.tipvend).HasColumnName("TIPVEND");
            modelBuilder.Entity<TGFVEN>().Property(p => p.apelido).HasColumnName("APELIDO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codparc).HasColumnName("CODPARC");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codreg).HasColumnName("CODREG");
            modelBuilder.Entity<TGFVEN>().Property(p => p.comvenda).HasColumnName("COMVENDA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.comger).HasColumnName("COMGER");
            modelBuilder.Entity<TGFVEN>().Property(p => p.particmeta).HasColumnName("PARTICMETA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codemp).HasColumnName("CODEMP");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codform).HasColumnName("CODFORM");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codger).HasColumnName("CODGER");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codfunc).HasColumnName("CODFUNC");
            modelBuilder.Entity<TGFVEN>().Property(p => p.senha).HasColumnName("SENHA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ativo).HasColumnName("ATIVO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.dtalter).HasColumnName("DTALTER");
            modelBuilder.Entity<TGFVEN>().Property(p => p.tipcalc).HasColumnName("TIPCALC");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codcargahor).HasColumnName("CODCARGAHOR");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codcencuspad).HasColumnName("CODCENCUSPAD");
            modelBuilder.Entity<TGFVEN>().Property(p => p.email).HasColumnName("EMAIL");
            modelBuilder.Entity<TGFVEN>().Property(p => p.perccusvar).HasColumnName("PERCCUSVAR");
            modelBuilder.Entity<TGFVEN>().Property(p => p.diacom).HasColumnName("DIACOM");
            modelBuilder.Entity<TGFVEN>().Property(p => p.comissao2).HasColumnName("COMISSAO2");
            modelBuilder.Entity<TGFVEN>().Property(p => p.tipvalor).HasColumnName("TIPVALOR");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codusu).HasColumnName("CODUSU");
            modelBuilder.Entity<TGFVEN>().Property(p => p.vlrhora).HasColumnName("VLRHORA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.saldodisp).HasColumnName("SALDODISP");
            modelBuilder.Entity<TGFVEN>().Property(p => p.provacresc).HasColumnName("PROVACRESC");
            modelBuilder.Entity<TGFVEN>().Property(p => p.descmax).HasColumnName("DESCMAX");
            modelBuilder.Entity<TGFVEN>().Property(p => p.acrescmax).HasColumnName("ACRESCMAX");
            modelBuilder.Entity<TGFVEN>().Property(p => p.gruporetencao).HasColumnName("GRUPORETENCAO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.codformflex).HasColumnName("CODFORMFLEX");
            modelBuilder.Entity<TGFVEN>().Property(p => p.grupodescvend).HasColumnName("GRUPODESCVEND");
            modelBuilder.Entity<TGFVEN>().Property(p => p.perctroca).HasColumnName("PERCTROCA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.comcm).HasColumnName("COMCM");
            modelBuilder.Entity<TGFVEN>().Property(p => p.rechrextra).HasColumnName("RECHREXTRA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.tipfechcom).HasColumnName("TIPFECHCOM");
            modelBuilder.Entity<TGFVEN>().Property(p => p.atuacomprador).HasColumnName("ATUACOMPRADOR");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_enviaamostra).HasColumnName("AD_ENVIAAMOSTRA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_libvendcliente).HasColumnName("AD_LIBVENDCLIENTE");
            modelBuilder.Entity<TGFVEN>().Property(p => p.nuversao).HasColumnName("NUVERSAO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_12avos_genius_lit).HasColumnName("AD_12AVOS_GENIUS_LIT");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_12avos_genius_mai).HasColumnName("AD_12AVOS_GENIUS_MAI");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_12avos_genius_ale).HasColumnName("AD_12AVOS_GENIUS_ALE");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_codpipedrive).HasColumnName("AD_CODPIPEDRIVE");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_codger).HasColumnName("AD_CODGER");
            modelBuilder.Entity<TGFVEN>().Property(p => p.saldodispcac).HasColumnName("SALDODISPCAC");
            modelBuilder.Entity<TGFVEN>().Property(p => p.provacresccac).HasColumnName("PROVACRESCCAC");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_segmento).HasColumnName("AD_SEGMENTO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_dtrescisao).HasColumnName("AD_DTRESCISAO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_max_med_prazo).HasColumnName("AD_MAX_MED_PRAZO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_prazopag).HasColumnName("AD_PRAZOPAG");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_comissao).HasColumnName("AD_COMISSAO");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_dtmigra).HasColumnName("AD_DTMIGRA");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_nomevend_orig).HasColumnName("AD_NOMEVEND_ORIG");
            modelBuilder.Entity<TGFVEN>().Property(p => p.ad_emaillitoral).HasColumnName("AD_EMAILLITORAL");
            #endregion
            return modelBuilder;
        }
    }
}