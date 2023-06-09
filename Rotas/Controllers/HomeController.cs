﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Rotas.Models;

namespace Rotas.Controllers;

public class HomeController : Controller
{
    private readonly IEnumerable<Noticia> todasAsNoticias;


    public HomeController()
     {
        todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);

    }
    public IActionResult Index()
    {
        var ultimasNoticias = todasAsNoticias.Take(3);
        var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();

        ViewBag.Categoria =  todasAsCategorias;

        return View(ultimasNoticias);
    }

    public IActionResult TodasAsNoticias()
    {
        return View(todasAsNoticias);
    }

    public IActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
    {
        return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
    }

    public IActionResult MostraCategoria(string categoria)
    {
        var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
        ViewBag.Categoria = categoria;
        return View(categoriaEspecifica);

    }
}
