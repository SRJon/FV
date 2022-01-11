using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.converters
{
    /// <summary>
    /// Classe de Enum dos motivos e chaves do motivo de cancelamento.
    /// </summary>
    public class cancelReasonEnum
    {

        public List<cancelReason> reasons;
        public static cancelReasonEnum instance
        {
            get
            {
                return new cancelReasonEnum();
            }

        }
        /// <summary>
        /// Construtor padrão da classe de Enum dos motivos
        /// </summary>
        public cancelReasonEnum()
        {
            this.reasons = new List<cancelReason>();

            var current = cancelReason.instance;
            reasons.Add(current.setAtr("PREÇO MENOR NO MERCADO", "PM"));
            reasons.Add(current.setAtr("ATRASO DE CNTR", "AC"));
            reasons.Add(current.setAtr("FALTOU METRAGEM PARA ATENDER O PEDIDO", "FM"));
            reasons.Add(current.setAtr("MERCADO FRACO", "PM"));
            reasons.Add(current.setAtr("PREÇO MENOR NO MERCADO", "MF"));
            reasons.Add(current.setAtr("CLIENTE SEM ESPACO PARA ARMAZENAMENTO", "CS"));
            reasons.Add(current.setAtr("PILOTAGEM NAO APROVADA", "PNA"));
            reasons.Add(current.setAtr("DESISTENCIA PELO CLIENTE FINAL", "DCF"));
            reasons.Add(current.setAtr("DUPLICIDADE", "DUP"));
            reasons.Add(current.setAtr("PEDIDO COM ERRO DE DIGITAÇÃO", "PED"));
            reasons.Add(current.setAtr("REPRESENTANTE VAI REFAZER O PEDIDO", "RRP"));
        }

        /// <summary>
        /// Função que retorna o motivo a partir da chave, ex: PM -> PREÇO MENOR NO MERCADO
        /// </summary>
        /// <param name="key">Chave que encontrará o motivo</param>
        /// <returns></returns>
        public static string keyToValue(string key)
        {
            var current = cancelReasonEnum.instance;
            var result = current.reasons.Where(x => x.key == key).FirstOrDefault();
            if (result != null)
            {
                return result.value;
            }
            return "";
        }

        /// <summary>
        /// Função que retorna a chave a partir do motivo, ex: PREÇO MENOR NO MERCADO ->PM
        /// </summary>
        /// <param name="value">Motivo que encontrará a chave</param>
        /// <returns></returns>
        public static string valueToKey(string value)
        {
            var current = cancelReasonEnum.instance;
            var result = current.reasons.Where(x => x.value == value).FirstOrDefault();
            if (result != null)
            {
                return result.key;
            }
            return "";
        }
    }
}
