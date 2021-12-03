using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.http;
using back.domain.DTO.AD_VGFRPVDTO;
using back.domain.Repositories;
using back.infra.Data.Context;
using back.infra.Services.AD_VGFRPVServices;
using back.MappingConfig;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace back.infra.Data.Repositories
{
    public class AD_VGFRPVRepository : ValidPagination, IAD_VGFRPVRepository
    {
        private readonly IMapper _mapper;
        private readonly DbContexts _ctxs;

        public AD_VGFRPVRepository(DbContexts ctxs) : base()
        {
            this._mapper = MapperConfig.MapperConfiguration().CreateMapper();
            _ctxs = ctxs;
        }



        public async Task<Response<List<AD_VGFRPVDTO>>> GetAllPaginateAsync(int page, int limit, int codVendedor)
        {
            var response = new Response<List<AD_VGFRPVDTO>>();
            var contexto = _ctxs.GetSankhya();
            try
            {
                base.ValidPaginate(page, limit);
                var savedSearches = contexto.AD_VGFRPV.Where(u => u.Codvend == codVendedor).Skip(base.skip).Take(base.limit);
                List<AD_VGFRPVDTO> dTOs = new List<AD_VGFRPVDTO>();

                var AD_VGFRPV = await savedSearches.ToListAsync();
                AD_VGFRPV.ForEach(e => dTOs.Add(_mapper.Map<AD_VGFRPVDTO>(e)));
                response.Data = dTOs;
                response.TotalPages = await contexto.AD_VGFRPV.CountAsync();
                response.Page = page;
                response.TotalPages = (response.TotalPages / base.limit) + 1;
                response.TotalPages = response.TotalPages == 0 ? 0 : response.TotalPages;
                response.Success = true;
                response.StatusCode = 200;
                return response;

            }
            catch (System.Exception e)
            {
                response.Data = null;
                response.Message = e.Message;
                response.StatusCode = 400;
                return response;
            }
        }

        public async Task<AD_VGFRPVDTO> GetById(Int16 codVend)
        {
            return _mapper.Map<AD_VGFRPVDTO>(await this._ctxs.
            GetSankhya()
            .GetByIdService(codVend));
        }

        public async Task get_saldoAsync(int codProd)
        {
            // var SQl = " select ROUND((COALESCE((SELECT  LIMCRED FROM TGFPAR PAR WHERE PAR.CODPARC in (	SELECT CODPARCMATRIZ FROM TGFPAR  PAR  WHERE PAR.CODPARC = 4062)),0) - COALESCE(d.JAUSADO,0)),2) Saldo from (SELECT ( SUM(DADOS.PEDIDOS_PENDENTE) + SUM(DADOS.FINANCEIRO)) JAUSADO FROM(SELECT COALESCE((SELECT SUM(C.VLRNOTA)FROM TGFCAB C WHERE C.CODPARC = PAR.CODPARC AND C.TIPMOV = 'P' AND C.PENDENTE = 'S' AND C.STATUSNOTA = 'L'),0) PEDIDOS_PENDENTE ,COALESCE((SELECT SUM(F.VLRDESDOB) FROM TGFFIN F WHERE PROVISAO = 'N' AND RECDESP = 1 AND F.DHBAIXA IS NULL AND F.CODPARC = PAR.CODPARC),0)FINANCEIRO from TGFPAR PAR INNER JOIN TGFPAR MAT ON MAT.CODPARC = PAR.CODPARCMATRIZ where PAR.CODPARCMATRIZ in (SELECT CODPARCMATRIZ FROM TGFPAR  PAR  WHERE PAR.CODPARC = 4062))DADOS) d";
            var SQl = "select top 2 *  from sankhya.tgfcab";
            // decimal saldo = 0;
            // var emailAddressParam = new SqlParameter("@CODPARC", codProd);
            // var passwordParam = new SqlParameter("@SALDO", saldo);
            // var result = this._ctxs.GetSankhya().Database.ExecuteSqlRaw(SQl);
            // // context.Database.ExecuteSqlRaw(        "exec uspInsertCategory @CategoryName,@Description,@Identity out", parameters:        parameters);
            // var b = result;
            // Console.WriteLine(result);


            var connection = this._ctxs.GetSankhya().Database.GetDbConnection();

            using (DbCommand cmd = connection.CreateCommand())
            {
                if (connection.State.Equals(ConnectionState.Closed)) { connection.Open(); }
                cmd.CommandText = SQl;
                try
                {
                    var value = (string)await cmd.ExecuteScalarAsync();

                    Console.WriteLine(value);
                }
                catch (System.Exception e)
                {

                    throw e;
                }
            }




        }


    }
}