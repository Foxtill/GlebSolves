public class Dumbbell : TrainingApparatus
{
    public int strength = 5;

    public override bool IsUsable(Stats stats)
    {
        return stats.strength > 20;
    }

    public override void AddStatsTo(Stats stats)
    {
        stats.strength += strength;
    }
}
