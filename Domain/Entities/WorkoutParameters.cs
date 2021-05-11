namespace ExerciseBuilder.Domain.Entities
{
    public class WorkoutParameters
    {
        public readonly int minimumSeries;
        public readonly int maximumSeries;
        public readonly int minimumExerciseQuantity;
        public readonly int maximumExerciseQuantity;

        public WorkoutParameters(int minimumSeries = 3,
                                 int maximumSeries = 5,
                                 int minimumExerciseQuantity = 5,
                                 int maximumExerciseQuantity = 10)
        {
            this.minimumSeries = minimumSeries;
            this.maximumSeries = maximumSeries;
            this.minimumExerciseQuantity = minimumExerciseQuantity;
            this.maximumExerciseQuantity = maximumExerciseQuantity;
        }

    }
}