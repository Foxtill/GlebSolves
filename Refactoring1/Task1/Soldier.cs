public class Soldier
{
    public int strength = 10;
    public void PumpUp(TrainingApparatus trainingApparatus)
    {
        strength += trainingApparatus.strength;
    }
}