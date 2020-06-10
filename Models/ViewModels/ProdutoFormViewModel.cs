using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCrud.Models.ViewModels
{
    public class ProdutoFormViewModel
    {
        public Produto Produto { get; set; }
        public ICollection<Fornecedor> Fornecedores { get; set; }
    }
}
