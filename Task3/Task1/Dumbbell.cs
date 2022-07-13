public class Dumbbell : TrainingApparatus
{
    public Dumbbell()
    {
        strength = 5;
    }

    public override bool IsUsable(int strength)
    {
        return strength > 20;
    }
}
