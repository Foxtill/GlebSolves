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
        if (can)
        {
            PumpUp(trainingApparatus);
        }
        else Console.WriteLine("some req dont meet: strength = " + stats.strength + "; stamina = " + stats.stamina);

        if (trainingApparatus is IComplexityLevel complexityLevel)
        {
            complexityLevel.TryPickLevel(stats);
        }

        return can;
    }
}