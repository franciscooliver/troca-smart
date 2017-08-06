using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaSmart.LojaVirtual.Dominio.Entidade
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string modelo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string status { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }


    }
}
