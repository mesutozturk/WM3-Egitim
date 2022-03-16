using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc1.ActionFilters;
using Mvc1.Models;

namespace Mvc1.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [TypeFilter(typeof(DenemeActionFilter))]
    public IActionResult Index()
    {
        List<Urun> urunler = new List<Urun>();
        for (int i = 0; i < 10; i++)
        {
            urunler.Add(new Urun()
            {
                Ad = "Ürün"+i,
                Fiyat = new Random().Next(10,100)
            });
        }
        return View(urunler);
    }
}