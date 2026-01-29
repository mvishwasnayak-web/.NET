using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StudentWebAPI.Model;

namespace StudentWebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly Appsettings _settings;

        public HomeController(IOptions<Appsettings>settings)
        {
            _settings = settings.Value;

        }
        public IActionResult Index()
        {
            return Content(
                $"Name of the Application: {_settings.ApplicationName} \n "+
                $"Support: {_settings.SupportEmail}");
                }
        }
    }

