
public class TrainingApparatus
{
    public virtual bool IsUsable(Stats stats)
    {
        return true;
    }

    public virtual void AddStatsTo(Stats stats) { }
}