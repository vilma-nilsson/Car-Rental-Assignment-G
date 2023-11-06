using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    string RegNo { get; }
    string Customer { get; }
    int KmRented { get; }
    int KmReturned { get; set; }
    DateTime DateRented { get; }
    DateTime DateReturned { get; set; }
    double Cost {  get; set; }
    VehicleStatuses Status { get; set; }
}
