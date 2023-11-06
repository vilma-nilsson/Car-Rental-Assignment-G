using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{
    string RegNo { get; }
    string Make {  get; }
    int Odometer { get; set; }
    double CostPerKm { get; set; }
    VehicleTypes VehicleType { get; }
    int CostPerDay { get; set; }
    VehicleStatuses Status { get; set; }
}
