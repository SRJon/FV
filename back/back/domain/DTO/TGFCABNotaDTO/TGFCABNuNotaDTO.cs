using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFTPVenda;
using back.data.entities.TSIEmpresa;
using back.domain.DTO.TGFTPVendaDTO;
using back.domain.DTO.TSIEmpDTO;
using back.domain.entities;

namespace back.domain.DTO.TGFCABNotaDTO
{
    public class TGFCABNuNotaDTO
    {
        public int nunota { get; set; }
        public int numnota { get; set; }

        #region "teste"

        public DateTime? dtfatur { get; set; }//FRONT
        public double? vlrnota { get; set; }//nota

        public double? ad_perccom { get; set; }//FRONT
        public int codparc { get; set; }

        #endregion

        public short codemp { get; set; }
        public virtual TSIEMPDTONF Empresa { get; set; }
        public short codtipvenda { get; set; }
        public DateTime dtalter { get; set; }
        public virtual TGFTPVDTONF TGFTPV { get; set; }

    }
}