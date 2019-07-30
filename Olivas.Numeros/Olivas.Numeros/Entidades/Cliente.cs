using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Olivas.Numeros.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public String Nome{ get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public String Assinatura { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public int NumeroDesafio { get; set; }

        public int NumeroExpressao { get; set; }

        public int NumeroImpressao { get; set; }

        public int NumeroMotivacao { get; set; }

        // arcanos
        // desafio
        // impressão
        // motivação
        // expressão
        // destino
        // missão
        // lições
        // tendencias ocultas
        // respostas subconsiente
        // ciclos de vida 1, 2 e 3
        // momentos decisivos são 4
        // ano pessoal
        // cor
        // numeros harmonicos
        // dias favoraveis
        // valor de cada letra para o nome

    }
}