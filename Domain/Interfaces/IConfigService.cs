using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExerciseBuilder.Models;

namespace ExerciseBuilder.Domain.Interfaces
{
    public interface IConfigService
    {
        Task<List<Exercise>> ReadConfig();
    }
}
