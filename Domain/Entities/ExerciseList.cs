using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExerciseBuilder.Domain.Entities
{
    public class ExerciseRoot
    {
        [JsonPropertyName("exercise-list")]
        public List<Exercise> ExerciseList { get; set; }
    }
}