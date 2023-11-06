using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public string RegNo { get; }
    public string Customer { get; }
    public int KmRented { get; }
    public int KmReturned { get; set; }
    public DateTime DateRented { get; }
    public DateTime DateReturned { get; set; }
    public double Cost { get; set; }
    public VehicleStatuses Status { get; set; }

    public Booking(string regNO, string customer, int kmRented, DateTime dateRented, int kmReturned = default, DateTime dateReturned = default, VehicleStatuses status = VehicleStatuses.Booked)
    {
        RegNo = regNO;
        Customer = customer;
        KmRented = kmRented;
        DateRented = dateRented;
        KmReturned = kmReturned;
        DateReturned = dateReturned;
        Status = status;
    }
}
