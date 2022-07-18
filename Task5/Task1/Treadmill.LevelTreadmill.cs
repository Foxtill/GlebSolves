public partial class Treadmill
{
    private class LevelTreadmill
    {
        public int difficulty;
        public Stats stats = new Stats();

        public virtual bool IsUsable(Stats stats)
        {
            return true;
        }
    }
    private class LevelTreadmill0 : LevelTreadmill
    {
        public LevelTreadmill0()
        {
            difficulty = 1;
            stats.stamina = 1;
        }

        public override bool IsUsable(Stats stats)
        {
            return stats.stamina > 0;
        }
    }

    private class LevelTreadmill1 : LevelTreadmill
    {
        public LevelTreadmill1()
        {
            difficulty = 2;
            stats.stamina = 2;
        }

        public override bool IsUsable(Stats stats)
        {
            return stats.stamina > 4;
        }
    }
    private class LevelTreadmill2 : LevelTreadmill
    {
        public LevelTreadmill2()
        {
            difficulty = 3;
            stats.stamina = 3;
            stats.strength = 1;
        }

        public override bool IsUsable(Stats stats)
        {
            return stats.stamina > 8 && stats.strength > 4;
        }
    }
}
