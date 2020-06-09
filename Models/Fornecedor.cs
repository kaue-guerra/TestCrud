using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCrud.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string NomeFornecedor { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }

        public Fornecedor(int id, string nomeFornecedor, string telefone, string documento)
        {
            Id = id;
            NomeFornecedor = nomeFornecedor;
            Telefone = telefone;
            Documento = documento;
        }
    }
}
