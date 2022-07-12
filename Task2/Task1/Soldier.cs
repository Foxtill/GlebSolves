public class Soldier
{
    public int strength = 10;
    public void PumpUp(Dumbbell dumbbell)
    {
        strength += dumbbell.strength;
    }
    public void PumpUp(Barbell barbell)
    {
        strength += barbell.strength;
    }
    public void PumpUp(Treadmill treadmill)
    {
        strength += treadmill.strength;
    }
}