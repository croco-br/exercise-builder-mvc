using System;
using System.Collections.Generic;
using ExerciseBuilder.Domain.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using ExerciseBuilder.ViewModels;
using ExerciseBuilder.Domain.Entities;

namespace ExerciseBuilder.Domain.Services
{
    public sealed class ExerciseService : IExerciseService
    {
        public async Task<List<Exercise>> Generate()
        {
            using (FileStream fs = File.OpenRead("Config/exercise-list.json"))
            {
                var jsonObj = await JsonSerializer.DeserializeAsync<ExerciseRoot>(fs);
                return jsonObj.ExerciseList;
            }
        }
    }
}
