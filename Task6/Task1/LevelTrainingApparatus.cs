public class LevelTrainingApparatus
{
    public int difficulty;
    public Stats statsReq = new Stats();
    public Stats stats = new Stats();
    public virtual bool IsUsable(Stats stats)
    {
        return stats >= statsReq;
    }
}