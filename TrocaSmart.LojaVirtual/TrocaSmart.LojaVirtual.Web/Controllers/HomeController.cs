using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrocaSmart.LojaVirtual.Dominio.Repositorio;

namespace TrocaSmart.LojaVirtual.Web.Controllers
{
    public class HomeController : Controller
    {
        private ProdutoRepositorio _repositorio;
        // GET: Home
        public ActionResult Index()
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos.Take(6);//Take traz apenas os 6 primeiros

            return View(produtos);

        }
        public ActionResult ListaProduto()
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos;
            return View(produtos);
        }
    }
}