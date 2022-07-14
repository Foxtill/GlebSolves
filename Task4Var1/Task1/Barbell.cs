public class Barbell : TrainingApparatus
{
    public int strength = 2;

    public override void AddStatsTo(Stats stats)
    {
        stats.strength += strength;
    }
}
