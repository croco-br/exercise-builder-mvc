using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExerciseBuilder.Models
{
    public class ExerciseRoot
    {
        [JsonPropertyName("exercise-list")]
        public List<Exercise> ExerciseList { get; set; }
    }
}