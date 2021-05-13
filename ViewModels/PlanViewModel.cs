using System;
using System.Collections.Generic;
using ExerciseBuilder.Domain.Entities;

namespace ExerciseBuilder.ViewModels
{
    public class PlanViewModel
    {
      public List<string> MuscleGroups { get; set; }
      public List<Exercise> Exercises { get; set; }
      public HashSet<PlanEntry> Plan { get; set; }
    }
}
