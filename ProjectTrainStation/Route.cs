namespace ProjectTrainStation;

public class Route : IStatistic
{
    public Statistic Statistic { get; }

    public string Title { get; }
    
    private Train AssignedTrain { get; set; }
    
    public TrainStation Departure { get; }
    public TrainStation Destination { get; }

    public DateTime departureTime { get; }
    public DateTime ArrivalTime { get; }
    public DateTime Gap { get; }

    public Route(string title, Train assignedTrain, TrainStation departure, 
        TrainStation destination, DateTime departureTime, DateTime arrivalTime, DateTime gap)
    {
        Title = departure.Name + "-" + destination.Name;
        AssignedTrain = assignedTrain;
        Departure = departure;
        Destination = destination;
        this.departureTime = departureTime;
        ArrivalTime = arrivalTime;
        Gap = gap;
        Statistic = new Statistic();
    }

}