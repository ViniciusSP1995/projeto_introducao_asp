using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projeto_introducao_asp.Models;
using System;
using System.Collections.Generic;

namespace projeto_introducao_asp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        var pessoa = new Pessoa
        {
            PessoaId = 1,
            Nome= "Vinícius da Silva",
            Tipo = "Administrador"
        };



        return View(pessoa);
    }

    public IActionResult Contatos()
    {
        return View();
    }

    [HttpPost]
     public IActionResult Lista(Pessoa pessoa)
 {
    ViewData["PessoaId"] = pessoa.PessoaId;
    ViewData["Nome"] = pessoa.Nome;
    ViewData["Tipo"] = pessoa.Tipo;

     return View(pessoa);
 }
  
}
