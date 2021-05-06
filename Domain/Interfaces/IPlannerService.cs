using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExerciseBuilder.Models;

namespace ExerciseBuilder.Domain.Interfaces
{
    public interface IPlannerService
    {
        Task<object> Plan(List<Exercise> exerciseList);
    }
}
