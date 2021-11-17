using System;
using back.data.entities.Perfil;
using back.domain.DTO.ScreenDTO;

namespace back.domain.DTO.PerfilTela
{
    public class PerfilTelaDTOUpdateDTO
    {
        public int Id { get; set; }
        public virtual PerfilTelaDTO Perfil { get; set; }
        public virtual TelaDTO Tela { get; set; }
        public Boolean Ins { get; set; }
        public Boolean Dsp { get; set; }
        public Boolean Upd { get; set; }
        public Boolean Dlt { get; set; }
    }
}
