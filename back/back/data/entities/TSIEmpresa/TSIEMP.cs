﻿using back.domain.entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.TSIEmpresa
{
    public class TSIEMP : ITSIEMP
    {
        [Key]
        [Column("CODEMP")]
        public short codemp { get; set; }
        public string nomefantasia { get; set; }
        public string razaosocial { get; set; }
        public string razaoabrev { get; set; }
        public short? codempmatriz { get; set; }
        public int? codend { get; set; }
        public string numend { get; set; }
        public string complemento { get; set; }
        public int codbai { get; set; }
        public int? codcid { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string fax { get; set; }
        public string telex { get; set; }
        public string email { get; set; }
        public string homepage { get; set; }
        public short? numpropr { get; set; }
        public string princtitular { get; set; }
        public string cgc { get; set; }
        public string inscestad { get; set; }
        public string inscmun { get; set; }
        public int? codmun { get; set; }
        public short? natestab { get; set; }
        public short? natjur { get; set; }
        public string ramoativ { get; set; }
        public int? ativecon { get; set; }
        public string regjuntacom { get; set; }
        public DateTime? dtregjunta { get; set; }
        public byte[] logomarca { get; set; }
        public string financeiro { get; set; }
        public string estoque { get; set; }
        public string cargas { get; set; }
        public string comissoes { get; set; }
        public string producao { get; set; }
        public string supdecisao { get; set; }
        public string livrosfiscais { get; set; }
        public DateTime? contabilidade { get; set; }
        public string folhapagto { get; set; }
        public string codcnl { get; set; }
        public string simples { get; set; }
        public int codparc { get; set; }
        public double? limcurva_b { get; set; }
        public double? limcurva_c { get; set; }
        public short? empagrupargol { get; set; }
        public string serienfdes { get; set; }
        public string modelonfdes { get; set; }
        public string cooperativa { get; set; }
        public DateTime? dtconvsoc { get; set; }
        public string dupliv { get; set; }
        public string cpfresp { get; set; }
        public short? codregtrib { get; set; }
        public int? tiposn { get; set; }
        public int codparcdiv { get; set; }
        public string md5paf { get; set; }
        public string razaosocialcompleta { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string simplesnacnauf { get; set; }
        public string dmacodinsp { get; set; }
        public string dmaespecial { get; set; }
        public DateTime? dtencerbalan { get; set; }
        public string servidorsmtp { get; set; }
        public string tiposmtp { get; set; }
        public string usuariosmtp { get; set; }
        public string senhasmtp { get; set; }
        public short portasmtp { get; set; }
        public string segurancasmtp { get; set; }
        public string codqualassin { get; set; }
        public int? codparcresp { get; set; }
        public string sitespecialresp { get; set; }
        public string exigeissqn { get; set; }
        public string regesptribut { get; set; }
        public string rntrc { get; set; }
        public short? classtrib { get; set; }
        public int? cnaeprepon { get; set; }
        public short indcoop { get; set; }
        public short indconstr { get; set; }
        public short? infoobra { get; set; }
        public short? codusu { get; set; }
        public DateTime dhalter { get; set; }
        public short? acdintisenmulta { get; set; }
        public int? codparcempsoft { get; set; }
        public int? codcttparcempsoft { get; set; }
        public short indsitesp { get; set; }
        public int? corempresa { get; set; }
        public int? qtdacessos { get; set; }
        public string envesocial { get; set; }
        public string reciboesocial { get; set; }
        public DateTime? inivalesocial { get; set; }
        public DateTime? fimvalesocial { get; set; }
        public int? ad_parccr { get; set; }
        public string ad_tributa { get; set; }
        public string ad_qualifi { get; set; }
        public string ad_crivarm { get; set; }
        public string ad_regpis { get; set; }
        public byte[] ad_imagem { get; set; }
        public short? indopccp { get; set; }
        public string ad_ignoraaglutinacao { get; set; }
        public int? ad_modevp { get; set; }
        public int? ad_nurbvp { get; set; }
        public int? ad_toppedreal { get; set; }
        public int? ad_toppedvirt { get; set; }
        public int? ad_topentvirt { get; set; }
        public int? ad_topentreal { get; set; }
        public int? ad_conferencia { get; set; }
        public int? ad_topdespadt { get; set; }
        public int? nuversao { get; set; }
        public string usarazaosocial { get; set; }
        public DateTime? dtabertura { get; set; }
        public string empidenotas { get; set; }
        public string produtorrural { get; set; }
        public string cotm { get; set; }


    }
}
