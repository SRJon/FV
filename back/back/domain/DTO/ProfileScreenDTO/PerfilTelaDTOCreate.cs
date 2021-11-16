using back.domain.entities;

namespace back.domain.DTO.ProfileScreenDTO
{
    public class PerfilTelaDTOCreate
    {
        public int? PerfilId { get; set; }
        public int TelaId { get; set; }
        public bool INS { get; set; }
        public bool DSP { get; set; }
        public bool UPD { get; set; }
        public bool DLT { get; set; }
    }
}