using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFTPVenda;
using back.data.entities.TSIEmpresa;
using back.domain.entities;

namespace back.data.entities.TGFCABNota
{
    public class TGFCAB : ITGFCAB
    {
        [Key]
        [Column("NUNOTA")]
        public int nunota { get; set; }
        public int codcencus { get; set; }
        public int numnota { get; set; }
        public string serienota { get; set; }
        public DateTime dtneg { get; set; }
        public DateTime? dtfatur { get; set; }
        public DateTime? dtentsai { get; set; }
        public DateTime? dtval { get; set; }
        public DateTime? dtmov { get; set; }
        public DateTime? dtcontab { get; set; }
        public int? hrmov { get; set; }
        public short codempnegoc { get; set; }
        public int codparc { get; set; }
        public short? codcontato { get; set; }
        public string rateado { get; set; }
        public int codveiculo { get; set; }
        public short codtipoper { get; set; }
        public DateTime dhtipoper { get; set; }
        public string tipmov { get; set; }
        public DateTime dhtipvenda { get; set; }
        public int? numcotacao { get; set; }
        public short codvend { get; set; }
        public double comissao { get; set; }
        public short codmoeda { get; set; }
        public short codobspadrao { get; set; }
        public string observacao { get; set; }
        public double? vlrseg { get; set; }
        public double? vlricmsseg { get; set; }
        public double? vlrdestaque { get; set; }
        public double? vlrjuro { get; set; }
        public double? vlrvendor { get; set; }
        public double? vlroutros { get; set; }
        public double? vlremb { get; set; }
        public double? vlricmsemb { get; set; }
        public double? vlrdescserv { get; set; }
        public double ipiemb { get; set; }
        public string tipipiemb { get; set; }
        public double? vlrdesctot { get; set; }
        public double? vlrdesctotitem { get; set; }
        public double? vlrfrete { get; set; }
        public double? icmsfrete { get; set; }
        public double? baseicmsfrete { get; set; }
        public string tipfrete { get; set; }
        public string cif_fob { get; set; }
        public DateTime? vencfrete { get; set; }
        public double? vlrnota { get; set; }
        public DateTime? vencipi { get; set; }
        public int ordemcarga { get; set; }
        public short? seqcarga { get; set; }
        public int? kmveiculo { get; set; }
        public int codparctransp { get; set; }
        public int? qtdvol { get; set; }
        public string pendente { get; set; }
        public double? baseicms { get; set; }
        public double? vlricms { get; set; }
        public double? baseipi { get; set; }
        public double? vlripi { get; set; }
        public string issretido { get; set; }
        public double? baseiss { get; set; }
        public double? vlriss { get; set; }
        public short? codusu { get; set; }
        public string aprovado { get; set; }
        public double? vlrirf { get; set; }
        public string irfretido { get; set; }
        public string statusnota { get; set; }
        public double? comger { get; set; }
        public string volume { get; set; }
        public int codparcdest { get; set; }
        public double vlrsubst { get; set; }
        public double basesubstit { get; set; }
        public int codproj { get; set; }
        public int numcontrato { get; set; }
        public double baseinss { get; set; }
        public double vlrinss { get; set; }
        public double vlrrepredtot { get; set; }
        public double percdesc { get; set; }
        public int codparcremetente { get; set; }
        public int codparcconsignatario { get; set; }
        public int codparcredespacho { get; set; }
        public string localcoleta { get; set; }
        public string localentrega { get; set; }
        public double? vlrmercadoria { get; set; }
        public double? peso { get; set; }
        public string notascf { get; set; }
        public int codmoddoc { get; set; }
        public int codnat { get; set; }
        public int? codmaq { get; set; }
        public int? codfunc { get; set; }
        public int? numos { get; set; }
        public int? numcf { get; set; }
        public double? vlrfretecpl { get; set; }
        public double troco { get; set; }
        public short? nroredz { get; set; }
        public double? vlrmoeda { get; set; }
        public int? occn48 { get; set; }
        public short? codusuinc { get; set; }
        public int? nutransf { get; set; }
        public int? nurd8 { get; set; }
        public int? codsite { get; set; }
        public double? totalcustoprod { get; set; }
        public double? totalcustoserv { get; set; }
        public int? codcid { get; set; }
        public double? basesubstsemred { get; set; }
        public int? codmotorista { get; set; }
        public string naturezaoperdes { get; set; }
        public string serienfdes { get; set; }
        public string modelonfdes { get; set; }
        public short codusucomprador { get; set; }
        public DateTime? dtprevent { get; set; }
        public int? nunotapedfret { get; set; }
        public double? baseirf { get; set; }
        public double? aliqirf { get; set; }
        public string placa { get; set; }
        public short? ufveiculo { get; set; }
        public double? pesobruto { get; set; }
        public DateTime? hrentsai { get; set; }
        public string antt { get; set; }
        public string lacres { get; set; }
        public int? danfe { get; set; }
        public string chavenfe { get; set; }
        public string numeracaovolumes { get; set; }
        public DateTime? dtenviopmb { get; set; }
        public string tipnotapmb { get; set; }
        public int? numaleatorio { get; set; }
        public string numprotoc { get; set; }
        public DateTime? dhprotoc { get; set; }
        public DateTime? dtenvsuf { get; set; }
        public int? nulotenfe { get; set; }
        public string statusnfe { get; set; }
        public short? tpemisnfe { get; set; }
        public DateTime? dtadiam { get; set; }
        public int? hradiam { get; set; }
        public int? coddoca { get; set; }
        public string digital { get; set; }
        public double? totdispdesc { get; set; }
        public double? basepis { get; set; }
        public double? vlrpis { get; set; }
        public double? basepisst { get; set; }
        public double? vlrpisst { get; set; }
        public double? basecofins { get; set; }
        public double? vlrcofins { get; set; }
        public double? basecofinsst { get; set; }
        public double? vlrcofinsst { get; set; }
        public double? vlrroyalt { get; set; }
        public int? nrocaixa { get; set; }
        public string numregdpec { get; set; }
        public DateTime? dhregdpec { get; set; }
        public short? codempfunc { get; set; }
        public double? vlrindeniz { get; set; }
        public string marca { get; set; }
        public int? tipoptagjnfe { get; set; }
        public short? tpemisnfse { get; set; }
        public int? nulotenfse { get; set; }
        public string numnfse { get; set; }
        public string statusnfse { get; set; }
        public string ufembarq { get; set; }
        public string locembarq { get; set; }
        public short? tpligacao { get; set; }
        public string codgrupotensao { get; set; }
        public short? tpassinante { get; set; }
        public string agrupbol { get; set; }
        public int? nurem { get; set; }
        public string retdatacritica { get; set; }
        public double? qtdbatidas { get; set; }
        public double? percpureza { get; set; }
        public double? percgermin { get; set; }
        public double? fretevlrbruto { get; set; }
        public double? fretevlrdesc { get; set; }
        public double? fretepercdesc { get; set; }
        public double? fretevlrimp { get; set; }
        public double? fretevlrjur { get; set; }
        public double? fretevlrpago { get; set; }
        public short? codvendtec { get; set; }
        public int? numpedido { get; set; }
        public double? vlrindenizdist { get; set; }
        public int? codagenda { get; set; }
        public DateTime? dtref { get; set; }
        public double? fretevlrnegoc { get; set; }
        public int? codprodpermuta { get; set; }
        public int? nrogar { get; set; }
        public string md5paf { get; set; }
        public int? codmoddocnota { get; set; }
        public string cpfcnpjadquirente { get; set; }
        public string nomeadquirente { get; set; }
        public double? vlrsacadolar { get; set; }
        public string numpedido2 { get; set; }
        public int? numcoo { get; set; }
        public int? ordemcargaant { get; set; }
        public string tpambnfe { get; set; }
        public int? przmed { get; set; }
        public int? codresiduo { get; set; }
        public DateTime? dtref2 { get; set; }
        public string vlrliqitemnfe { get; set; }
        public string clascons { get; set; }
        public int? numform { get; set; }
        public DateTime? dtref3 { get; set; }
        public int? codcc { get; set; }
        public string produetloc { get; set; }
        public double? vlrstextranotatot { get; set; }
        public int? nutranemp { get; set; }
        public string sitespecialresp { get; set; }
        public DateTime? dtentsaiinfo { get; set; }
        public string exigeissqn { get; set; }
        public string regesptribut { get; set; }
        public string motnaoreterissqn { get; set; }
        public DateTime? dtremret { get; set; }
        public string libconf { get; set; }
        public int? nuconfatual { get; set; }
        public string statusxtrategie { get; set; }
        public int? codsaf { get; set; }
        public double? vlrfretecalc { get; set; }
        public double? vlrjurodist { get; set; }
        public string notaempenho { get; set; }
        public int? codtpd { get; set; }
        public int? codvtp { get; set; }
        public string cancelado { get; set; }
        public string pesobrutomanual { get; set; }
        public string pesoliquimanual { get; set; }
        public int? nupca { get; set; }
        public string indpresnfce { get; set; }
        public double? m3 { get; set; }
        public double? vlrtotliqitemmoe { get; set; }
        public double vlrdesctotitemmoe { get; set; }
        public string chavecte { get; set; }
        public string prodpred { get; set; }
        public short? tpemiscte { get; set; }
        public string tpambcte { get; set; }
        public string lotacao { get; set; }
        public string statuscte { get; set; }
        public int? numaleatoriocte { get; set; }
        public string numprotoccte { get; set; }
        public DateTime? dhprotoccte { get; set; }
        public int? nulotecte { get; set; }
        public DateTime? dtdeclara { get; set; }
        public int? reboque1 { get; set; }
        public int? reboque2 { get; set; }
        public int? reboque3 { get; set; }
        public string situacaocte { get; set; }
        public string ctelotacao { get; set; }
        public int? codveitracao { get; set; }
        public string codobra { get; set; }
        public string codart { get; set; }
        public int? idiproc { get; set; }
        public string viatransp { get; set; }
        public string tipprocimp { get; set; }
        public string cnpjadquirente { get; set; }
        public string ufadquirente { get; set; }
        public DateTime? dhemissepec { get; set; }
        public int? nunotasub { get; set; }
        public string chavenfse { get; set; }
        public string modentrega { get; set; }
        public double? vlricmsdifaldest { get; set; }
        public double? vlricmsdifalrem { get; set; }
        public decimal? ciot { get; set; }
        public double? vlrfretetotal { get; set; }
        public int? codparctranspfinal { get; set; }
        public double? vlricmsfcp { get; set; }
        public string fusoemissepec { get; set; }
        public double? vlrdescrat { get; set; }
        public string chavenferef { get; set; }
        public int? seqconfirma { get; set; }
        public int? codcontatoentrega { get; set; }
        public int? codcidorigem { get; set; }
        public int? codciddestino { get; set; }
        public int? codcidentrega { get; set; }
        public short? coduforigem { get; set; }
        public short? codufdestino { get; set; }
        public short? codufentrega { get; set; }
        public string classificms { get; set; }
        public short? nufop { get; set; }
        public string codrastreamentoect { get; set; }
        public int? nuodp { get; set; }
        public int? nupedfrete { get; set; }
        public int? codcidprest { get; set; }
        public string formpgtcte { get; set; }
        public double? percdescfob { get; set; }
        public string tpambnfse { get; set; }
        public string termacordnota { get; set; }
        public double? vlrdescqtd { get; set; }
        public double? vlricmsfcpint { get; set; }
        public double? vlrstfcpint { get; set; }
        public double? vlrstfcpintant { get; set; }
        public string cteglobal { get; set; }
        public double? vlrcargaaverb { get; set; }
        public int? codcidinicte { get; set; }
        public int? codcidfimcte { get; set; }
        public int? nucfr { get; set; }
        public string ad_status { get; set; }
        public double? ad_perccom { get; set; }
        public string ad_observacao { get; set; }
        public int? ad_nurevp { get; set; }
        public double? vlrprestafrmm { get; set; }
        public double? vlrafrmm { get; set; }
        public string idnavio { get; set; }
        public string irinnavio { get; set; }
        public string direcaoviag { get; set; }
        public string idbalsa01 { get; set; }
        public string idbalsa02 { get; set; }
        public string idbalsa03 { get; set; }
        public string nfedevrecusa { get; set; }
        public string agrupfinnota { get; set; }
        public int? ad_nuprog { get; set; }
        public double? ad_vlracresdec { get; set; }
        public string confirmnotafat { get; set; }
        public string ad_ligarantes { get; set; }
        public int? ad_pedidoid { get; set; }
        public string permaltercentral { get; set; }
        public short? codguf { get; set; }
        public int? ad_nunota { get; set; }
        public string ad_redp { get; set; }
        public string ad_redp_razao { get; set; }
        public string ad_redp_cnpj { get; set; }
        public string ad_redp_tel { get; set; }
        public double? ad_vlrfretecalc { get; set; }
        public int? ad_nunotaconf { get; set; }
        public string ad_classepedido { get; set; }
        public double? ad_vlrfretetotal { get; set; }
        public double? ad_vlrseg2 { get; set; }
        public double? ad_vlrfretepf { get; set; }
        public string ad_comprador { get; set; }
        public int? ad_nusoldev { get; set; }
        public int? esu_bkp_pendente { get; set; }
        public string esu_bkp_pendente_dois { get; set; }
        public DateTime? ad_dt_confirmacao { get; set; }
        public double? ad_calccommanual { get; set; }
        public double? vlrrepredtotsemdesc { get; set; }
        public string ad_temremessa { get; set; }
        public string finalizadofox { get; set; }
        public string ad_novocliente_cnpj { get; set; }
        public int? ad_numped_mercos { get; set; }
        public int? numcupomeconect { get; set; }
        public int? ad_pedidoidfotus { get; set; }
        public string ad_integrador { get; set; }
        public double? ad_promvendas { get; set; }
        public DateTime? dtextempk280 { get; set; }
        public int? timnufinorig { get; set; }
        public int? timcontratovenda { get; set; }
        public string timorigem { get; set; }
        public int? timcontratoltv { get; set; }
        public int? timnunotamod { get; set; }
        public int? ad_nunota_ld { get; set; }
        public string ad_nova_conf { get; set; }
        public DateTime? ad_dt_nova_conf { get; set; }
        public double? ad_freteint { get; set; }
        public double? ad_perccomcompra { get; set; }
        public double? ad_taxaexport { get; set; }
        public int? ad_nrocrm { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public double? ad_totnotayuan { get; set; }
        public int? codparcdescargamdfe { get; set; }
        public short? coddocarrecad { get; set; }
        public string numdocarrecad { get; set; }
        public string premiacaoestadual { get; set; }
        public int? ad_pedidoidfotusorig { get; set; }
        public int? ad_codparcred { get; set; }
        public int? ad_codparc { get; set; }
        public string ad_obsnfered { get; set; }
        public string nfseid { get; set; }
        public string ad_vendadireta { get; set; }
        public string ad_cotar_frete { get; set; }
        public DateTime? ad_dhenvcotfrete { get; set; }
        public int? ad_codsacf { get; set; }
        public int? codparcdepo { get; set; }
        public string ad_embalagem { get; set; }
        public string ad_temadiantamento { get; set; }
        public int? codcheckout { get; set; }
        public int? ad_codinv { get; set; }
        public int? ad_codsinist { get; set; }
        public double? ad_potencia_ger { get; set; }
        public DateTime? ad_database { get; set; }
        public int? ad_pvfnrofotusorig { get; set; }
        public int? ad_pvfnrofotusseq { get; set; }
        public string ad_pvfmotivodupl { get; set; }
        public string ad_pvfnovoproc { get; set; }
        public double? vlrfethab { get; set; }
        public double? baseicmsat { get; set; }
        public double? vlricmsat { get; set; }
        public double? valordesonpiscofins { get; set; }
        public string disdesautimpemb { get; set; }
        public int? nunotaorigcorte { get; set; }
        public string ad_ordemcompra { get; set; }
        public DateTime? ad_dtfat { get; set; }
        public string ad_temordemcomp { get; set; }
        public string ad_temdtfat { get; set; }
        public int? ad_boldiasvenc { get; set; }
        public DateTime? ad_dtcartao { get; set; }
        public int? codinterm { get; set; }
        public string intermed { get; set; }
        public double? vlrrepredst { get; set; }
        public double? baseicmsstfrete { get; set; }
        public double? icmsstfrete { get; set; }
        public decimal? iddescparceria { get; set; }
        public decimal? vlrdescparceria { get; set; }
        public decimal? clienteidparceria { get; set; }
        public decimal? idpontuacaoparceria { get; set; }
        public string fistel { get; set; }
        public int? numcstc { get; set; }
        public int? qtdusu { get; set; }
        public int? numtermtel { get; set; }
        public short? tipclienteservcom { get; set; }
        public string md5modcomtel { get; set; }
        public string indnegmodal { get; set; }
        public int? codparcretirada { get; set; }


        public short codemp { get; set; }
        [ForeignKey("codemp")]
        public virtual TSIEMP Empresa { get; set; }
        [Column(Order = 0)]
        public short codtipvenda { get; set; }
        [Column(Order = 1)]
        public DateTime dtalter { get; set; }

        [ForeignKey("codtipvenda,dtalter")]
        public virtual TGFTPV TGFTPV { get; set; }
    }
}