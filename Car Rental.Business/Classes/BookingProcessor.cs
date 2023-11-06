using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<IPerson> GetCustomers()
    {
        IEnumerable<IPerson> customers = _db.GetPersons();

        return customers;
    }
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
    {
        IEnumerable<IVehicle> vehicles = _db.GetVehicles();

        return vehicles;
    }
    public IEnumerable<IBooking> GetBookings()
    {
        IEnumerable<IBooking> bookings = _db.GetBookings();
        IEnumerable<IVehicle> vehicles = _db.GetVehicles();

        foreach (var booking in bookings)
        {
            //calculate if the vehicle has been returned (is available), not if still booked
            if (booking.Status.Equals(VehicleStatuses.Available))
            {
                var vehicle = vehicles.SingleOrDefault(v => v.RegNo.Equals(booking.RegNo));

                if (vehicle != default)
                {
                    booking.Cost = (booking.DateReturned.Subtract(booking.DateRented).Days + 1) * vehicle.CostPerDay + (booking.KmReturned - booking.KmRented) * vehicle.CostPerKm;
                }
            }
        }

        return bookings;
    }
}
