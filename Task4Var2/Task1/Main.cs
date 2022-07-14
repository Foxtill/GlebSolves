public class Main
{
    private Soldier soldier = new Soldier();
    private Gym gym = new Gym();
    public void Start()
    {
        soldier.PumpUp(gym.dumbbell);
        soldier.PumpUp(gym.barbell);
        soldier.PumpUp(gym.treadmill);
        Console.WriteLine(soldier.stats.strength);
        Console.WriteLine(soldier.stats.stamina);
    }
}