using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VideoLesson.Data;
using VideoLesson.Models;

namespace VideoLesson.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public readonly MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext db)
    {
        _logger = logger;
        _context = db;
    }

    public IActionResult Index()
    {
        var viewModel = new ViewModel();
        viewModel.User = _context.Users.ToList();
        return View(viewModel);
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
