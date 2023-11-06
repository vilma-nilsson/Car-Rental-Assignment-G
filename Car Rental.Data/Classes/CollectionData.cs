using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _bookings = new List<IBooking>();

    public CollectionData() => SeedData();

    void SeedData()
    {
        _persons.Add(new Customer(12345, "John", "Doe"));
        _persons.Add(new Customer(98765, "Jane", "Doe"));

        _vehicles.Add(new Car("ABC123", "Volvo", 1, 200, VehicleTypes.Combi, 10000, VehicleStatuses.Available));
        _vehicles.Add(new Car("DEF456", "Saab", 1, 100, VehicleTypes.Sedan, 20000, VehicleStatuses.Available));
        _vehicles.Add(new Car("GHI789", "Tesla", 3, 100, VehicleTypes.Sedan, 1000, VehicleStatuses.Booked));
        _vehicles.Add(new Car("JKL012", "Jeep", 1.5, 300, VehicleTypes.Van, 5000, VehicleStatuses.Available));
        _vehicles.Add(new Motorcycle("MNO234", "Yamaha", 0.5, 50, VehicleTypes.Motorcycle, 30000, VehicleStatuses.Available));

        _bookings.Add(new Booking("GHI789", "Doe John (12345)", 1000, new DateTime(2023, 09, 20)));
        _bookings.Add(new Booking("JKL012", "Doe Jane (98765)", 5000, new DateTime(2023, 09, 20), 5000, new DateTime(2023, 09, 20), VehicleStatuses.Available));
    }

    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) => _vehicles;
}
