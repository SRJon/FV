using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using back.domain.DTO.TGFTPVendaDTO;

namespace back.data.entities.TGFTPVenda
{
    public static class TGFTPVMapper
    {
        public static IMapperConfigurationExpression CreateTGFTPVMapper(this IMapperConfigurationExpression cfg)
        {

            cfg.CreateMap<TGFTPV, TGFTPVDTO>();
            cfg.CreateMap<TGFTPVDTO, TGFTPV>();
            return cfg;
        }
    }
}