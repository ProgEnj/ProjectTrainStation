namespace ProjectTrainStation;

public abstract class Carriage
{
    public int Price { get; }
    public Enum type { get; }
    
    public int totalSeats;
    public int TotalSeats
    {
        get { return totalSeats; }

        private set
        {
            if (value % 4 != 0)
            {
                throw new Exception("Total seats must be evenly distribute by coupe of 4 seats in each");
            }
            else
            {
                totalSeats = value;
            }
        }
    }

    public List<Dictionary<string, Ticket?>> Seats { get; set; }
    
    protected Carriage(int price, Enum CarriageType, int totalSeats)
    {
        this.Price = price;
        this.type = type;
        this.TotalSeats = totalSeats;

        Seats = new List<Dictionary<string, Ticket?>>();
        for (int i = 0; i < totalSeats / 4; i++)
        {
            Seats.Add(new Dictionary<string, Ticket>());
        }
    }
    
    private protected virtual void InitializeSeats()
    {
        foreach (var coupe in this.Seats)
        {
            for (int i = 0; i < 2; i++)
            {
                coupe.Add($"b{i}", null);
            }

            for (int i = 0; i < 2; i++)
            {
                coupe.Add($"t{i}", null);
            }
        }
    }
    
    public void AddTicket(Ticket ticket)
    {
        Seats[ticket.CoupeIndex][ticket.Seat] = ticket;
    }

    public void RemoveTicket(Ticket ticket)
    {
        Seats[ticket.CoupeIndex][ticket.Seat] = null;
    }
}