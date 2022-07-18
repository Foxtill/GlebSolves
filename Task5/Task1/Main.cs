public class Main
{
    private Soldier soldier = new Soldier();
    private Gym gym = new Gym();

    public void Start()
    {
        while (soldier.stats.stamina < 30 || soldier.stats.strength < 30)
        {
            soldier.TryPumpUp(gym.treadmill);
            soldier.TryPumpUp(gym.dumbbell);
            soldier.TryPumpUp(gym.barbell);
        }

        Console.WriteLine(soldier.stats.strength);
        Console.WriteLine(soldier.stats.stamina);
    }
}