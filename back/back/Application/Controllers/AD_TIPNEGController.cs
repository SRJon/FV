using back.data.http;
using back.domain.DTO.AD_TIPNEG;
using back.domain.entities;
using back.domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
 * Controle da exibição AD_TIPNEG do Sankhya somente leitura - CONDIÇÕES DE PAGAMENTO
 * 
 * As condições de pagamento possui relacionamento com o Código do Parceiro CodParc
 * 
 * 
 */
namespace back.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AD_TIPNEGController : ControllerBase
    {
        protected readonly IAD_TIPNEGRepository _AD_TIPNEGRepository;

        public AD_TIPNEGController(IAD_TIPNEGRepository AD_TIPNEGRepository)
        {
            _AD_TIPNEGRepository = AD_TIPNEGRepository;
        }



        /*
         * Consulta todos os registros e quantidade de páginas da exibição AD_TIPNEG
         */
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_TIPNEGDTO>>>> GetAll(int page = 1, int limit = 10)
        {
            var response = new Response<List<AD_TIPNEGDTO>>();
            try
            {
                var result = await _AD_TIPNEGRepository.GetAllPaginateAsync(page, limit);
                response.SetConfig(200);
                response.Data = result.Data;
                response.setHttpAtr(result);
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as Condições de pagamento", false);
            }
            return response.GetResponse();
        }

        /*
         * Consulta do registro pelo código do tipo da consulta "CodTipVenda" da exibição AD_TIPNEG
         */
        [HttpGet("{CodTipVenda}")]
        [Authorize]
        public async Task<ActionResult<Response<AD_TIPNEGDTO>>> GetByCodTipVenda(int CodTipVenda)
        {

            var response = new Response<AD_TIPNEGDTO>();
            try
            {
                AD_TIPNEGDTO result = await this._AD_TIPNEGRepository.GetByCodTipVenda(CodTipVenda);
                if (result != null)
                {
                    response.SetConfig(200);
                    response.Data = result;
                }
                else
                {
                    response.SetConfig(404, "Condição de pagamento não encontrada", false);
                }
            }
            catch (System.Exception e)
            {
                response.SetConfig(400, "Erro ao buscar a Condição de pagamento " + e.Message, false);
            }
            return Ok(response);
        }


        /*
         * Consulta aos registros pela descrição do tipo da condição de pagamento "DescrTipVenda" da exibição AD_TIPNEG
         */
        [HttpGet("Select/")]
        [HttpGet("Select/{DescrTipVenda}")]        
        [Authorize]
        public async Task<ActionResult<IResponse<List<AD_TIPNEGDTO>>>> GetByDescrTipVenda(int page = 1, int limit = 10, string DescrTipVenda = null)        
        {
            var response = new Response<List<AD_TIPNEGDTO>>();
            try
            {
                if (String.IsNullOrEmpty(DescrTipVenda))
                {
                    var result = await _AD_TIPNEGRepository.GetAllPaginateAsync(page, limit);
                    response.SetConfig(200);
                    response.Data = result.Data;
                }
                else
                {
                    var result = await _AD_TIPNEGRepository.GetByDescrTipVendaPaginateAsync(page, limit, DescrTipVenda);
                    response.SetConfig(200);
                    response.Data = result.Data;
                }                
                
            }
            catch (System.Exception)
            {
                response.SetConfig(400, "Erro ao buscar as Condições de pagamento", false);
            }
            return response.GetResponse();
        }

    }
}
