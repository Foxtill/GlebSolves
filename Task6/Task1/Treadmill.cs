public partial class Treadmill : TrainingApparatus, IComplexityLevel
{
    private LevelTrainingApparatus _currentLevel;
    private List<LevelTrainingApparatus> _levels = new List<LevelTrainingApparatus>();

    public override bool IsUsable(Stats stats)
    {
        return _currentLevel.IsUsable(stats);
    }

    public void TryPickLevel(Stats stats)
    {
        LevelTrainingApparatus levelTreadmill = _currentLevel;
        int difficulty = 0;
        for(int i = 0; i < _levels.Count; i++)
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
        if (difficulty != _currentLevel.difficulty)
            SetLevel(levelTreadmill);
    }

    public void AddLevel(LevelTrainingApparatus levelTrainingApparatus)
    {
        _levels.Add(levelTrainingApparatus);
    }

    public void SetRandomLevel()
    {
        var randomLevel = _levels[new Random().Next(0, _levels.Count)];
        SetLevel(randomLevel);
    }
    public void SetLevel(LevelTrainingApparatus level)
    {
        _currentLevel = level;
        stats = _currentLevel.stats;
        Console.WriteLine("Treadmill = " + _currentLevel.difficulty);
    }
}