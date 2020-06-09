using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCrud.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string PontoReferencia { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(int id, string rua, string numero, string bairro, string pontoReferencia, string cidade, string estado)
        {
            Id = id;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            PontoReferencia = pontoReferencia;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
