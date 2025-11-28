using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WildConsulting.WebSite.Core.ViewModels;

namespace WildConsulting.WebSite.Core.Controllers;

public class HomeController(IConfiguration configuration) : Controller
{
    public IActionResult Index()
    {
        var emailAddress = configuration["ContactSettings:Email"];
        var vm = new ContactViewModel(emailAddress);
        return View(vm);
    }
}