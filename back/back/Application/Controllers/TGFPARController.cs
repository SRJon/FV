using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.SintegraCNPJQuery;
using back.data.http;
using back.domain.DTO.TGFParceiroDTO;
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
        private readonly IMapper _mapper;

        public TGFPARController(ITGFPARRepository TGFPARRepository, ISintegraCNPJRepository SintegraCNPJRepository, ITSIENDRepository TSIENDRepository)
        {
            _TGFPARRepository = TGFPARRepository;
            _SintegraCNPJRepository = SintegraCNPJRepository;
            _TSIENDRepository = TSIENDRepository;
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
                    response.SetConfig(404, "Parceiro não encontrado", false);
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
                    response.SetConfig(404, "Parceiro não encontrado", false);
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
        [Route("CreateClient")]
        public async Task<ActionResult<IResponse<bool>>> create(string cgc_cpf)
        {

            var response = new Response<bool>();
            TGFPARDTO cliente = await this._TGFPARRepository.GetByCgc_cpf(cgc_cpf);
            if (cliente != null)
            {
                response.SetConfig(400, "Cliente  já cadastrado no sistema", false);
            }
            else
            {
                cliente = new TGFPARDTO();
                SintegraCNPJ cnpj = new SintegraCNPJ();
                cnpj = _SintegraCNPJRepository.consultaCNPJSintegraWS(cgc_cpf);
                try
                {
                    try
                    {
                        TSIENDDTO endereco = new TSIENDDTO();
                        endereco = await this._TSIENDRepository.GetByNome(cnpj.Logradouro.Substring(cnpj.Logradouro.IndexOf(" ") + 1));
                        if (endereco == null)
                        {
                            endereco = _TSIENDRepository.AtribuicaoValoresCliente(endereco, cnpj);
                            var resultEnd = _TSIENDRepository.Create(endereco);
                        }
                        cliente.Codend = endereco.Codend;
                    }
                    catch (System.Exception err)
                    {
                        response.SetConfig(400, "Erro ao criar o endereço do cliente" + InnerExceptionMessage.InnerExceptionError(err), false);
                        throw;
                    }
                    cliente.Codparc = _TGFPARRepository.GetLastIdCreated();
                    cliente = _TGFPARRepository.AtribuicaoValoresCliente(cliente, cnpj);

                    var result = await this._TGFPARRepository.Create(_mapper.Map<TGFPARDTOCreate>(cliente));
                    response.SetConfig(200);
                }
                catch (System.Exception e)
                {
                    response.SetConfig(400, "Erro ao criar o cliente" + InnerExceptionMessage.InnerExceptionError(e), false);
                }

            }
            return response.GetResponse();
        }

    }
}