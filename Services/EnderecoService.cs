using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCrud.Database;
using TesteCrud.Models;

namespace TesteCrud.Services
{
    public class EnderecoService
    {
        private readonly AppDBContext _context;

        public EnderecoService (AppDBContext context)
        {
            _context = context;
        }

        public List<Endereco> FindAll()
        {
            return _context.Endereco.OrderBy(x => x.Id).ToList();
        }
    }
}
