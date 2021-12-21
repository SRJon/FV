﻿using back.domain.entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.TGFProduto
{
    public class TGFPRO : ITGFPRO
    {
        [Key]
        [Column("CODPROD")]
        public int codprod { get; set; }
        public string descrprod { get; set; }
        public string compldesc { get; set; }
        public string caracteristicas { get; set; }
        public string referencia { get; set; }
        public int codgrupoprod { get; set; }
        public string codvol { get; set; }
        public string marca { get; set; }
        public string localizacao { get; set; }
        public short? codipi { get; set; }
        public short? classubtrib { get; set; }
        public short? codformprec { get; set; }
        public double? marglucro { get; set; }
        public double? multipvenda { get; set; }
        public short? deccusto { get; set; }
        public short? decvlr { get; set; }
        public short? decqtd { get; set; }
        public double? comger { get; set; }
        public double? comvend { get; set; }
        public double? descmax { get; set; }
        public decimal pesobruto { get; set; }
        public decimal pesoliq { get; set; }
        public double? medaux { get; set; }
        public short? prazoval { get; set; }
        public decimal? agrupmin { get; set; }
        public short? qtdemb { get; set; }
        public string alertaestmin { get; set; }
        public string promocao { get; set; }
        public string temicms { get; set; }
        public string temiss { get; set; }
        public string temipivenda { get; set; }
        public string temipicompra { get; set; }
        public string temirf { get; set; }
        public double? percirf { get; set; }
        public string teminss { get; set; }
        public double percinss { get; set; }
        public double redbaseinss { get; set; }
        public string usoprod { get; set; }
        public string origprod { get; set; }
        public string tipsubst { get; set; }
        public double? codicmsfast { get; set; }
        public string tiplancnota { get; set; }
        public string tipcontest { get; set; }
        public short? codtab { get; set; }
        public int? codctactb { get; set; }
        public byte[] imagem { get; set; }
        public string ativo { get; set; }
        public double? estmax { get; set; }
        public double? estmin { get; set; }
        public string apresdetalhe { get; set; }
        public string selecionado { get; set; }
        public string titcontest { get; set; }
        public string liscontest { get; set; }
        public int? grupoicms { get; set; }
        public decimal? percaumentcusto { get; set; }
        public string local { get; set; }
        public short codmoeda { get; set; }
        public DateTime dtalter { get; set; }
        public string usalocal { get; set; }
        public string homepage { get; set; }
        public int? codctactb2 { get; set; }
        public int? codctactb3 { get; set; }
        public DateTime? temposerv { get; set; }
        public string endimagem { get; set; }
        public short codusu { get; set; }
        public int? codparcforn { get; set; }
        public string codvolcompra { get; set; }
        public string codprodroi { get; set; }
        public string grupodescprod { get; set; }
        public string refforn { get; set; }
        public string hrdobrada { get; set; }
        public string icmsgerencia { get; set; }
        public int codnat { get; set; }
        public int codcencus { get; set; }
        public int codproj { get; set; }
        public double? m3 { get; set; }
        public string temciap { get; set; }
        public string implaudolote { get; set; }
        public int? codgar { get; set; }
        public int? codctactb4 { get; set; }
        public string dimensoes { get; set; }
        public double? percquebratec { get; set; }
        public short? codfiltro { get; set; }
        public string endmodrotulo { get; set; }
        public int? codgenero { get; set; }
        public int? codlst { get; set; }
        public string padrao { get; set; }
        public string naturezaoperdes { get; set; }
        public int? cnae { get; set; }
        public string solcompra { get; set; }
        public string confere { get; set; }
        public string remeter { get; set; }
        public string motivoincexc { get; set; }
        public decimal? arredpreco { get; set; }
        public string temcomissao { get; set; }
        public string componobrig { get; set; }
        public string fattotal { get; set; }
        public string nometab { get; set; }
        public string ap1rctego { get; set; }
        public string calculogiro { get; set; }
        public double? redbaseirf { get; set; }
        public double? altura { get; set; }
        public double? largura { get; set; }
        public double? espessura { get; set; }
        public string unidade { get; set; }
        public short? codformaponta { get; set; }
        public short? codcos { get; set; }
        public string confcegapeso { get; set; }
        public short? ordcalccustprod { get; set; }
        public string regrawms { get; set; }
        public string grupopis { get; set; }
        public string grupocofins { get; set; }
        public string grupocssl { get; set; }
        public short? cstipient { get; set; }
        public short? cstipisai { get; set; }
        public string statusincexc { get; set; }
        public string utilizawms { get; set; }
        public string balanca { get; set; }
        public short? codpais { get; set; }
        public string rendimento { get; set; }
        public string obsetiqueta { get; set; }
        public int? codanp { get; set; }
        public string codautcodif { get; set; }
        public int? codprodagrupapt { get; set; }
        public int? codprodagrupaptenc { get; set; }
        public string cultura { get; set; }
        public string cientifico { get; set; }
        public int? classeagt { get; set; }
        public int? grupoquimico { get; set; }
        public int? classetox { get; set; }
        public int? princativo { get; set; }
        public string formulacao { get; set; }
        public string concentracao { get; set; }
        public string modoaplic { get; set; }
        public string epocaaplic { get; set; }
        public string manejoint { get; set; }
        public double? dosagem { get; set; }
        public string voldosagem { get; set; }
        public double? dosagempor { get; set; }
        public string voldosagempor { get; set; }
        public string rendimentopr { get; set; }
        public string receituario { get; set; }
        public string exigebenefic { get; set; }
        public string tipoclasseagt { get; set; }
        public string tipogrupoquimico { get; set; }
        public string tipoprincativo { get; set; }
        public string tipoclassetox { get; set; }
        public int? grupotransg { get; set; }
        public string geraplaprod { get; set; }
        public int? aplicacao { get; set; }
        public int? intervalo { get; set; }
        public int? carencia { get; set; }
        public double? rendimentoha { get; set; }
        public short produtonfe { get; set; }
        public short tipgtinnfe { get; set; }
        public string ncm { get; set; }
        public string codvolplan { get; set; }
        public double? descmaxflex { get; set; }
        public double? acrescmax { get; set; }
        public string flex { get; set; }
        public int? numitemrea { get; set; }
        public string imprimir { get; set; }
        public string confirmaimp { get; set; }
        public string apuraprodepe { get; set; }
        public string indespprodepe { get; set; }
        public int qtdnflaudosint { get; set; }
        public string codtribmuniss { get; set; }
        public string tipcontestwms { get; set; }
        public string listalpm { get; set; }
        public string oneroso { get; set; }
        public string refmercmed { get; set; }
        public string termolabil { get; set; }
        public double? tempminima { get; set; }
        public double? tempmaxima { get; set; }
        public string controlado { get; set; }
        public string idenportaria { get; set; }
        public string idenotc { get; set; }
        public string idencorrelato { get; set; }
        public string idencosme { get; set; }
        public string prodfalta { get; set; }
        public int? codfab { get; set; }
        public int statusmed { get; set; }
        public int? codcpr { get; set; }
        public short? seqspr { get; set; }
        public short? seqsca { get; set; }
        public short? seqste { get; set; }
        public int? codcat { get; set; }
        public int? codter { get; set; }
        public int? codpat { get; set; }
        public double mvaajustado { get; set; }
        public string infpureza { get; set; }
        public string fabricante { get; set; }
        public string usastatuslote { get; set; }
        public short? tamlote { get; set; }
        public short? tamserie { get; set; }
        public string unidminarmaz { get; set; }
        public string origemfat { get; set; }
        public string usacodbarrasqtd { get; set; }
        public string md5paf { get; set; }
        public string valcapm3 { get; set; }
        public string qtdpecafrac { get; set; }
        public string utilordcorte { get; set; }
        public int? codprodperda { get; set; }
        public string descrutilbem { get; set; }
        public string impordemcorte { get; set; }
        public double perctroca { get; set; }
        public int? corfontconspreco { get; set; }
        public int? corfundoconspreco { get; set; }
        public string codvolres { get; set; }
        public int? codareasep { get; set; }
        public short? identimob { get; set; }
        public short? utilimob { get; set; }
        public string temcredpiscofinsdepr { get; set; }
        public int? codprodinnatura { get; set; }
        public string utilsmartcard { get; set; }
        public string recupavaria { get; set; }
        public double? convervol { get; set; }
        public int? lastro { get; set; }
        public int? camadas { get; set; }
        public double? ordemmedida { get; set; }
        public double? aliqicmsintefd { get; set; }
        public string codregmapa { get; set; }
        public string apresform { get; set; }
        public string codbarcomp { get; set; }
        public string temmedicao { get; set; }
        public short? codfiltroreq { get; set; }
        public string natbcpiscofins { get; set; }
        public string contarporpeso { get; set; }
        public int? codlocalpadrao { get; set; }
        public string permcompprod { get; set; }
        public short codexncm { get; set; }
        public int qtdcst { get; set; }
        public int diascst { get; set; }
        public int perctolvarcst { get; set; }
        public double? qtdpedpend { get; set; }
        public int? leadtime { get; set; }
        public string valcbglobal { get; set; }
        public string usapontos { get; set; }
        public int? codrfa { get; set; }
        public decimal? percroyalty { get; set; }
        public string integraeconect { get; set; }
        public int? shelflife { get; set; }
        public int? shelflifemin { get; set; }
        public string dtvaldif { get; set; }
        public string enqreintegra { get; set; }
        public int? diasexpedicao { get; set; }
        public string codbarbalanca { get; set; }
        public double perccmtnac { get; set; }
        public double perccmtimp { get; set; }
        public string notifconf { get; set; }
        public string usaseriefab { get; set; }
        public string tipsernfe { get; set; }
        public string vencompindiv { get; set; }
        public string excluirconf { get; set; }
        public string produzaut { get; set; }
        public string usaimpagrupmin { get; set; }
        public string rastrestoque { get; set; }
        public string impetiqconf { get; set; }
        public double? vlrcomerc { get; set; }
        public double? vlrparcimpext { get; set; }
        public string codfci { get; set; }
        public string codativreintegra { get; set; }
        public string servparaindust { get; set; }
        public string cat1799spres { get; set; }
        public double? aliqnac { get; set; }
        public double? aliqimp { get; set; }
        public string descrprodnfe { get; set; }
        public string geracustcompseg { get; set; }
        public double estsegqtd { get; set; }
        public short? estsegdias { get; set; }
        public DateTime? dtalteresq { get; set; }
        public short? lotecompras { get; set; }
        public double estmaxqtd { get; set; }
        public short? estmaxdias { get; set; }
        public DateTime? dtalteremq { get; set; }
        public double desviomax { get; set; }
        public double arredagrup { get; set; }
        public string aplicasazo { get; set; }
        public double lotecompminimo { get; set; }
        public double agrupcompminimo { get; set; }
        public string usaseriesepwms { get; set; }
        public int? codgprod { get; set; }
        public int? codparcconsig { get; set; }
        public short? topfaturcon { get; set; }
        public string serfaturcon { get; set; }
        public string usalotedtval { get; set; }
        public string usalotedtfab { get; set; }
        public string exigelastrocamadas { get; set; }
        public string fixoagenda { get; set; }
        public string exibcompexpkit { get; set; }
        public short? tiporeceitamod21 { get; set; }
        public short? natefdcontm410m810 { get; set; }
        public int? codprodsubst { get; set; }
        public DateTime? dtsubst { get; set; }
        public int? codcomp { get; set; }
        public double? perctolpesomaior { get; set; }
        public double? perctolpesomenor { get; set; }
        public string codvolpesovar { get; set; }
        public string usacontpesovar { get; set; }
        public double? perctolpesomaiorsep { get; set; }
        public double? perctolpesomenorsep { get; set; }
        public double? pct_bf { get; set; }
        public short? prz_bf { get; set; }
        public string controlmedic { get; set; }
        public short? decvlrent { get; set; }
        public double perccmtfed { get; set; }
        public double perccmtest { get; set; }
        public double perccmtmun { get; set; }
        public string descvenconsul { get; set; }
        public int? grupoicms2 { get; set; }
        public double? mvapadrao { get; set; }
        public double? aliqgeral { get; set; }
        public int? codprodsubkit { get; set; }
        public int? codconfkit { get; set; }
        public string tipokit { get; set; }
        public short? codenqipient { get; set; }
        public short? codenqipisai { get; set; }
        public int? codespecst { get; set; }
        public string visivelappos { get; set; }
        public string utilizaendflut { get; set; }
        public short? maxmulteconect { get; set; }
        public int? qtdidentif { get; set; }
        public string tipoidentif { get; set; }
        public int? codvtp { get; set; }
        public short? modetiqsepwms { get; set; }
        public string impetiqsepwms { get; set; }
        public string nroprocesso { get; set; }
        public short? tiposn { get; set; }
        public string armazelote { get; set; }
        public short? codservtelecom { get; set; }
        public string temrastrolote { get; set; }
        public string codanvisa { get; set; }
        public string descranp { get; set; }
        public double? percmistglp { get; set; }
        public string tipocontagem { get; set; }
        public int? codmarca { get; set; }
        public double? percmistgnn { get; set; }
        public double? percmistgni { get; set; }
        public double? vlrpartidaglp { get; set; }
        public int? codctactbefd { get; set; }
        public string codcprb { get; set; }
        public string comercializacaoagri { get; set; }
        public short? obraconstcivil { get; set; }
        public int? classifcessaoobra { get; set; }
        public string tipoinssespecial { get; set; }
        public double? percinssespecial { get; set; }
        public string calcdifal { get; set; }
        public double? qtdagrupamentomtz { get; set; }
        public short? codfiltrocta { get; set; }
        public string indescala { get; set; }
        public string cnpjfabricante { get; set; }
        public string codbenefnauf { get; set; }
        public string codagregacao { get; set; }
        public string ad_codant { get; set; }
        public string ad_cartela { get; set; }
        public int? codidcnae { get; set; }
        public string ad_codcorant { get; set; }
        public string forcaexpeconect { get; set; }
        public double? ad_gramatura { get; set; }
        public string ad_ca { get; set; }
        public string registrarpeso { get; set; }
        public double? ad_custo_ant { get; set; }
        public int? ad_codcor { get; set; }
        public short? desviomaxtolconfsep { get; set; }
        public short? desviomintolconfsep { get; set; }
        public int? ad_nrogrupogic { get; set; }
        public string ad_codreceita { get; set; }
        public string servprestter { get; set; }
        public double? ad_qtdminima { get; set; }
        public double? ad_qtdcaixa { get; set; }
        public double? ad_larguratecido { get; set; }
        public double? ad_rendimentotecido { get; set; }
        public double? ad_gramaturalinear { get; set; }
        public string fragmentalote { get; set; }
        public double? percredbaseicmsefet { get; set; }
        public int? ad_seqlotequalid { get; set; }
        public string ad_ld { get; set; }
        public int? ad_codgrupoprod { get; set; }
        public string ad_bkp_referencia { get; set; }
        public int? ad_codprodfam1 { get; set; }
        public double? ad_estoque_fiscal { get; set; }
        public double? ad_estoque_fisico { get; set; }
        public double? ad_custo_ultimp { get; set; }
        public string motisencaoanvisa { get; set; }
        public double? ad_bkppeso { get; set; }
        public int? ad_ldfilhoreferencia { get; set; }
        public int? nuversaoimg { get; set; }
        public int? integrafox { get; set; }
        public int? nuversao { get; set; }
        public string codnbs { get; set; }
        public string consprodcat42 { get; set; }
        public int? ad_codfabricante { get; set; }
        public string ad_componentes { get; set; }
        public string ad_modelo { get; set; }
        public double? ad_potnomin_a { get; set; }
        public double? ad_isc_a { get; set; }
        public double? ad_voc_a { get; set; }
        public double? ad_imp_a { get; set; }
        public double? ad_vmp_a { get; set; }
        public double? ad_pnominca_b { get; set; }
        public double? ad_pmaxcc_b { get; set; }
        public double? ad_imax_b { get; set; }
        public double? ad_iscmax_b { get; set; }
        public double? ad_imax2_b { get; set; }
        public double? ad_iscmax2_b { get; set; }
        public double? ad_vmppt_b { get; set; }
        public double? ad_vmpptmax_b { get; set; }
        public double? ad_mppt_b { get; set; }
        public double? ad_linmax1_b { get; set; }
        public double? ad_vmax_c { get; set; }
        public double? ad_imaxent_c { get; set; }
        public double? ad_imaxsai_c { get; set; }
        public double? ad_input_c { get; set; }
        public double? ad_output_c { get; set; }
        public string ad_alturamodulo_l { get; set; }
        public string ad_antichamas_e { get; set; }
        public string ad_antifumaca_e { get; set; }
        public string ad_borne_c { get; set; }
        public string ad_tipo_c { get; set; }
        public double? ad_classetensao_k { get; set; }
        public double? ad_conductconst_e { get; set; }
        public double? ad_conductdiameter_e { get; set; }
        public double? ad_constnxmm2_e { get; set; }
        public string ad_corcabo_e { get; set; }
        public double? ad_correntnom2_d { get; set; }
        public double? ad_correntnom3_d { get; set; }
        public double? ad_correntnom4_d { get; set; }
        public double? ad_correntnom_d { get; set; }
        public double? ad_currentcarring_e { get; set; }
        public double? ad_diamcabocorrentnom_d { get; set; }
        public double? ad_diamcabocorrentnom2_d { get; set; }
        public double? ad_diamcabocorrentnom3_d { get; set; }
        public double? ad_diamcabocorrentnom4_d { get; set; }
        public double? ad_diametroextern_e { get; set; }
        public double? ad_diamnomincondutor_e { get; set; }
        public string ad_dpsprotecac_b { get; set; }
        public string ad_dpsprotecdc_b { get; set; }
        public double? ad_eficiencia_a { get; set; }
        public double? ad_eficmax_b { get; set; }
        public string ad_embalagem_e { get; set; }
        public double? ad_espacamento_f { get; set; }
        public double? ad_espessuracapa_e { get; set; }
        public double? ad_espessuraisolam_e { get; set; }
        public double? ad_fp_b { get; set; }
        public int? ad_garantia { get; set; }
        public double? ad_frequenciatrafo_k { get; set; }
        public double? ad_freqsaida_b { get; set; }
        public string ad_fusivel_c { get; set; }
        public double? ad_grupoligacao_k { get; set; }
        public double? ad_idescmax_c { get; set; }
        public double? ad_imax_c { get; set; }
        public double? ad_imax3_b { get; set; }
        public double? ad_imax4_b { get; set; }
        public double? ad_imax5_b { get; set; }
        public double? ad_imax6_b { get; set; }
        public double? ad_imaxsaida_b { get; set; }
        public double? ad_iscmax3_b { get; set; }
        public double? ad_iscmax4_b { get; set; }
        public double? ad_iscmax5_b { get; set; }
        public double? ad_iscmax6_b { get; set; }
        public string ad_materialcaixa_c { get; set; }
        public double? ad_material_f { get; set; }
        public double? ad_material_h { get; set; }
        public string ad_protetorsurto_c { get; set; }
        public double? ad_ncelulas_a { get; set; }
        public double? ad_outerdiameter_e { get; set; }
        public double? ad_palletcontainer_a { get; set; }
        public double? ad_pecacontainer_a { get; set; }
        public double? ad_pecapallet_a { get; set; }
        public double? ad_potaparente_b { get; set; }
        public double? ad_potencia_k { get; set; }
        public double? ad_primariotrafo_k { get; set; }
        public string ad_resfriamento_b { get; set; }
        public double? ad_resistencemax_e { get; set; }
        public double? ad_secundariotrafo_k { get; set; }
        public double? ad_bitolacabo_c { get; set; }
        public double? ad_secnomincond_e { get; set; }
        public double? ad_serieimaxfusivel_a { get; set; }
        public string ad_serie_b { get; set; }
        public DateTime? ad_tamanho_h { get; set; }
        public double? ad_thdi_b { get; set; }
        public double? ad_templimite_d { get; set; }
        public double? ad_tempmx_e { get; set; }
        public double? ad_tensaooperac_c { get; set; }
        public double? ad_tensaopartida_b { get; set; }
        public double? ad_tensaosaida_b { get; set; }
        public double? ad_tensaonominal_e { get; set; }
        public double? ad_tensaonominal_d { get; set; }
        public double? ad_tensaomaxdc_b { get; set; }
        public double? ad_tensaoresivmax_c { get; set; }
        public string ad_tipo_l { get; set; }
        public string ad_tipoalim_b { get; set; }
        public double? ad_tipotelhado_f { get; set; }
        public string ad_tipo_a { get; set; }
        public string ad_seccionamento_c { get; set; }
        public double? ad_vin_k { get; set; }
        public double? ad_vout_k { get; set; }
        public double? ad_tensaomaxsistema_a { get; set; }
        public int? ad_codsegmento { get; set; }
        public double? incpesobruto { get; set; }
        public double? incpesoliquido { get; set; }
        public int? nurfe { get; set; }
        public string ad_penvldpro { get; set; }
        public string tipoitemsped { get; set; }
        public string ad_prodavo { get; set; }
        public int? ad_codprodgr1 { get; set; }
        public int? ad_sublimacao { get; set; }
        public string ad_briefing { get; set; }
        public double? ad_alturaalem { get; set; }
        public double? ad_larguraalem { get; set; }
        public double? ad_espessuraalem { get; set; }
        public double? ad_comprimentoalem { get; set; }
        public double? ad_capacidadealem { get; set; }
        public double? ad_pesoalem { get; set; }
        public double? mvaoriginaldrcst { get; set; }
        public double? tamanhomediopeca { get; set; }
        public int? idgrade { get; set; }
        public double? percentseppul { get; set; }
        public string ad_img_estmp { get; set; }
        public int? ad_qtdcntr20 { get; set; }
        public int? ad_qtdcntr40 { get; set; }
        public string ad_cadprodimportacao { get; set; }
        public string ad_prodreclass { get; set; }
        public int? ad_prodreclassref { get; set; }
        public string atunuversao { get; set; }
        public string gradepadrao { get; set; }
        public string obtstantmedent { get; set; }
        public string descproddrcst { get; set; }
        public double? aliqfethab { get; set; }
        public string codvolfethab { get; set; }
        public double? aliqinternacat42 { get; set; }
        public string participaadrcst { get; set; }
        public double? mvaoriginaladrcst { get; set; }
        public double? aliqfecop { get; set; }
        public string prodsujfecop { get; set; }
        public string desdesccalcpis { get; set; }
        public int? ad_codcarprod { get; set; }
        public int? ad_coddirvdprod { get; set; }
        public int? ad_codsegprod { get; set; }
        public string gerimpnretreinfaq { get; set; }
        public int? ad_codsegamprod { get; set; }
        public string conestorigprod { get; set; }
        public string prodinterno { get; set; }
        public string prodaliadrcst { get; set; }
        public short? tiputilcom { get; set; }
        public string calcfustpro { get; set; }
        public string calcfunttelpro { get; set; }
        public string codbardifgtin { get; set; }
        public string codbartribdifgtin { get; set; }


    }
}
