public class Stats
{
    public int strength;
    public int stamina;

    public static Stats operator +(Stats stats1, Stats stats2)
    {
        return new Stats
        {
            strength = stats1.strength + stats2.strength,
            stamina = stats1.stamina + stats2.stamina,
        };
    }

    public static bool operator >(Stats stats1, Stats stats2)
    {
        return stats1.strength > stats2.strength
            && stats1.stamina > stats2.stamina;
    }
    public static bool operator <(Stats stats1, Stats stats2)
    {
        return stats1.strength < stats2.strength
            && stats1.stamina < stats2.stamina;
    }

    public static bool operator <=(Stats stats1, Stats stats2)
    {
        return stats1.strength <= stats2.strength
            && stats1.stamina <= stats2.stamina;
    }
    public static bool operator >=(Stats stats1, Stats stats2)
    {
        return stats1.strength >= stats2.strength
            && stats1.stamina >= stats2.stamina;
    }
}