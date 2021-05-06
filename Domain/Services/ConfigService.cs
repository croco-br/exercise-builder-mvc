using System;
using System.Collections.Generic;
using ExerciseBuilder.Domain.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using ExerciseBuilder.Models;

namespace ExerciseBuilder.Domain.Services
{
    public sealed class ConfigService : IConfigService
    {
        public async Task<List<Exercise>> ReadConfig()
        {
            using (FileStream fs = File.OpenRead("Config/exercise-list.json"))
            {
                var jsonObj = await JsonSerializer.DeserializeAsync<ExerciseRoot>(fs);
                return jsonObj.ExerciseList;
            }
        }
    }
}
