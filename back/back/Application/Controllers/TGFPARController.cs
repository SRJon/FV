using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.SintegraCNPJQuery;
using back.data.entities.TGFContato;
using back.data.http;
using back.domain.DTO.TGFContatoDTO;
using back.domain.DTO.TGFPAR_TGFCTT;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.DTO.TSIBairroDTO;
using back.domain.DTO.TSICidadeDTO;
using back.domain.DTO.TSIEnderecoDTO;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Utils;
using back.MappingConfig;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TGFPARController : ControllerBase
    {
        protected readonly ITGFPARRepository _TGFPARRepository;
        private readonly ISintegraCNPJRepository _SintegraCNPJRepository;
        private readonly ITSIENDRepository _TSIENDRepository;
        private readonly ITSIBAIRepository _TSIBAIRepository;
        private readonly ITSICIDRepository _TSICIDRepository;
        private readonly ITGFCTTRepository _TGFCTTRepository;

        private readonly IMapper _mapper;

        public TGFPARController(ITGFPARRepository TGFPARRepository, ISintegraCNPJRepository SintegraCNPJRepository, ITSIENDRepository TSIENDRepository, ITSIBAIRepository TSIBAIRepository, ITSICIDRepository TSICIDRepository, ITGFCTTRepository TGFCTTRepository)
        {
            _TGFPARRepository = TGFPARRepository;
            _SintegraCNPJRepository = SintegraCNPJRepository;
            _TSIENDRepository = TSIENDRepository;
            _TSIBAIRepository = TSIBAIRepository;
            _TSICIDRepository = TSICIDRepository;
            _TGFCTTRepository = TGFCTTRepository;
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
        }

        [HttpGet]
        [Authorize]

        public async Task<ActionResult<IResponse<List<TGFPARDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<TGFPARDTO>>();
            try
            {
                var result = await _TGFPARRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar os parceiros", false);
            }
            return response.GetResponse();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<IResponse<TGFPARDTO>>> GetById(int id)
        {
            var response = new Response<TGFPARDTO>();


            try
            {
                TGFPARDTO result = await this._TGFPARRepository.GetById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Parceiro n??o encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar parceiro " + e.Message, false);
            }




            return response.GetResponse();
        }
        [HttpGet]
        [Authorize]
        [Route("GetClienteBasicoById")]
        public async Task<ActionResult<IResponse<TGFPARClienteBasicoDTO>>> GetClienteBasicoById(int id)
        {
            var response = new Response<TGFPARClienteBasicoDTO>();


            try
            {
                TGFPARClienteBasicoDTO result = await this._TGFPARRepository.GetClienteBasicoById(id);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Parceiro n??o encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar parceiro " + e.Message, false);
            }




            return response.GetResponse();
        }

        [HttpGet()]
        [Authorize]
        [Route("GetByCNPJ")]
        public async Task<ActionResult<IResponse<bool>>> GetByCNPJ(string cgc_cpf)
        {
            var response = new Response<bool>();
            try
            {
                TGFPARDTO result = await this._TGFPARRepository.GetByCgc_cpf(cgc_cpf);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = true;
                }
                else
                {
                    response.SetConfig(404, "Parceiro n??o encontrado", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar parceiro " + e.Message, false);
            }
            return response.GetResponse();
        }

        [HttpPost]
        [Authorize]
        [Route("BuscarCNPJ")]
        public async Task<ActionResult<IResponse<TGFPARDTO>>> BuscarCNPJ(string cgc_cpf)
        {

            //Fun????o que busca o cnpj na receita e atribui os valores
            var response = new Response<TGFPARDTO>();
            var cliente = await this._TGFPARRepository.GetByCgc_cpf(cgc_cpf);
            if (cliente != null)
            {
                response.SetConfig(400, "Cliente  j?? cadastrado no sistema", false);
            }
            else
            {
                cliente = new TGFPARDTO();
                SintegraCNPJ cnpj = new SintegraCNPJ();
                cnpj = _SintegraCNPJRepository.consultaCNPJSintegraWS(cgc_cpf);
                if (cnpj == null)
                {
                    response.SetConfig(400, "CNPJ inativo na base do sintegra", false);
                }
                else
                {
                    try
                    {
                        try
                        {
                            TSIENDDTO endereco;
                            endereco = await this._TSIENDRepository.GetByNome(cnpj.Logradouro.Substring(cnpj.Logradouro.IndexOf(" ") + 1));
                            if (endereco == null)
                            {
                                endereco = new TSIENDDTO();
                                endereco = _TSIENDRepository.AtribuicaoValoresCliente(endereco, cnpj);
                                var resultEnd = _TSIENDRepository.Create(_mapper.Map<TSIENDDTOCreate>(endereco));
                            }
                            cliente.codend = endereco.Codend;
                            cliente.endereco = cnpj.Logradouro;
                        }
                        catch (System.Exception err)
                        {
                            response.SetConfig(400, "Erro ao criar o endere??o do cliente" + InnerExceptionMessage.InnerExceptionError(err), false);
                        }
                        try
                        {
                            TSIBAIDTO bairro;
                            bairro = await this._TSIBAIRepository.GetByNome(cnpj.Bairro);
                            if (bairro == null)
                            {
                                bairro = new TSIBAIDTO();
                                bairro = _TSIBAIRepository.AtribuicaoValoresCliente(bairro, cnpj);
                                var resultBai = _TSIBAIRepository.Create(_mapper.Map<TSIBAIDTOCreate>(bairro));
                            }
                            cliente.codbai = bairro.CodBai;
                            cliente.bairro = cnpj.Bairro;
                        }
                        catch (System.Exception err)
                        {
                            response.SetConfig(400, "Erro ao criar o bairro do cliente" + InnerExceptionMessage.InnerExceptionError(err), false);
                        }
                        try
                        {
                            TSICIDDTO cidade;
                            cidade = await this._TSICIDRepository.GetByNome(cnpj.Municipio);
                            if (cidade == null)
                            {
                                cidade = new TSICIDDTO();
                                cidade = _TSICIDRepository.AtribuicaoValoresCliente(cidade, cnpj);
                                var resultBai = _TSICIDRepository.Create(_mapper.Map<TSICIDDTOCreate>(cidade));
                            }
                            cliente.codcid = cidade.CodCid;
                            cliente.cidade = cnpj.Municipio;
                            cliente.uf = cnpj.Uf;
                        }
                        catch (System.Exception err)
                        {
                            response.SetConfig(400, "Erro ao criar o cidade  do cliente" + InnerExceptionMessage.InnerExceptionError(err), false);
                        }
                        cliente.codparc = _TGFPARRepository.GetLastIdCreated() + 1;
                        cliente = _TGFPARRepository.AtribuicaoValoresCliente(cliente, cnpj);
                        response.SetConfig(200);
                    }
                    catch (System.Exception e)
                    {
                        response.SetConfig(400, "Erro ao criar o cliente" + InnerExceptionMessage.InnerExceptionError(e), false);
                    }

                    response.Data = cliente;
                }

            }
            return response.GetResponse();
        }
        [HttpPost]
        [Authorize]
        [Route("CriarCliente")]
        public async Task<ActionResult<IResponse<bool>>> CreateClient([FromBody] TGFPAR_TGFCTTDTO clienteComprador)
        {
            var response = new Response<bool>();
            try
            {
                var result = await this._TGFPARRepository.Create(_mapper.Map<TGFPARDTOCreate>(clienteComprador.Cliente));
                if (result)
                {
                    foreach (var comprador in clienteComprador.Compradores)
                    {
                        comprador.Codparc = _TGFPARRepository.GetLastIdCreated();
                        comprador.CodEnd = clienteComprador.Cliente.codend;
                        comprador.CodBai = clienteComprador.Cliente.codbai;
                        comprador.CodBai = clienteComprador.Cliente.codcid;
                        try
                        {
                            result = await this._TGFCTTRepository.Create(comprador);
                            if (!result)
                            {
                                response.SetConfig(404, "Comprador n??o criada", false);
                            }
                        }
                        catch (System.Exception err)
                        {
                            response.SetConfig(400, "Erro ao criar o comprador  do cliente" + InnerExceptionMessage.InnerExceptionError(err), false);
                        }
                    }
                }
                else
                {
                    response.SetConfig(404, "Cliente n??o criado", false);
                }
            }
            catch (System.Exception err)
            {

                response.SetConfig(400, "Erro ao criar o cliente" + InnerExceptionMessage.InnerExceptionError(err), false);
            }
            return response.GetResponse();
        }

    }
}