using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoLesson.Data;
using VideoLesson.Entities;
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
        var appointment = _context.Courses
        .Where(vm => vm.IsActive == true && vm.IsDelete == false)
        .Select(vm => new VideoCourseViewModel
        {
            CourseId = vm.Id,
            CourseTitle = vm.Title,
            CourseDescription = vm.Description,
            CourseLanguage = vm.Language,
            CourseThumbnailUrl = vm.Img,
            CourseTotalDuration = vm.TotalDuration,

            VideoId = vm.videos!.Id,
            VideoDescription = vm.videos.Description,
            VideoDuration = vm.videos.DurationInSeconds,
            VideoOrder = vm.videos.Order,
            VideoTitle = vm.videos.Title
        })
        .ToList();
        return View(appointment);
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
