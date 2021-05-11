using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExerciseBuilder.Domain.Interfaces;
using ExerciseBuilder.Domain.Entities;
using ExerciseBuilder.ViewModels;
using System.Linq;

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
            var plan = _plannerService.Build(exercises, new WorkoutParameters());

            return View("Index", new HomeViewModel()
            {
                Exercises = exercises,
                MuscleGroups = exercises
                .Select(x=> x.MuscleGroup)
                .Distinct().ToList(),
                Plan = plan
            });
        }

          public async Task<IActionResult> Generate(object parameters)
        {
            var exercises = await _exerciseService.Generate();
            var plan = _plannerService.Build(exercises,
                                             new WorkoutParameters(3,5,5,10));

            return View("Index", new HomeViewModel()
            {
                Exercises = exercises,
                MuscleGroups = exercises
                .Select(x=> x.MuscleGroup)
                .Distinct().ToList(),
                Plan = plan
            });
        }

    }
}
