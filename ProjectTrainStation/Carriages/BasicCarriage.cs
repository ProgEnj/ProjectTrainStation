namespace ProjectTrainStation;

public class BasicCarriage : Carriage
{
    public BasicCarriage(int price, Enum CarriageType, int totalSeats) : base(price, CarriageType, totalSeats)
    {
        base.InitializeSeats();
    }
}