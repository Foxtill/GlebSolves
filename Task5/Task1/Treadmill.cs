public partial class Treadmill : TrainingApparatus, IComplexityLevel
{
    private LevelTreadmill _currentLevel;
    private LevelTreadmill [] _levels;

    public Treadmill()
    {
        _levels = new LevelTreadmill[]
        {
            new LevelTreadmill0(),
            new LevelTreadmill1(),
            new LevelTreadmill2(),
        };

        _currentLevel = _levels[new Random().Next(0,_levels.Length)];
    }

    public void TryPickLevel(Stats stats)
    {
        int [] array = new int[5];
        for (int i = 0; i < array.Length; i++)
        {
            var element  = array[i];
        }

        LevelTreadmill levelTreadmill = null;
        int difficulty = 0;
        for(int i = 0; i < _levels.Length; i++)
        {
            var level = _levels[i];
            if(level.IsUsable(stats))
            {
                if (difficulty < level.difficulty)
                {
                    difficulty = level.difficulty;
                    levelTreadmill = level;
                }
            }
        }
        if (levelTreadmill != null && difficulty != _currentLevel.difficulty)
            SetLevel(levelTreadmill);
    }

    private void SetLevel(LevelTreadmill level)
    {
        _currentLevel = level;
        stats = _currentLevel.stats;
    }

    public override bool IsUsable(Stats stats)
    {
        return _currentLevel.IsUsable(stats);
    }
}