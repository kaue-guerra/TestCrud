using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCrud.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [Display(Name = "Fornecedor")]
        public string NomeFornecedor { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(int id, string nomeFornecedor, string telefone, string documento, string endereco, string numero, string bairro, string cidade, string estado)
        {
            Id = id;
            NomeFornecedor = nomeFornecedor;
            Telefone = telefone;
            Documento = documento;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
