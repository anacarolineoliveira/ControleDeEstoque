using ControleDeEstoque.Models;
using ControleDeEstoque.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeEstoque.Controllers
{
    public class AlimentosController : Controller
    {
        private Persistencia.MercadoContext _context;

        public AlimentosController(MercadoContext context)
        {
            _context = context;
        } 

        public IActionResult Index()
        {
            List<Alimentos> alimentos = _context.Alimentos.ToList();

            return View(alimentos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Models.Alimentos alimentos)
        {
            _context.Alimentos.Add(alimentos);
            _context.SaveChanges();
            TempData["msg"] = "Alimento Cadastrado com sucesso!";

            return RedirectToAction("Cadastrar");
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            Alimentos alimentos = _context.Alimentos.Find(id);
            return View(alimentos);
        }
        [HttpPost]
        public IActionResult Editar(Alimentos alimentos)
        {
            _context.Alimentos.Update(alimentos);
            _context.SaveChanges();
            TempData["msg"] = "Animal editado com sucesso!";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Remover(int id)
        {
            Alimentos alimentos = _context.Alimentos.Find(id);
            _context.Alimentos.Remove(alimentos);
            _context.SaveChanges();
            TempData["msgRemove"] = "Alimento removido."; 
            return RedirectToAction("Index");

        }
    }
}
