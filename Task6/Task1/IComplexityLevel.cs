public interface IComplexityLevel
{
    public void TryPickLevel(Stats stats);
    public void AddLevel(LevelTrainingApparatus levelTrainingApparatus);
    public void SetRandomLevel();
    public void SetLevel(LevelTrainingApparatus levelTrainingApparatus);
}
