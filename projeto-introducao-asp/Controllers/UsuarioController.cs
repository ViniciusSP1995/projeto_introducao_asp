using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using projeto_introducao_asp.Models;

namespace  projeto_introducao_asp.Controllers
{
    public class UsuarioController: Controller
    {
        public IActionResult Usuario()
        {
             var usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Usuario(Usuario usuario) 
        {               
            if(ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public IActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public IActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Vinícius",
                "da Silva",
                "Sauro"
            };

            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()));
        }
    }
}