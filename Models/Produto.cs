using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCrud.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Código de Barras")]
        public string CodBarras { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Valor de compra")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double ValorCompra { get; set; }
        [Display(Name = "Valor de venda")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
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
