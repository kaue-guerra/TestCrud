using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCrud.Models;

namespace TesteCrud.Database
{
    public class SeedingService
    {
        private AppDBContext _context;

        public SeedingService(AppDBContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Endereco.Any() || _context.Fornecedor.Any() || _context.Produto.Any())
            {
                return; // Banco de dados ja tem registros.
            }

            Endereco e1 = new Endereco(1, "Rua Dom Expedito Lopes", "2125", "Centro", "Prox a praça", "Fortaleza", "CE");
            Endereco e2 = new Endereco(2, "Rua Pedro Pereira", "25", "Centro", "Prox a estação de trem", "Fortaleza", "CE");
            Endereco e3 = new Endereco(3, "Av Perimetral", "2055", "Mondubim", "Ao lado do campo", "Fortaleza", "CE");

            Fornecedor f1 = new Fornecedor(1, "M dias Branco", "(85)3411-2051", "1234567891234", e3);
            Fornecedor f2 = new Fornecedor(2, "Fabrica Fortaleza", "(85)3411-2052", "1234567891235", e1);
            Fornecedor f3 = new Fornecedor(3, "Camil", "(85)3411-2053", "1234567891236", e2);

            Produto p1 = new Produto(1, "Arroz", "123", 5, 3.00, 5.00, f1);
            Produto p2 = new Produto(2, "Feijao", "124", 8, 5.00, 8.00, f1);
            Produto p3 = new Produto(3, "Macarrao", "125", 4, 1.50, 2.20, f2);
            Produto p4 = new Produto(4, "Açucar", "126", 12, 1.70, 2.10, f3);
            Produto p5 = new Produto(5, "Farinha", "127", 14, 3.75, 5.00, f3);


            _context.Endereco.AddRange(e1, e2, e3);
            _context.Fornecedor.AddRange(f1, f2, f3);
            _context.Produto.AddRange(p1, p2, p3, p4, p5);

            _context.SaveChanges();
        }
    }
}
