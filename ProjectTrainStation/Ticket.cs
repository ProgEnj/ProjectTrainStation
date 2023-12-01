namespace ProjectTrainStation;

public class Ticket
{
    public string ID { get; }

    private string _customerFirstName;
    private string _customerLastName;
    public string CustomerFullName => $"{_customerFirstName} {_customerLastName}";
    
    public Route Route { get; }
    public int CarriageIndex { get; }
    public int CoupeIndex { get; }
    public string Seat { get; }
    
    public DateTime creationData { get; }

    public Ticket(string customerFirstName, string customerLastName, Route route, int carriageIndex, int coupeIndex, string seat)
    {
        _customerFirstName = customerFirstName;
        _customerLastName = customerLastName;
        Route = route;
        Seat = seat;
        CarriageIndex = carriageIndex;
        CoupeIndex = coupeIndex;

        Random rnd = new Random();

        ID = Convert.ToString(rnd.Next(1, 10000));
        creationData = DateTime.Today;
    }
}