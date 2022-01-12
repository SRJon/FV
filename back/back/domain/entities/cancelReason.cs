namespace back.domain.entities
{
    /// <summary>
    /// Classe de motivo de cancelamento
    /// Relaciona chave com a descrição, ex: "PM" -  PREÇO MENOR
    /// </summary>
    public class cancelReason
    {
        public string key { get; set; }
        public string value { get; set; }

        /// <summary>
        /// Construtor padrão motivo de cancelamento, cria a instância de motivo de cancelamento 
        /// </summary>
        /// <value></value>
        public static cancelReason instance
        {
            get
            {
                return new cancelReason();
            }

        }


        /// <summary>
        /// Função que atribui valores descritivos com chave
        /// </summary>
        /// <param name="value">Valor do motivo, ex: PREÇO MENOR</param>
        /// <param name="text">Chave de busca, ex: "PM"</param>
        /// <returns>cancelReason</returns>
        public cancelReason setAtr(string value, string text)
        {
            this.key = value;
            this.value = text;


            return this;
        }

    }
}