using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CheckpointIX_Calculo_IMC.Models;

namespace CheckpointIX_Calculo_IMC.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new ImcViewModel());
    }

    [HttpPost]
    public IActionResult Index(ImcViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        if (model.Peso.HasValue && model.Altura.HasValue)
        {
            model.Imc = Math.Round(model.Peso.Value / (model.Altura.Value * model.Altura.Value), 2);
            model.Classificacao = model.Imc.Value switch
            {
                < 18.5 => "Abaixo do peso",
                < 25.0 => "Peso normal",
                < 30.0 => "Sobrepeso",
                < 35.0 => "Obesidade Grau I",
                < 40.0 => "Obesidade Grau II",
                _ => "Obesidade Grau III"
            };
        }

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
