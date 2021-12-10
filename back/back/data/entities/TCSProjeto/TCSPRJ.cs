using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.TCSProjetoDTO;
using back.domain.entities;

namespace back.data.entities.TCSProjeto
{
    public class TCSPRJ : ITCSPRJ
    {
        [Key]
        [Column("CODPROJ")]
        public int Codproj { get; set; }
        public int? Codprod { get; set; }
        public string Identificacao { get; set; }
        public string Abreviatura { get; set; }
        public string Ativo { get; set; }
        public short? Grau { get; set; }
        public int? Codprojpai { get; set; }
        public string Analitico { get; set; }
        public string Ad_Blolanc { get; set; }

        public static implicit operator TCSPRJ(TCSPRJDTO v)
        {
            throw new NotImplementedException();
        }
    }
}