namespace ProjectTrainStation;

public class TrainStation : ITicketStatistic
{
    public string Name { get; }
    public TicketStatistic TicketStatistic { get; }

    public TrainStation(string name)
    {
        Name = name;
        this.TicketStatistic = new TicketStatistic();
    }
}