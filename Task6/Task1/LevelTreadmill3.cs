public class LevelTreadmill3 : LevelTrainingApparatus
{
    public LevelTreadmill3()
    {
        difficulty = 4;
        stats.stamina = 5;
        stats.strength = 3;
    }

    public override bool IsUsable(Stats stats)
    {
        return stats.stamina > 20 && stats.strength > 15;
    }
}