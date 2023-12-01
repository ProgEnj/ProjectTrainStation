namespace ProjectTrainStation;

public class Route : ITicketStatistic
{
    public TicketStatistic TicketStatistic { get; }

    public string Title { get; }
    
    public Train AssignedTrain { get; }
    
    public TrainStation Departure { get; }
    public TrainStation Destination { get; }

    public DateTime departureTime { get; }
    public DateTime ArrivalTime { get; }
    public int Gap { get; }

    public Route(Train assignedTrain, TrainStation departure, 
        TrainStation destination, DateTime departureTime, DateTime arrivalTime, int gap)
    {
        Title = departure.Name + "-" + destination.Name;
        AssignedTrain = assignedTrain;
        Departure = departure;
        Destination = destination;
        this.departureTime = departureTime;
        ArrivalTime = arrivalTime;
        Gap = gap;
        TicketStatistic = new TicketStatistic();
    }

    public void AddTicket(Ticket ticket)
    {
        AssignedTrain.AddTicket(ticket);
        TicketStatistic.AddRecord(ticket);
        Departure.TicketStatistic.AddRecord(ticket);
    }

    public void RemoveTicket(Ticket ticket)
    {
        AssignedTrain.RemoveTicket(ticket);
        TicketStatistic.RemoveRecord(ticket);
        Departure.TicketStatistic.RemoveRecord(ticket);
    }
}