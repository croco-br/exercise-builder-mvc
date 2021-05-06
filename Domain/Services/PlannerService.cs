using System;
using System.Collections.Generic;
using ExerciseBuilder.Domain.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using ExerciseBuilder.Models;
using System.Linq;

namespace ExerciseBuilder.Domain.Services
{
    public sealed class PlannerService : IPlannerService
    {
        private readonly Random _random;
        public PlannerService()
        {
            _random = new Random();
        }
        public Task<object> Plan(List<Exercise> exerciseList)
        {
            var exerciseQuantity = _random.Next(5, 10);
            var result = new List<object>();

            for (int i = 0; i < exerciseQuantity; i++)
            {
                var elem = exerciseList.ElementAt(_random.Next(0, exerciseList.Count));
                result.Add(new
                {
                    exercise = elem,
                    series = _random.Next(3, 5),
                    repetitions = _random.Next(8, 12),
                });
            }

            return null;
        }


    }
}
