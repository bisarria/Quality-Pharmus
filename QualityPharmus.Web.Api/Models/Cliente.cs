using System;

namespace QualityPharmus.Web.Api.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string NumeroCasa { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
    }
}