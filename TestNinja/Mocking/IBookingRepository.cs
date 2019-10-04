using System.Linq;

namespace TestNinja.Mocking
{
    public interface IBookingRepository
    {
        IQueryable<Booking> getActiveBookings(int? excludedBookingId);
    }
}