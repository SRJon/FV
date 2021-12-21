﻿using System;

namespace back.domain.entities
{
    public interface ITGFPRO
    {
        public int codprod { get; set; }
        public string descrprod { get; set; }
        public string compldesc { get; set; }
        public string caracteristicas { get; set; }
        public string referencia { get; set; }
        public int codgrupoprod { get; set; }
        public string codvol { get; set; }
        public string marca { get; set; }
        public string localizacao { get; set; }
        public Nullable<short> codipi { get; set; }
        public Nullable<short> classubtrib { get; set; }
        public Nullable<short> codformprec { get; set; }
        public Nullable<double> marglucro { get; set; }
        public Nullable<double> multipvenda { get; set; }
        public Nullable<short> deccusto { get; set; }
        public Nullable<short> decvlr { get; set; }
        public Nullable<short> decqtd { get; set; }
        public Nullable<double> comger { get; set; }
        public Nullable<double> comvend { get; set; }
        public Nullable<double> descmax { get; set; }
        public decimal pesobruto { get; set; }
        public decimal pesoliq { get; set; }
        public Nullable<double> medaux { get; set; }
        public Nullable<short> prazoval { get; set; }
        public Nullable<decimal> agrupmin { get; set; }
        public Nullable<short> qtdemb { get; set; }
        public string alertaestmin { get; set; }
        public string promocao { get; set; }
        public string temicms { get; set; }
        public string temiss { get; set; }
        public string temipivenda { get; set; }
        public string temipicompra { get; set; }
        public string temirf { get; set; }
        public Nullable<double> percirf { get; set; }
        public string teminss { get; set; }
        public double percinss { get; set; }
        public double redbaseinss { get; set; }
        public string usoprod { get; set; }
        public string origprod { get; set; }
        public string tipsubst { get; set; }
        public Nullable<double> codicmsfast { get; set; }
        public string tiplancnota { get; set; }
        public string tipcontest { get; set; }
        public Nullable<short> codtab { get; set; }
        public Nullable<int> codctactb { get; set; }
        public byte[] imagem { get; set; }
        public string ativo { get; set; }
        public Nullable<double> estmax { get; set; }
        public Nullable<double> estmin { get; set; }
        public string apresdetalhe { get; set; }
        public string selecionado { get; set; }
        public string titcontest { get; set; }
        public string liscontest { get; set; }
        public Nullable<int> grupoicms { get; set; }
        public Nullable<decimal> percaumentcusto { get; set; }
        public string local { get; set; }
        public short codmoeda { get; set; }
        public DateTime dtalter { get; set; }
        public string usalocal { get; set; }
        public string homepage { get; set; }
        public Nullable<int> codctactb2 { get; set; }
        public Nullable<int> codctactb3 { get; set; }
        public Nullable<DateTime> temposerv { get; set; }
        public string endimagem { get; set; }
        public short codusu { get; set; }
        public Nullable<int> codparcforn { get; set; }
        public string codvolcompra { get; set; }
        public string codprodroi { get; set; }
        public string grupodescprod { get; set; }
        public string refforn { get; set; }
        public string hrdobrada { get; set; }
        public string icmsgerencia { get; set; }
        public int codnat { get; set; }
        public int codcencus { get; set; }
        public int codproj { get; set; }
        public Nullable<double> m3 { get; set; }
        public string temciap { get; set; }
        public string implaudolote { get; set; }
        public Nullable<int> codgar { get; set; }
        public Nullable<int> codctactb4 { get; set; }
        public string dimensoes { get; set; }
        public Nullable<double> percquebratec { get; set; }
        public Nullable<short> codfiltro { get; set; }
        public string endmodrotulo { get; set; }
        public Nullable<int> codgenero { get; set; }
        public Nullable<int> codlst { get; set; }
        public string padrao { get; set; }
        public string naturezaoperdes { get; set; }
        public Nullable<int> cnae { get; set; }
        public string solcompra { get; set; }
        public string confere { get; set; }
        public string remeter { get; set; }
        public string motivoincexc { get; set; }
        public Nullable<decimal> arredpreco { get; set; }
        public string temcomissao { get; set; }
        public string componobrig { get; set; }
        public string fattotal { get; set; }
        public string nometab { get; set; }
        public string ap1rctego { get; set; }
        public string calculogiro { get; set; }
        public Nullable<double> redbaseirf { get; set; }
        public Nullable<double> altura { get; set; }
        public Nullable<double> largura { get; set; }
        public Nullable<double> espessura { get; set; }
        public string unidade { get; set; }
        public Nullable<short> codformaponta { get; set; }
        public Nullable<short> codcos { get; set; }
        public string confcegapeso { get; set; }
        public Nullable<short> ordcalccustprod { get; set; }
        public string regrawms { get; set; }
        public string grupopis { get; set; }
        public string grupocofins { get; set; }
        public string grupocssl { get; set; }
        public Nullable<short> cstipient { get; set; }
        public Nullable<short> cstipisai { get; set; }
        public string statusincexc { get; set; }
        public string utilizawms { get; set; }
        public string balanca { get; set; }
        public Nullable<short> codpais { get; set; }
        public string rendimento { get; set; }
        public string obsetiqueta { get; set; }
        public Nullable<int> codanp { get; set; }
        public string codautcodif { get; set; }
        public Nullable<int> codprodagrupapt { get; set; }
        public Nullable<int> codprodagrupaptenc { get; set; }
        public string cultura { get; set; }
        public string cientifico { get; set; }
        public Nullable<int> classeagt { get; set; }
        public Nullable<int> grupoquimico { get; set; }
        public Nullable<int> classetox { get; set; }
        public Nullable<int> princativo { get; set; }
        public string formulacao { get; set; }
        public string concentracao { get; set; }
        public string modoaplic { get; set; }
        public string epocaaplic { get; set; }
        public string manejoint { get; set; }
        public Nullable<double> dosagem { get; set; }
        public string voldosagem { get; set; }
        public Nullable<double> dosagempor { get; set; }
        public string voldosagempor { get; set; }
        public string rendimentopr { get; set; }
        public string receituario { get; set; }
        public string exigebenefic { get; set; }
        public string tipoclasseagt { get; set; }
        public string tipogrupoquimico { get; set; }
        public string tipoprincativo { get; set; }
        public string tipoclassetox { get; set; }
        public Nullable<int> grupotransg { get; set; }
        public string geraplaprod { get; set; }
        public Nullable<int> aplicacao { get; set; }
        public Nullable<int> intervalo { get; set; }
        public Nullable<int> carencia { get; set; }
        public Nullable<double> rendimentoha { get; set; }
        public short produtonfe { get; set; }
        public short tipgtinnfe { get; set; }
        public string ncm { get; set; }
        public string codvolplan { get; set; }
        public Nullable<double> descmaxflex { get; set; }
        public Nullable<double> acrescmax { get; set; }
        public string flex { get; set; }
        public Nullable<int> numitemrea { get; set; }
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
        public Nullable<double> tempminima { get; set; }
        public Nullable<double> tempmaxima { get; set; }
        public string controlado { get; set; }
        public string idenportaria { get; set; }
        public string idenotc { get; set; }
        public string idencorrelato { get; set; }
        public string idencosme { get; set; }
        public string prodfalta { get; set; }
        public Nullable<int> codfab { get; set; }
        public int statusmed { get; set; }
        public Nullable<int> codcpr { get; set; }
        public Nullable<short> seqspr { get; set; }
        public Nullable<short> seqsca { get; set; }
        public Nullable<short> seqste { get; set; }
        public Nullable<int> codcat { get; set; }
        public Nullable<int> codter { get; set; }
        public Nullable<int> codpat { get; set; }
        public double mvaajustado { get; set; }
        public string infpureza { get; set; }
        public string fabricante { get; set; }
        public string usastatuslote { get; set; }
        public Nullable<short> tamlote { get; set; }
        public Nullable<short> tamserie { get; set; }
        public string unidminarmaz { get; set; }
        public string origemfat { get; set; }
        public string usacodbarrasqtd { get; set; }
        public string md5paf { get; set; }
        public string valcapm3 { get; set; }
        public string qtdpecafrac { get; set; }
        public string utilordcorte { get; set; }
        public Nullable<int> codprodperda { get; set; }
        public string descrutilbem { get; set; }
        public string impordemcorte { get; set; }
        public double perctroca { get; set; }
        public Nullable<int> corfontconspreco { get; set; }
        public Nullable<int> corfundoconspreco { get; set; }
        public string codvolres { get; set; }
        public Nullable<int> codareasep { get; set; }
        public Nullable<short> identimob { get; set; }
        public Nullable<short> utilimob { get; set; }
        public string temcredpiscofinsdepr { get; set; }
        public Nullable<int> codprodinnatura { get; set; }
        public string utilsmartcard { get; set; }
        public string recupavaria { get; set; }
        public Nullable<double> convervol { get; set; }
        public Nullable<int> lastro { get; set; }
        public Nullable<int> camadas { get; set; }
        public Nullable<double> ordemmedida { get; set; }
        public Nullable<double> aliqicmsintefd { get; set; }
        public string codregmapa { get; set; }
        public string apresform { get; set; }
        public string codbarcomp { get; set; }
        public string temmedicao { get; set; }
        public Nullable<short> codfiltroreq { get; set; }
        public string natbcpiscofins { get; set; }
        public string contarporpeso { get; set; }
        public Nullable<int> codlocalpadrao { get; set; }
        public string permcompprod { get; set; }
        public short codexncm { get; set; }
        public int qtdcst { get; set; }
        public int diascst { get; set; }
        public int perctolvarcst { get; set; }
        public Nullable<double> qtdpedpend { get; set; }
        public Nullable<int> leadtime { get; set; }
        public string valcbglobal { get; set; }
        public string usapontos { get; set; }
        public Nullable<int> codrfa { get; set; }
        public Nullable<decimal> percroyalty { get; set; }
        public string integraeconect { get; set; }
        public Nullable<int> shelflife { get; set; }
        public Nullable<int> shelflifemin { get; set; }
        public string dtvaldif { get; set; }
        public string enqreintegra { get; set; }
        public Nullable<int> diasexpedicao { get; set; }
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
        public Nullable<double> vlrcomerc { get; set; }
        public Nullable<double> vlrparcimpext { get; set; }
        public string codfci { get; set; }
        public string codativreintegra { get; set; }
        public string servparaindust { get; set; }
        public string cat1799spres { get; set; }
        public Nullable<double> aliqnac { get; set; }
        public Nullable<double> aliqimp { get; set; }
        public string descrprodnfe { get; set; }
        public string geracustcompseg { get; set; }
        public double estsegqtd { get; set; }
        public Nullable<short> estsegdias { get; set; }
        public Nullable<DateTime> dtalteresq { get; set; }
        public Nullable<short> lotecompras { get; set; }
        public double estmaxqtd { get; set; }
        public Nullable<short> estmaxdias { get; set; }
        public Nullable<DateTime> dtalteremq { get; set; }
        public double desviomax { get; set; }
        public double arredagrup { get; set; }
        public string aplicasazo { get; set; }
        public double lotecompminimo { get; set; }
        public double agrupcompminimo { get; set; }
        public string usaseriesepwms { get; set; }
        public Nullable<int> codgprod { get; set; }
        public Nullable<int> codparcconsig { get; set; }
        public Nullable<short> topfaturcon { get; set; }
        public string serfaturcon { get; set; }
        public string usalotedtval { get; set; }
        public string usalotedtfab { get; set; }
        public string exigelastrocamadas { get; set; }
        public string fixoagenda { get; set; }
        public string exibcompexpkit { get; set; }
        public Nullable<short> tiporeceitamod21 { get; set; }
        public Nullable<short> natefdcontm410m810 { get; set; }
        public Nullable<int> codprodsubst { get; set; }
        public Nullable<DateTime> dtsubst { get; set; }
        public Nullable<int> codcomp { get; set; }
        public Nullable<double> perctolpesomaior { get; set; }
        public Nullable<double> perctolpesomenor { get; set; }
        public string codvolpesovar { get; set; }
        public string usacontpesovar { get; set; }
        public Nullable<double> perctolpesomaiorsep { get; set; }
        public Nullable<double> perctolpesomenorsep { get; set; }
        public Nullable<double> pct_bf { get; set; }
        public Nullable<short> prz_bf { get; set; }
        public string controlmedic { get; set; }
        public Nullable<short> decvlrent { get; set; }
        public double perccmtfed { get; set; }
        public double perccmtest { get; set; }
        public double perccmtmun { get; set; }
        public string descvenconsul { get; set; }
        public Nullable<int> grupoicms2 { get; set; }
        public Nullable<double> mvapadrao { get; set; }
        public Nullable<double> aliqgeral { get; set; }
        public Nullable<int> codprodsubkit { get; set; }
        public Nullable<int> codconfkit { get; set; }
        public string tipokit { get; set; }
        public Nullable<short> codenqipient { get; set; }
        public Nullable<short> codenqipisai { get; set; }
        public Nullable<int> codespecst { get; set; }
        public string visivelappos { get; set; }
        public string utilizaendflut { get; set; }
        public Nullable<short> maxmulteconect { get; set; }
        public Nullable<int> qtdidentif { get; set; }
        public string tipoidentif { get; set; }
        public Nullable<int> codvtp { get; set; }
        public Nullable<short> modetiqsepwms { get; set; }
        public string impetiqsepwms { get; set; }
        public string nroprocesso { get; set; }
        public Nullable<short> tiposn { get; set; }
        public string armazelote { get; set; }
        public Nullable<short> codservtelecom { get; set; }
        public string temrastrolote { get; set; }
        public string codanvisa { get; set; }
        public string descranp { get; set; }
        public Nullable<double> percmistglp { get; set; }
        public string tipocontagem { get; set; }
        public Nullable<int> codmarca { get; set; }
        public Nullable<double> percmistgnn { get; set; }
        public Nullable<double> percmistgni { get; set; }
        public Nullable<double> vlrpartidaglp { get; set; }
        public Nullable<int> codctactbefd { get; set; }
        public string codcprb { get; set; }
        public string comercializacaoagri { get; set; }
        public Nullable<short> obraconstcivil { get; set; }
        public Nullable<int> classifcessaoobra { get; set; }
        public string tipoinssespecial { get; set; }
        public Nullable<double> percinssespecial { get; set; }
        public string calcdifal { get; set; }
        public Nullable<double> qtdagrupamentomtz { get; set; }
        public Nullable<short> codfiltrocta { get; set; }
        public string indescala { get; set; }
        public string cnpjfabricante { get; set; }
        public string codbenefnauf { get; set; }
        public string codagregacao { get; set; }
        public string ad_codant { get; set; }
        public string ad_cartela { get; set; }
        public Nullable<int> codidcnae { get; set; }
        public string ad_codcorant { get; set; }
        public string forcaexpeconect { get; set; }
        public Nullable<double> ad_gramatura { get; set; }
        public string ad_ca { get; set; }
        public string registrarpeso { get; set; }
        public Nullable<double> ad_custo_ant { get; set; }
        public Nullable<int> ad_codcor { get; set; }
        public Nullable<short> desviomaxtolconfsep { get; set; }
        public Nullable<short> desviomintolconfsep { get; set; }
        public Nullable<int> ad_nrogrupogic { get; set; }
        public string ad_codreceita { get; set; }
        public string servprestter { get; set; }
        public Nullable<double> ad_qtdminima { get; set; }
        public Nullable<double> ad_qtdcaixa { get; set; }
        public Nullable<double> ad_larguratecido { get; set; }
        public Nullable<double> ad_rendimentotecido { get; set; }
        public Nullable<double> ad_gramaturalinear { get; set; }
        public string fragmentalote { get; set; }
        public Nullable<double> percredbaseicmsefet { get; set; }
        public Nullable<int> ad_seqlotequalid { get; set; }
        public string ad_ld { get; set; }
        public Nullable<int> ad_codgrupoprod { get; set; }
        public string ad_bkp_referencia { get; set; }
        public Nullable<int> ad_codprodfam1 { get; set; }
        public Nullable<double> ad_estoque_fiscal { get; set; }
        public Nullable<double> ad_estoque_fisico { get; set; }
        public Nullable<double> ad_custo_ultimp { get; set; }
        public string motisencaoanvisa { get; set; }
        public Nullable<double> ad_bkppeso { get; set; }
        public Nullable<int> ad_ldfilhoreferencia { get; set; }
        public Nullable<int> nuversaoimg { get; set; }
        public Nullable<int> integrafox { get; set; }
        public Nullable<int> nuversao { get; set; }
        public string codnbs { get; set; }
        public string consprodcat42 { get; set; }
        public Nullable<int> ad_codfabricante { get; set; }
        public string ad_componentes { get; set; }
        public string ad_modelo { get; set; }
        public Nullable<double> ad_potnomin_a { get; set; }
        public Nullable<double> ad_isc_a { get; set; }
        public Nullable<double> ad_voc_a { get; set; }
        public Nullable<double> ad_imp_a { get; set; }
        public Nullable<double> ad_vmp_a { get; set; }
        public Nullable<double> ad_pnominca_b { get; set; }
        public Nullable<double> ad_pmaxcc_b { get; set; }
        public Nullable<double> ad_imax_b { get; set; }
        public Nullable<double> ad_iscmax_b { get; set; }
        public Nullable<double> ad_imax2_b { get; set; }
        public Nullable<double> ad_iscmax2_b { get; set; }
        public Nullable<double> ad_vmppt_b { get; set; }
        public Nullable<double> ad_vmpptmax_b { get; set; }
        public Nullable<double> ad_mppt_b { get; set; }
        public Nullable<double> ad_linmax1_b { get; set; }
        public Nullable<double> ad_vmax_c { get; set; }
        public Nullable<double> ad_imaxent_c { get; set; }
        public Nullable<double> ad_imaxsai_c { get; set; }
        public Nullable<double> ad_input_c { get; set; }
        public Nullable<double> ad_output_c { get; set; }
        public string ad_alturamodulo_l { get; set; }
        public string ad_antichamas_e { get; set; }
        public string ad_antifumaca_e { get; set; }
        public string ad_borne_c { get; set; }
        public string ad_tipo_c { get; set; }
        public Nullable<double> ad_classetensao_k { get; set; }
        public Nullable<double> ad_conductconst_e { get; set; }
        public Nullable<double> ad_conductdiameter_e { get; set; }
        public Nullable<double> ad_constnxmm2_e { get; set; }
        public string ad_corcabo_e { get; set; }
        public Nullable<double> ad_correntnom2_d { get; set; }
        public Nullable<double> ad_correntnom3_d { get; set; }
        public Nullable<double> ad_correntnom4_d { get; set; }
        public Nullable<double> ad_correntnom_d { get; set; }
        public Nullable<double> ad_currentcarring_e { get; set; }
        public Nullable<double> ad_diamcabocorrentnom_d { get; set; }
        public Nullable<double> ad_diamcabocorrentnom2_d { get; set; }
        public Nullable<double> ad_diamcabocorrentnom3_d { get; set; }
        public Nullable<double> ad_diamcabocorrentnom4_d { get; set; }
        public Nullable<double> ad_diametroextern_e { get; set; }
        public Nullable<double> ad_diamnomincondutor_e { get; set; }
        public string ad_dpsprotecac_b { get; set; }
        public string ad_dpsprotecdc_b { get; set; }
        public Nullable<double> ad_eficiencia_a { get; set; }
        public Nullable<double> ad_eficmax_b { get; set; }
        public string ad_embalagem_e { get; set; }
        public Nullable<double> ad_espacamento_f { get; set; }
        public Nullable<double> ad_espessuracapa_e { get; set; }
        public Nullable<double> ad_espessuraisolam_e { get; set; }
        public Nullable<double> ad_fp_b { get; set; }
        public Nullable<int> ad_garantia { get; set; }
        public Nullable<double> ad_frequenciatrafo_k { get; set; }
        public Nullable<double> ad_freqsaida_b { get; set; }
        public string ad_fusivel_c { get; set; }
        public Nullable<double> ad_grupoligacao_k { get; set; }
        public Nullable<double> ad_idescmax_c { get; set; }
        public Nullable<double> ad_imax_c { get; set; }
        public Nullable<double> ad_imax3_b { get; set; }
        public Nullable<double> ad_imax4_b { get; set; }
        public Nullable<double> ad_imax5_b { get; set; }
        public Nullable<double> ad_imax6_b { get; set; }
        public Nullable<double> ad_imaxsaida_b { get; set; }
        public Nullable<double> ad_iscmax3_b { get; set; }
        public Nullable<double> ad_iscmax4_b { get; set; }
        public Nullable<double> ad_iscmax5_b { get; set; }
        public Nullable<double> ad_iscmax6_b { get; set; }
        public string ad_materialcaixa_c { get; set; }
        public Nullable<double> ad_material_f { get; set; }
        public Nullable<double> ad_material_h { get; set; }
        public string ad_protetorsurto_c { get; set; }
        public Nullable<double> ad_ncelulas_a { get; set; }
        public Nullable<double> ad_outerdiameter_e { get; set; }
        public Nullable<double> ad_palletcontainer_a { get; set; }
        public Nullable<double> ad_pecacontainer_a { get; set; }
        public Nullable<double> ad_pecapallet_a { get; set; }
        public Nullable<double> ad_potaparente_b { get; set; }
        public Nullable<double> ad_potencia_k { get; set; }
        public Nullable<double> ad_primariotrafo_k { get; set; }
        public string ad_resfriamento_b { get; set; }
        public Nullable<double> ad_resistencemax_e { get; set; }
        public Nullable<double> ad_secundariotrafo_k { get; set; }
        public Nullable<double> ad_bitolacabo_c { get; set; }
        public Nullable<double> ad_secnomincond_e { get; set; }
        public Nullable<double> ad_serieimaxfusivel_a { get; set; }
        public string ad_serie_b { get; set; }
        public Nullable<DateTime> ad_tamanho_h { get; set; }
        public Nullable<double> ad_thdi_b { get; set; }
        public Nullable<double> ad_templimite_d { get; set; }
        public Nullable<double> ad_tempmx_e { get; set; }
        public Nullable<double> ad_tensaooperac_c { get; set; }
        public Nullable<double> ad_tensaopartida_b { get; set; }
        public Nullable<double> ad_tensaosaida_b { get; set; }
        public Nullable<double> ad_tensaonominal_e { get; set; }
        public Nullable<double> ad_tensaonominal_d { get; set; }
        public Nullable<double> ad_tensaomaxdc_b { get; set; }
        public Nullable<double> ad_tensaoresivmax_c { get; set; }
        public string ad_tipo_l { get; set; }
        public string ad_tipoalim_b { get; set; }
        public Nullable<double> ad_tipotelhado_f { get; set; }
        public string ad_tipo_a { get; set; }
        public string ad_seccionamento_c { get; set; }
        public Nullable<double> ad_vin_k { get; set; }
        public Nullable<double> ad_vout_k { get; set; }
        public Nullable<double> ad_tensaomaxsistema_a { get; set; }
        public Nullable<int> ad_codsegmento { get; set; }
        public Nullable<double> incpesobruto { get; set; }
        public Nullable<double> incpesoliquido { get; set; }
        public Nullable<int> nurfe { get; set; }
        public string ad_penvldpro { get; set; }
        public string tipoitemsped { get; set; }
        public string ad_prodavo { get; set; }
        public Nullable<int> ad_codprodgr1 { get; set; }
        public Nullable<int> ad_sublimacao { get; set; }
        public string ad_briefing { get; set; }
        public Nullable<double> ad_alturaalem { get; set; }
        public Nullable<double> ad_larguraalem { get; set; }
        public Nullable<double> ad_espessuraalem { get; set; }
        public Nullable<double> ad_comprimentoalem { get; set; }
        public Nullable<double> ad_capacidadealem { get; set; }
        public Nullable<double> ad_pesoalem { get; set; }
        public Nullable<double> mvaoriginaldrcst { get; set; }
        public Nullable<double> tamanhomediopeca { get; set; }
        public Nullable<int> idgrade { get; set; }
        public Nullable<double> percentseppul { get; set; }
        public string ad_img_estmp { get; set; }
        public Nullable<int> ad_qtdcntr20 { get; set; }
        public Nullable<int> ad_qtdcntr40 { get; set; }
        public string ad_cadprodimportacao { get; set; }
        public string ad_prodreclass { get; set; }
        public Nullable<int> ad_prodreclassref { get; set; }
        public string atunuversao { get; set; }
        public string gradepadrao { get; set; }
        public string obtstantmedent { get; set; }
        public string descproddrcst { get; set; }
        public Nullable<double> aliqfethab { get; set; }
        public string codvolfethab { get; set; }
        public Nullable<double> aliqinternacat42 { get; set; }
        public string participaadrcst { get; set; }
        public Nullable<double> mvaoriginaladrcst { get; set; }
        public Nullable<double> aliqfecop { get; set; }
        public string prodsujfecop { get; set; }
        public string desdesccalcpis { get; set; }
        public Nullable<int> ad_codcarprod { get; set; }
        public Nullable<int> ad_coddirvdprod { get; set; }
        public Nullable<int> ad_codsegprod { get; set; }
        public string gerimpnretreinfaq { get; set; }
        public Nullable<int> ad_codsegamprod { get; set; }
        public string conestorigprod { get; set; }
        public string prodinterno { get; set; }
        public string prodaliadrcst { get; set; }
        public Nullable<short> tiputilcom { get; set; }
        public string calcfustpro { get; set; }
        public string calcfunttelpro { get; set; }
        public string codbardifgtin { get; set; }
        public string codbartribdifgtin { get; set; }


    }
}
