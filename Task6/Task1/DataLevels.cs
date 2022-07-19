public class DataLevels
{
    public LevelTrainingApparatus levelTreadmill0 = new LevelTrainingApparatus();
    public LevelTrainingApparatus levelTreadmill1 = new LevelTrainingApparatus();
    public LevelTrainingApparatus levelTreadmill2 = new LevelTrainingApparatus();
    public LevelTrainingApparatus levelTreadmill3 = new LevelTrainingApparatus();

    public LevelBarbell levelBarbell0 = new LevelBarbell();
    public LevelBarbell levelBarbell1 = new LevelBarbell();
    public LevelBarbell levelBarbell2 = new LevelBarbell();
    public void Init()
    {
        levelTreadmill0.difficulty = 1;
        levelTreadmill0.stats.stamina = 1;
        levelTreadmill0.statsReq.stamina = 0;

        levelTreadmill1.difficulty = 2;
        levelTreadmill1.stats.stamina = 2;
        levelTreadmill1.statsReq.stamina = 4;

        levelTreadmill2.difficulty = 3;
        levelTreadmill2.stats.stamina = 3;
        levelTreadmill2.stats.strength = 1;
        levelTreadmill2.statsReq.stamina = 8;
        levelTreadmill2.statsReq.strength = 4;

        levelTreadmill3.difficulty = 4;
        levelTreadmill3.stats.stamina = 5;
        levelTreadmill3.stats.strength = 3;
        levelTreadmill3.statsReq.stamina = 20;
        levelTreadmill3.statsReq.strength = 15;

        levelBarbell0.difficulty = 1;
        levelBarbell0.statsReq.strength = 0;
        levelBarbell0.weights = new List<Weight>();
        levelBarbell0.CalculateStats();

        levelBarbell1.difficulty = 2;
        levelBarbell1.statsReq.stamina = 20;
        levelBarbell1.weights = new List<Weight> { new Weight(10), new Weight(10) };
        levelBarbell1.CalculateStats();

        levelBarbell2.difficulty = 3;
        levelBarbell2.statsReq.strength = 40;
        levelBarbell2.weights = new List<Weight> { new Weight(20), new Weight(20) };
        levelBarbell2.CalculateStats();
    }
}