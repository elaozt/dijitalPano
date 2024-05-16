using System.Diagnostics;
using dijitalPano.Data;
using Microsoft.AspNetCore.Mvc;
using dijitalPano.Models;
using Microsoft.EntityFrameworkCore;
namespace dijitalPano.Controllers;


public class HomeController : Controller
{
           private readonly DataContext _context;

    public HomeController(DataContext context)
    {
        _context = context;
    }
        public IActionResult Index()
        {
            
            return View();
        }
}


