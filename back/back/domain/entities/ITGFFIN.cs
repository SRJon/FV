using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface ITGFFIN
    {
        public int nufin { get; set; }
        public short codemp { get; set; }
        public int numnota { get; set; }
        public string serienota { get; set; }
        public DateTime dtneg { get; set; }
        public string desdobramento { get; set; }
        public DateTime dhmov { get; set; }
        public Nullable<DateTime> dtvencinic { get; set; }
        public Nullable<DateTime> dtvenc { get; set; }
        public Nullable<DateTime> dhbaixa { get; set; }
        public Nullable<DateTime> dtcontab { get; set; }
        public Nullable<DateTime> dtcontabbaixa { get; set; }
        public int codparc { get; set; }
        public short codtipoper { get; set; }
        public DateTime dhtipoper { get; set; }
        public short codbco { get; set; }
        public Nullable<short> codctabcoint { get; set; }
        public int codnat { get; set; }
        public int codcencus { get; set; }
        public Nullable<int> codproj { get; set; }
        public short codvend { get; set; }
        public short codmoeda { get; set; }
        public short codtiptit { get; set; }
        public Nullable<int> numdupl { get; set; }
        public string desdobdupl { get; set; }
        public string nossonum { get; set; }
        public string historico { get; set; }
        public decimal vlrdesdob { get; set; }
        public decimal vlrvendor { get; set; }
        public decimal vlrirf { get; set; }
        public decimal vlriss { get; set; }
        public decimal despcart { get; set; }
        public string issretido { get; set; }
        public decimal vlrdesc { get; set; }
        public decimal vlrmulta { get; set; }
        public decimal vlrinss { get; set; }
        public Nullable<decimal> vlrcheque { get; set; }
        public string tipmulta { get; set; }
        public decimal vlrjuro { get; set; }
        public string tipjuro { get; set; }
        public decimal baseicms { get; set; }
        public decimal aliqicms { get; set; }
        public Nullable<short> codempbaixa { get; set; }
        public short codtipoperbaixa { get; set; }
        public DateTime dhtipoperbaixa { get; set; }
        public decimal vlrbaixa { get; set; }
        public Nullable<int> numremessa { get; set; }
        public string autorizado { get; set; }
        public short recdesp { get; set; }
        public string provisao { get; set; }
        public string origem { get; set; }
        public string tipmarccheq { get; set; }
        public Nullable<int> nunota { get; set; }
        public Nullable<int> nubco { get; set; }
        public Nullable<int> nudev { get; set; }
        public Nullable<int> nureneg { get; set; }
        public string rateado { get; set; }
        public Nullable<DateTime> dtentsai { get; set; }
        public Nullable<decimal> vlrprov { get; set; }
        public Nullable<short> codusubaixa { get; set; }
        public string irfretido { get; set; }
        public string inssretido { get; set; }
        public Nullable<short> carta { get; set; }
        public Nullable<decimal> cartaodesc { get; set; }
        public DateTime dtalter { get; set; }
        public int numcontrato { get; set; }
        public int ordemcarga { get; set; }
        public int codveiculo { get; set; }
        public string codbarra { get; set; }
        public short codusu { get; set; }
        public Nullable<int> sequencia { get; set; }
        public Nullable<decimal> vlrvarcambial { get; set; }
        public string codigobarra { get; set; }
        public string linhadigitavel { get; set; }
        public Nullable<decimal> vlrmultaembut { get; set; }
        public Nullable<decimal> vlrjuroembut { get; set; }
        public Nullable<decimal> vlrdescembut { get; set; }
        public Nullable<double> vlrmoeda { get; set; }
        public Nullable<double> vlrmoedabaixa { get; set; }
        public Nullable<int> nucompens { get; set; }
        public Nullable<int> codcfo { get; set; }
        public Nullable<decimal> vlrmultanegoc { get; set; }
        public Nullable<decimal> vlrjuronegoc { get; set; }
        public Nullable<decimal> vlrmultalib { get; set; }
        public Nullable<decimal> vlrjurolib { get; set; }
        public Nullable<DateTime> dtbaixaprev { get; set; }
        public Nullable<int> numos { get; set; }
        public string naturezaoperdes { get; set; }
        public string serienfdes { get; set; }
        public string modelonfdes { get; set; }
        public Nullable<int> codfunc { get; set; }
        public Nullable<int> codcontato { get; set; }
        public Nullable<int> nuaponta { get; set; }
        public Nullable<int> numbor { get; set; }
        public Nullable<double> m2 { get; set; }
        public string digsafra { get; set; }
        public string nfentseqfix { get; set; }
        public Nullable<int> nfcomplfix { get; set; }
        public Nullable<int> codparcresp { get; set; }
        public string pdd { get; set; }
        public Nullable<short> codusucobr { get; set; }
        public Nullable<int> nuimp { get; set; }
        public string numnfse { get; set; }
        public Nullable<double> vlraliberar { get; set; }
        public Nullable<double> convenio { get; set; }
        public string chavecte { get; set; }
        public string chavecteref { get; set; }
        public string nomeemitente_cmc7 { get; set; }
        public Nullable<int> codrateio { get; set; }
        public Nullable<double> vlrcessao { get; set; }
        public Nullable<int> idlotefdic { get; set; }
        public Nullable<int> nrodoctef { get; set; }
        public Nullable<int> nuped { get; set; }
        public Nullable<short> codbco_cmc7 { get; set; }
        public string agencia_cmc7 { get; set; }
        public string conta_cmc7 { get; set; }
        public string cgc_cpf_cmc7 { get; set; }
        public Nullable<int> codcc { get; set; }
        public string sitespecialresp { get; set; }
        public string exigeissqn { get; set; }
        public string regesptribut { get; set; }
        public string motnaoreterissqn { get; set; }
        public Nullable<double> vlrfatcartao { get; set; }
        public Nullable<int> nuccr { get; set; }
        public Nullable<short> nrolotegnre { get; set; }
        public string statusgnre { get; set; }
        public string rejeicaognre { get; set; }
        public Nullable<int> nuftc { get; set; }
        public string parcreneg { get; set; }
        public string codcartao { get; set; }
        public string tpagnfce { get; set; }
        public Nullable<double> valorpresente { get; set; }
        public Nullable<double> jurosavp { get; set; }
        public string bloqvar { get; set; }
        public Nullable<double> vlrfretenfs { get; set; }
        public Nullable<double> vlrdesccalc { get; set; }
        public Nullable<double> vlrhonor { get; set; }
        public Nullable<double> baseirf { get; set; }
        public Nullable<double> baseinss { get; set; }
        public string moniocorem { get; set; }
        public string nsueconect { get; set; }
        public Nullable<DateTime> dtprazo { get; set; }
        public Nullable<double> vlrtrocoeconect { get; set; }
        public string tipotrocoeconect { get; set; }
        public string recebcartao { get; set; }
        public Nullable<double> abatimento { get; set; }
        public Nullable<double> abatimentocan { get; set; }
        public Nullable<double> vlrdescsspmb { get; set; }
        public string tipoabatsspmb { get; set; }
        public Nullable<int> codcbe { get; set; }
        public string despadvogado { get; set; }
        public string custasprocessuais { get; set; }
        public string depositojudicial { get; set; }
        public string numprocadmjudic { get; set; }
        public Nullable<short> obraconstcivil { get; set; }
        public Nullable<int> classifcessaoobra { get; set; }
        public Nullable<int> codlst { get; set; }
        public Nullable<short> codtrib { get; set; }
        public Nullable<int> codcidinicte { get; set; }
        public Nullable<int> codcidfimcte { get; set; }
        public string codobra { get; set; }
        public Nullable<int> ad_nuant { get; set; }
        public Nullable<DateTime> ad_darfapura { get; set; }
        public string ad_darfcodrec { get; set; }
        public string ad_darfgrtrib { get; set; }
        public string ad_darfrefer { get; set; }
        public string ad_darfperiod { get; set; }
        public Nullable<int> ad_nufinorig { get; set; }
        public string ad_usucart { get; set; }
        public Nullable<double> ad_vlrdb { get; set; }
        public Nullable<double> ad_bx { get; set; }
        public Nullable<double> ad_pr { get; set; }
        public Nullable<double> ad_ab { get; set; }
        public Nullable<double> ad_bxm { get; set; }
        public Nullable<double> ad_out { get; set; }
        public Nullable<double> ad_dc { get; set; }
        public Nullable<double> ad_txadm { get; set; }
        public string chequerastreado_cmc7 { get; set; }
        public Nullable<int> nuchq { get; set; }
        public Nullable<int> codregua { get; set; }
        public Nullable<double> ad_vlrrescont { get; set; }
        public string ad_codfinant { get; set; }
        public Nullable<double> ad_despcart { get; set; }
        public Nullable<double> ad_vlrtotdolar { get; set; }
        public Nullable<int> idunico { get; set; }
        public Nullable<int> ad_nunotaorig { get; set; }
        public Nullable<int> ad_nunotager { get; set; }
        public Nullable<short> seqcaixa { get; set; }
        public Nullable<short> timparcela { get; set; }
        public Nullable<int> timcontratoloc { get; set; }
        public Nullable<int> timnegociacao { get; set; }
        public Nullable<DateTime> timdtimpbol { get; set; }
        public Nullable<DateTime> timdtrepasse { get; set; }
        public Nullable<DateTime> timdhbaixa { get; set; }
        public Nullable<DateTime> timdatadejur { get; set; }
        public Nullable<int> timnumreg { get; set; }
        public string timorigem { get; set; }
        public Nullable<int> timnufinorig { get; set; }
        public Nullable<int> timvendaimv { get; set; }
        public Nullable<int> timrenegimv { get; set; }
        public Nullable<int> timvendalote { get; set; }
        public Nullable<int> timreneglote { get; set; }
        public Nullable<int> timsac { get; set; }
        public string timnomeadvogado { get; set; }
        public Nullable<DateTime> timdhgerrepasse { get; set; }
        public Nullable<int> timcontarep { get; set; }
        public Nullable<int> timimovel { get; set; }
        public Nullable<short> timcontratoadm { get; set; }
        public string timbloqueada { get; set; }
        public Nullable<int> timfechamentoalu { get; set; }
        public Nullable<DateTime> timdtimpbollocal { get; set; }
        public Nullable<int> timfechamento { get; set; }
        public Nullable<int> timrenegcanclote { get; set; }
        public Nullable<int> timcontratoltv { get; set; }
        public Nullable<double> timnunota { get; set; }
        public Nullable<int> timrescisaoltv { get; set; }
        public Nullable<short> timcontalanc { get; set; }
        public string timtxadmgeralu { get; set; }
        public Nullable<int> timfingarantorig { get; set; }
        public Nullable<short> timrepinteligente { get; set; }
        public Nullable<DateTime> timdhgerrepparcial { get; set; }
        public Nullable<DateTime> timdtrepparcial { get; set; }
        public string timrepparcial { get; set; }
        public Nullable<double> timvlrjurocontrato { get; set; }
        public Nullable<double> timvlramortcontrato { get; set; }
        public Nullable<double> timvlrcorrmonet { get; set; }
        public Nullable<int> codiptu { get; set; }
        public string timorigreneg { get; set; }
        public Nullable<int> timrescisaoloc { get; set; }
        public Nullable<int> timtipointermed { get; set; }
        public Nullable<int> ad_nufatura { get; set; }
        public string ad_tipotrib { get; set; }
        public string ad_codguia { get; set; }
        public string ad_mora { get; set; }
        public string ad_nuparcela { get; set; }
        public string ad_dividaativa { get; set; }
        public string ad_competencia { get; set; }
        public Nullable<int> ad_codidtributo { get; set; }
        public Nullable<DateTime> ad_dtincpdd { get; set; }
        public Nullable<short> codobspadrao { get; set; }
        public string ad_botadiantamento { get; set; }
        public Nullable<int> ad_nroprocessvendas { get; set; }
        public Nullable<int> ad_nunotaadiant { get; set; }
        public Nullable<int> ad_tipnegorig { get; set; }
        public string ad_teddrem { get; set; }
        public Nullable<short> codimovelrural { get; set; }
        public string recadiantamentorural { get; set; }
        public Nullable<int> nuckc { get; set; }
        public string ad_prorrog_corona { get; set; }
        public Nullable<DateTime> ad_dtvencorig { get; set; }
        public string ad_status_api_boleto { get; set; }
        public string ad_cod_barra_api_boleto { get; set; }
        public string ad_linha_dig_api_boleto { get; set; }
        public string chavenfegnre { get; set; }
        public Nullable<int> nuantbanc { get; set; }
        public string numdocarrecad { get; set; }
        public Nullable<DateTime> dtentsaiinfo { get; set; }
        public Nullable<DateTime> ad_dhinclusao { get; set; }
        public Nullable<DateTime> refatcon { get; set; }
        public string finconfirmado { get; set; }
        public string descrtpagnfce { get; set; }
        public Nullable<double> ad_vlrprevinss { get; set; }
        public Nullable<double> ad_vlroutent { get; set; }
        public Nullable<double> ad_atualmone { get; set; }
        public string ad_cnpj_beneficiario { get; set; }
        public Nullable<short> ad_codbco { get; set; }
        public string ad_agencia_remessa { get; set; }
        public string ad_conta_remessa { get; set; }
        public string tipapuracao { get; set; }
        public Nullable<double> vlrgnredois { get; set; }
        public string recebido { get; set; }
        public string emvpix_bkp { get; set; }
        public string emvpix { get; set; }
        public string ad_digconta_remessa { get; set; }
    }
}