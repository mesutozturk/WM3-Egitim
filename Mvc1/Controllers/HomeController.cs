using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc1.ActionFilters;
using Mvc1.Models;
using Mvc1.Services.Email;

namespace Mvc1.Controllers;

public class HomeController : Controller
{
    private readonly IMailService _mailService;

    public HomeController(IMailService mailService)
    {
        _mailService = mailService;
    }

    [HttpGet]
    [TypeFilter(typeof(DenemeActionFilter))]
    public IActionResult Index()
    {
        List<Urun> urunler = new List<Urun>();
        for (int i = 0; i < 10; i++)
        {
            urunler.Add(new Urun()
            {
                Ad = "Ürün" + i,
                Fiyat = new Random().Next(10, 100)
            });
        }

        _mailService.SendMail(new EmailMessage()
        {
            To = "mesut@wissenakademie.com",
            Message = "Ürünler eklendi",
            Topic = "Home/Index"
        });

        return View(urunler);
    }
}