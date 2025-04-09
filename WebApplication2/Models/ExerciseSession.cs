namespace WebApplication2.Models;

public class ExerciseSession
{
    public int Id { get; set; }
    public int SessionId { get; set; }
    public int ExerciseId { get; set; }
    public int Series { get; set; }
    public int Reps { get; set; }
    public int UsedWeight { get; set; }
    
    public virtual Excercise Exercise { get; set; }
    public virtual Session Session { get; set; }
}