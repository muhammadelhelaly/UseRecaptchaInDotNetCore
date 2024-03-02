using AspNetCore.ReCaptcha;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UseRecaptchaInDotNetCore.Models;
using UseRecaptchaInDotNetCore.ViewModels;

namespace UseRecaptchaInDotNetCore.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ContactUs()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [ValidateReCaptcha(ErrorMessage = "ReCaptcha verification is failed")]
    public IActionResult ContactUs(ContactUseFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        //Do something

        return RedirectToAction(nameof(Index));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
