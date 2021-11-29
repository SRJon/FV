namespace back.domain.entities
{
    interface IUsuarioEmp
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }        

    }
}
