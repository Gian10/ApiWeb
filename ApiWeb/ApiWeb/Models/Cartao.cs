using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Models
{
    public class Cartao
    {
        [Key]
        public int CartaoId { get; set; }
        public string NumeroCartao { get; set; }
        public string NomeCartao { get; set; }
        public string ValidadeCartao { get; set; }
        public string CVVCartao { get; set; }


        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

      

        public Cartao(int cartaoId, string numeroCartao, string nomeCartao, string validadeCartao, string cVVCartao, int usuarioId)
        {
            CartaoId = cartaoId;
            NumeroCartao = numeroCartao;
            NomeCartao = nomeCartao;
            ValidadeCartao = validadeCartao;
            CVVCartao = cVVCartao;
            UsuarioId = usuarioId;
        }
    }
}
