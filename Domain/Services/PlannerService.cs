using System;
using System.Collections.Generic;
using ExerciseBuilder.Domain.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using ExerciseBuilder.ViewModels;
using System.Linq;
using ExerciseBuilder.Domain.Entities;

namespace ExerciseBuilder.Domain.Services
{
    public sealed class PlannerService : IPlannerService
    {
        private readonly Random _random;

        public PlannerService()
        {
            _random = new Random();
        }
        public HashSet<PlanEntry> Build(List<Exercise> exerciseList, WorkoutParameters parameters)
        {
            var exerciseQuantity = _random.Next(parameters.minimumExerciseQuantity, parameters.maximumExerciseQuantity);
            var result = new HashSet<PlanEntry>();

            while (result.Count < exerciseQuantity)
            {
                var elem = exerciseList.ElementAt(_random.Next(0, exerciseList.Count));
                var entry = new PlanEntry()
                {
                    Exercise = elem,
                    Series = _random.Next(parameters.minimumSeries, parameters.maximumSeries),
                    Quantity = GetQuantityByMethod(elem.Method)
                };

                if (!result.Contains(entry))
                {
                    result.Add(entry);
                }
            }

            return result;
        }

        private int GetQuantityByMethod(string method)
        {
            switch (method)
            {
                case "isometry":
                    return _random.Next(20, 40);

                case "repetitions":
                default:
                    return _random.Next(8, 12);

            }

        }

    }
}
