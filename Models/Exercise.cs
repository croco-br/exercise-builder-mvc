using System.Text.Json.Serialization;
using System.Text.Json;

namespace ExerciseBuilder.Models
{
  public class Exercise
        {

            [JsonPropertyName("exercise-name")]
            public string ExerciseName { get; set; }

            [JsonPropertyName("muscle-group")]
            public string MuscleGroup { get; set; }

            [JsonPropertyName("difficulty")]
            public int Difficulty { get; set; }

            [JsonPropertyName("reference")]
            public string Reference { get; set; }
        }
}