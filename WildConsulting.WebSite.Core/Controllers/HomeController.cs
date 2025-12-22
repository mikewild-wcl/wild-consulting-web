using Microsoft.AspNetCore.Mvc;
using WildConsulting.WebSite.Core.ViewModels;

namespace WildConsulting.WebSite.Core.Controllers;

public class HomeController(IConfiguration configuration) : Controller
{
    public IActionResult Index()
    {
        var emailAddress = configuration["ContactSettings:Email"];
        var vm = new ContactViewModel(emailAddress ?? string.Empty);

        return View(vm);
    }
}