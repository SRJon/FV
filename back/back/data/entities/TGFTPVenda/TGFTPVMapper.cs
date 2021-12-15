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

            cfg.CreateMap<TGFTPV, TGFTPVDTONF>();
            cfg.CreateMap<TGFTPVDTONF, TGFTPV>();
            cfg.CreateMap<TGFTPVDTO, TGFTPVDTONF>();
            cfg.CreateMap<TGFTPVDTONF, TGFTPVDTO>();
            return cfg;
        }
    }
}