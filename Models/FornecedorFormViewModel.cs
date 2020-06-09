using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCrud.Models
{
    public class FornecedorFormViewModel
    {
        public Fornecedor Fornecedor { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}
