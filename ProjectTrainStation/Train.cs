using System.ComponentModel;

namespace ProjectTrainStation;

public class Train : ITicketStatistic
{
    public TicketStatistic TicketStatistic { get; }
    private string ID { get; }
    
    public List<Carriage> Carriages { get; }
    
    public Train(Enum carriageType, int numberOfCarriages)
    {
        Random rnd = new Random();
        TicketStatistic = new TicketStatistic();
        ID = Convert.ToString(rnd.Next(1, 10000));
        Carriages = new List<Carriage>(numberOfCarriages);

        switch (carriageType)
        {
            case CarriageType.CouchetteCar:
                while (Carriages.Count < numberOfCarriages)
                { Carriages.Add(new CouchetteCar(40));}
                break;
            
            case CarriageType.SleepingCar:
                while (Carriages.Count < numberOfCarriages)
                { Carriages.Add(new SleepingCar(40));}
                break;
            
            case CarriageType.CorridorCoach:
                while (Carriages.Count < numberOfCarriages)
                { Carriages.Add(new СorridorCoach(40));}
                break;
        }
    }
    
    
    public void AddTicket(Ticket ticket)
    {
        Carriages[ticket.CarriageIndex].AddTicket(ticket);
        TicketStatistic.AddRecord(ticket);
    }

    public void RemoveTicket(Ticket ticket)
    {
        Carriages[ticket.CarriageIndex].RemoveTicket(ticket);
        TicketStatistic.RemoveRecord(ticket);
    }
    
    
}