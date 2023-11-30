namespace ProjectTrainStation;

public class СorridorCoach : Carriage
{
    public СorridorCoach(int price, Enum CarriageType, int totalSeats) : base(price, CarriageType, totalSeats)
    {
        base.InitializeSeats();
    }
}