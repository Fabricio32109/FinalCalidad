using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using NUnit.Framework;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new List<Carta>());
    }

    [HttpPost]
    public IActionResult Generar()
    {
        var service = new PokerService();
        var cartas = GeneradorMano.Generar();
        ViewBag.Jugada = service.GetJugada(cartas);
        return View("Index", cartas);
    }
    [HttpPost]
    public IActionResult Editar(String carta1, String select1, String carta2, String select2, String carta3, String select3, String carta4, String select4, String carta5, String select5)
    {
        List<Carta> cartas = new List<Carta>();
        Carta carta = new Carta();
        carta.Numero = int.Parse(carta1);
        carta.Palo = select1;
        cartas.Add(carta);
        carta = new Carta();
        carta.Numero = int.Parse(carta2);
        carta.Palo = select2;
        cartas.Add(carta);
        carta = new Carta();
        carta.Numero = int.Parse(carta3);
        carta.Palo = select3;
        cartas.Add(carta);
        carta = new Carta();
        carta.Numero = int.Parse(carta4);
        carta.Palo = select4;
        cartas.Add(carta);
        carta = new Carta();
        carta.Numero = int.Parse(carta5);
        carta.Palo = select5;
        cartas.Add(carta);
        var service = new PokerService();
        ViewBag.Jugada = service.GetJugada(cartas);
        return View("Index", cartas);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}