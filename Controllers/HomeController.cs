using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExerciseBuilder.Domain.Interfaces;
using ExerciseBuilder.ViewModels;

namespace ExerciseBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExerciseService _exerciseService;
        private readonly IPlannerService _plannerService;

        public HomeController(ILogger<HomeController> logger,
                              IExerciseService exerciseService,
                              IPlannerService plannerService)
        {
            _logger = logger;
            _exerciseService = exerciseService;
            _plannerService = plannerService;
        }

        public async Task<IActionResult> Index()
        {
            var exercises = await _exerciseService.Generate();
            var plan = _plannerService.Build(exercises);

            return View("Index", new HomeViewModel()
            {
                Exercises = exercises,
                Plan = plan
            });
        }

    }
}
