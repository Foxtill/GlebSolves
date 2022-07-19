public class LevelBarbell : LevelTrainingApparatus
{
    private const float KOEF = 0.5f;
    public List<Weight> weights = new List<Weight>();
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
        stats.strength = (int)(GetMass() * KOEF);
    }
}
