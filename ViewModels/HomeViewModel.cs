using System;
using System.Collections.Generic;
using ExerciseBuilder.Domain.Entities;

namespace ExerciseBuilder.ViewModels
{
    public class HomeViewModel
    {
      public List<string> MuscleGroups { get; set; }
      public List<Exercise> Exercises { get; set; }
      public List<PlanEntry> Plan { get; set; }
    }
}
