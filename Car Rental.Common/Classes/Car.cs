using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegNo { get; }
    public string Make { get; }
    public int Odometer { get; set; }
    public double CostPerKm { get; set; }
    public VehicleTypes VehicleType { get; }
    public int CostPerDay { get; set; }
    public VehicleStatuses Status { get; set; }

    public Car(string regNo, string make, double costPerKm, int costPerDay, VehicleTypes vehicleType, int odometer = 0, VehicleStatuses status = VehicleStatuses.Available)
    {
        RegNo = regNo;
        Make = make;
        CostPerKm = costPerKm;
        VehicleType = vehicleType;
        CostPerDay = costPerDay;
        Odometer = odometer;
        Status = status;
    }
}
