using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCrud.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CodBarras { get; set; }
        public int Quantidade { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int FornecedorId { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, string codBarras, int quantidade, double valorCompra, double valorVenda, Fornecedor fornecedor)
        {
            Id = id;
            Nome = nome;
            CodBarras = codBarras;
            Quantidade = quantidade;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            Fornecedor = fornecedor;
        }
    }


}
