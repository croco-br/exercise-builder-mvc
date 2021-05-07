using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExerciseBuilder.Domain.Interfaces;

namespace ExerciseBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfigService _configService;
        private readonly IPlannerService _plannerService;

        public HomeController(ILogger<HomeController> logger,
                              IConfigService configService,
                              IPlannerService plannerService)
        {
            _logger = logger;
            _configService = configService;
            _plannerService = plannerService;
        }

        public async Task<IActionResult> Index()
        {
            var exercises = await _configService.ReadConfig();
            var plan = _plannerService.Build(exercises);

            return View();
        }

    }
}
