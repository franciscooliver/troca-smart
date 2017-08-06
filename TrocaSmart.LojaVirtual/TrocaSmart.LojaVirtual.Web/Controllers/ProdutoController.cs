using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrocaSmart.LojaVirtual.Dominio.Repositorio;

namespace TrocaSmart.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        // Nessa Class é aonde será implementadas as query
        private ProdutoRepositorio _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos;
            return View(produtos);
        }
    }
}