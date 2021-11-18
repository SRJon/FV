using System.Collections.Generic;
using back.domain.DTO.ScreenDTO;
using back.domain.entities;

namespace back.domain.DTO.ProfileScreenDTO
{
    public class PerfilTelaDTOProfiless : IPerfilTela
    {
        public int Id { get; set; }
        public int? PerfilId { get; set; }
        public int TelaId { get; set; }
        public bool INS { get; set; }
        public bool DSP { get; set; }
        public bool UPD { get; set; }
        public bool DLT { get; set; }

        public virtual ICollection<TelaDTO> Telas { get; set; }
    }
}