public class Dumbbell : TrainingApparatus
{
    public Dumbbell()
    {
        stats.strength = 5;
    }

    public override bool IsUsable(Stats stats)
    {
        return stats.strength > 20;
    }
}
