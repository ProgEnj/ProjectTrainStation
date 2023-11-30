namespace ProjectTrainStation;

public class SleepingCar : Carriage
{
    public SleepingCar(int price, Enum CarriageType, int totalSeats) : base(price, CarriageType, totalSeats)
    {
        base.InitializeSeats();
    }
}