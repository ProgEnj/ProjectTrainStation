namespace ProjectTrainStation;

public class Train : IStatistic
{
    public Train(string id, List<Carriage> carriages)
    {
        Statistic = new Statistic();
        ID = id;
        Carriages = carriages;
    }

    public Statistic Statistic { get; }
    private string ID { get; }
    
    private List<Carriage> Carriages { get; }
}