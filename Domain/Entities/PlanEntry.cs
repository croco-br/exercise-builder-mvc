namespace ExerciseBuilder.Domain.Entities
{
    public class PlanEntry
    {
        public Exercise Exercise { get; set; }
        public int Series { get; set; }
        public int Quantity { get; set; }
    }
}