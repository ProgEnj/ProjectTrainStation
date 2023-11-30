namespace ProjectTrainStation;

public class TrainStation : IStatistic
{
    public string Name { get; }
    public Statistic Statistic { get; }

    public TrainStation(string name)
    {
        Name = name;
        this.Statistic = new Statistic();
    }
}