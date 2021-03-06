﻿using Projeto01.Modelo.Cadastros;
using Servico.Cadastros;
using System.Net;
using System.Web.Mvc;

namespace Projeto01.Controllers
{
    public class CategoriasController : Controller
    {
        //============================================================================================
        private readonly CategoriaServico categoriaServico = new CategoriaServico();

        private ActionResult ObterVisaoCategoriaPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = categoriaServico.ObterCategoriaPorId((long)id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }
        private ActionResult GravarCategoria(Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categoriaServico.GravarCategoria(categoria);
                    return RedirectToAction("Index");
                }
                return View(categoria);
            }
            catch
            {
                return View(categoria);
            }
        }
        //=============================================================================================

        public ActionResult Index()
        {
            return View(categoriaServico.ObterCategoriasClassificadasPorNome());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            return GravarCategoria(categoria);
        }

        // GET
        public ActionResult Edit(long? id)
        {
            return ObterVisaoCategoriaPorId(id);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            return GravarCategoria(categoria);
        }


        // GET
        public ActionResult Details(long? id)
        {
            return ObterVisaoCategoriaPorId(id);
        }

        // GET
        public ActionResult Delete(long? id)
        {
            return ObterVisaoCategoriaPorId(id);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Categoria categoria = categoriaServico.EliminarCategoriaPorId(id);
            TempData["Message"] = "Categoria " + categoria.Nome.ToUpper() + " foi removido.";
            return RedirectToAction("Index");
        }

    }
}