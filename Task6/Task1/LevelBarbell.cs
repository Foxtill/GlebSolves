public class LevelBarbell : LevelTrainingApparatus
{
    private const float KOEF = 0.5f;
    private const int baseStrength = 5;
    public List<Weight> weights = new List<Weight>();

    public LevelBarbell()
    {
        stats.strength = baseStrength;
    }
    protected int GetMass()
    {
        int sum = 0;
        foreach(var weight in weights)
        {
            sum += weight.weight;
        }
        return sum;
    }

    public void CalculateStats()
    {
        stats.strength = baseStrength + (int)(GetMass() * KOEF);
    }
}
