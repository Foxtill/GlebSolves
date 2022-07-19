public class Main
{
    private Soldier soldier = new Soldier();
    private Gym gym1 = new Gym();
    private Gym gym2 = new Gym();

    public void Start()
    {
        InitGyms();

        while (soldier.stats.stamina < 60 || soldier.stats.strength < 60)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Chain 1");
            gym1.UseChain(soldier);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Chain 2");
            gym2.UseChain(soldier);
        }

        Console.WriteLine(soldier.stats.strength + " " + soldier.stats.stamina);
    }

    private void InitGyms()
    {
        DataLevels data = new DataLevels();
        data.Init();

        Treadmill treadmill1 = new Treadmill();
        treadmill1.AddLevel(data.levelTreadmill0);
        treadmill1.AddLevel(data.levelTreadmill1);
        treadmill1.AddLevel(data.levelTreadmill2);
        treadmill1.SetRandomLevel();

        Barbell barbell1 = new Barbell();
        barbell1.AddLevel(data.levelBarbell0);
        barbell1.SetRandomLevel();

        Treadmill treadmill2 = new Treadmill();
        treadmill2.AddLevel(data.levelTreadmill0);
        treadmill2.AddLevel(data.levelTreadmill1);
        treadmill2.AddLevel(data.levelTreadmill2);
        treadmill2.AddLevel(data.levelTreadmill3);
        treadmill2.SetRandomLevel();

        Barbell barbell2 = new Barbell();
        barbell2.AddLevel(data.levelBarbell0);
        barbell2.AddLevel(data.levelBarbell1);
        barbell2.AddLevel(data.levelBarbell2);
        barbell2.SetRandomLevel();

        gym1.AddTrainingApparatus(new Dumbbell());
        gym1.AddTrainingApparatus(barbell1);
        gym1.AddTrainingApparatus(treadmill1);

        gym2.AddTrainingApparatus(barbell2);
        gym2.AddTrainingApparatus(treadmill2);
    }

}