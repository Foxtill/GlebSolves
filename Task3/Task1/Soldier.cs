public partial class Soldier
{
    public int strength = 10;

    public void PumpUp(TrainingApparatus trainingApparatus)
    {
        var can = trainingApparatus.IsUsable(strength);
        if (can) strength += trainingApparatus.strength;
        else Console.WriteLine("I don't meet the requirements");
    }
}