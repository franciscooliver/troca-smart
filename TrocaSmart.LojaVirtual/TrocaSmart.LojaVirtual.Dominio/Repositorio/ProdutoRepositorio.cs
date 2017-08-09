using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrocaSmart.LojaVirtual.Dominio.Entidade;

namespace TrocaSmart.LojaVirtual.Dominio.Repositorio
{
   public class ProdutoRepositorio
    {
        //referencia o entity com variavel
        private readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

    }
}
