public class Soldier
{
    public Stats stats = new Stats
    {
        strength = 10,
        stamina = 5
    };

    public void PumpUp(TrainingApparatus trainingApparatus)
    {
        stats += trainingApparatus.stats;
    }

    public bool TryPumpUp(TrainingApparatus trainingApparatus)
    {
        var can = trainingApparatus.IsUsable(stats);
        if (can) PumpUp(trainingApparatus);
        else Console.WriteLine("I don't meet the requirements");

        if (trainingApparatus is IComplexityLevel complexityLevel)
        {
            complexityLevel.TryPickLevel(stats);
        }

        return can;
    }
}