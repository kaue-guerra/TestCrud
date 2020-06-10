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
            if(_context.Fornecedor.Any() || _context.Produto.Any())
            {
                return; // Banco de dados ja tem registros.
            }
            Fornecedor f1 = new Fornecedor(1, "M dias Branco", "(85)3411-2051", "1234567891234","Avenida Perimetral","22", "Mondubim", "Fortaleza", "Ceará");
            Fornecedor f2 = new Fornecedor(2, "Fabrica Fortaleza", "(85)3411-2052", "1234567891235", "Avenida contorno sul", "1200", "Conjunto Esperança", "Fortaleza", "Ceará");
            Fornecedor f3 = new Fornecedor(3, "Camil", "(85)3411-2053", "1234567891236", "Rua Dom Expedito Lopes", "148", "Aldeota", "Fortaleza", "Ceará");

            Produto p1 = new Produto(1, "Arroz", "123", 5, 3.00, 5.00, f1);
            Produto p2 = new Produto(2, "Feijao", "124", 8, 5.00, 8.00, f1);
            Produto p3 = new Produto(3, "Macarrao", "125", 4, 1.50, 2.20, f2);
            Produto p4 = new Produto(4, "Açucar", "126", 12, 1.70, 2.10, f3);
            Produto p5 = new Produto(5, "Farinha", "127", 14, 3.75, 5.00, f3);


            
            _context.Fornecedor.AddRange(f1, f2, f3);
            _context.Produto.AddRange(p1, p2, p3, p4, p5);

            _context.SaveChanges();
        }
    }
}
