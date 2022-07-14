public class Treadmill : TrainingApparatus
{
    public Treadmill()
    {
        stats.stamina = 3;
    }

    public override bool IsUsable(Stats stats)
    {
        return stats.stamina > 7;
    }
}