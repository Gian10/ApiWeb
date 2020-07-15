using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWeb.Models
{
    public class Cartao
    {

        public int CartaoId { get; set; }
        public string NumCartao { get; set; }
        public string NomeCartao { get; set; }
        public string ValidadeCartao { get; set; }
        public string CVVCartao { get; set; }


        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public Cartao()
        {
        }

        public Cartao(int idCartao, string numCartao, string nomeCartao, string validadeCartao, string cVVCartao, int usuarioId)
        {
            CartaoId = idCartao;
            NumCartao = numCartao;
            NomeCartao = nomeCartao;
            ValidadeCartao = validadeCartao;
            CVVCartao = cVVCartao;
            UsuarioId = usuarioId;
            


        }
    }
}
