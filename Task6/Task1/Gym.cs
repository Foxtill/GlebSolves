public class Gym
{
    public List<TrainingApparatus> trainingApparatuses = new List<TrainingApparatus>();

    public void AddTrainingApparatus(TrainingApparatus trainingApparatus)
    {
        trainingApparatuses.Add(trainingApparatus);
    }

    public void UseChain(Soldier soldier)
    {
        foreach (var trainingApparatus in trainingApparatuses)
        {
            soldier.TryPumpUp(trainingApparatus);
        }
    }
}