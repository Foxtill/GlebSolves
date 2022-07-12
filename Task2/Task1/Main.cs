public class Main
{ 
    private Soldier soldier = new Soldier();
    private Gym gym = new Gym();
    public void Start()
    {
        soldier.PumpUp(gym.dumbbell);
        soldier.PumpUp(gym.barbell);
        soldier.PumpUp(gym.treadmill);
        Console.WriteLine(soldier.strength);
    }
}

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