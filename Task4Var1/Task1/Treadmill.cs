public class Treadmill : TrainingApparatus
{
    public int stamina = 3;

    public override bool IsUsable(Stats stats)
    {
        return stats.stamina > 7;
    }

    public override void AddStatsTo(Stats stats)
    {
        stats.stamina += stamina;
    }
}