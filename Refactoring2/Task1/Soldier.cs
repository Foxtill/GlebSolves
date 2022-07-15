public class Soldier
{
    public Stats stats = new Stats
    {
        strength = 10,
        stamina = 5
    };

    public void PumpUp(TrainingApparatus trainingApparatus)
    {
        var can = trainingApparatus.IsUsable(stats);
        if (can) stats += trainingApparatus.stats;
        else Console.WriteLine("I don't meet the requirements");
    }

}