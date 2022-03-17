using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc1.ActionFilters;
using Mvc1.Data;
using Mvc1.Models;
using Mvc1.Services.Email;
using Mvc1.ViewModels;

namespace Mvc1.Controllers;

public class HomeController : Controller
{
    private readonly IMailService _mailService;
    private readonly NorthwindContext _context;

    public HomeController(IMailService mailService, NorthwindContext context)
    {
        _mailService = mailService;
        _context = context;
    }

    [HttpGet]
    [TypeFilter(typeof(DenemeActionFilter))]
    public IActionResult Index()
    {
        var urunler = _context.Products.Take(10).ToList();
        var urunler2 = _context.Products.Take(10)
            .Include(x=>x.Category)
            //.Include(x=>x.OrderDetails) //eager-loading
            //.ThenInclude(x=>x.Order)
            .Select(x => new ProductListViewModel()
            {
                Id = x.ProductId,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                CategoryName = x.Category.CategoryName
            })
            .ToList();
        _mailService.SendMail(new EmailMessage()
        {
            To = "mesut@wissenakademie.com",
            Message = "Ürünler eklendi",
            Topic = "Home/Index"
        });

        return View(urunler2);
    }
}