using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExerciseBuilder.Domain.Entities;
using ExerciseBuilder.ViewModels;

namespace ExerciseBuilder.Domain.Interfaces
{
    public interface IConfigService
    {
        Task<List<Exercise>> ReadConfig();
    }
}
