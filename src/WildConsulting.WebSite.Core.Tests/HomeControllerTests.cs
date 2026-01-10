using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WildConsulting.WebSite.Core.Controllers;
using WildConsulting.WebSite.Core.ViewModels;

namespace WildConsulting.WebSite.Core.Tests;

public class HomeControllerTests
{
    private const string TestEmailAddress = "my.email@test.com";

    private readonly Mock<IConfiguration> _mockConfiguration;

    public HomeControllerTests()
    {
        _mockConfiguration = new Mock<IConfiguration>();
        _mockConfiguration
            .SetupGet(x => x["ContactSettings:Email"])
            .Returns(TestEmailAddress);
    }

    [Fact]
    public void HomeController_Index_Should_Return_ViewResult_With_ContactViewModel()
    {
        var controller = new HomeController(_mockConfiguration.Object);

        var result = controller.Index();

        result.ShouldNotBeNull();
        result.ShouldBeOfType<ViewResult>();

        var viewResult = result as ViewResult;
        viewResult.ShouldNotBeNull();
        viewResult.ViewData.ModelState.IsValid.ShouldBeTrue();
        viewResult.ViewData.ModelState.ErrorCount.ShouldBe(0);

        viewResult.ViewData.Model.ShouldBeAssignableTo<ContactViewModel>();
        var viewModel = viewResult.ViewData.Model as ContactViewModel;
        viewModel.ShouldNotBeNull();
        viewModel!.Email.ShouldBe(TestEmailAddress);
    }
}