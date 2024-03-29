﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class BookingRepository : IBookingRepository
    {
        public IQueryable<Booking> getActiveBookings(int? excludedBookingId)
        {
            var unitOfWork = new UnitOfWork();
            var bookings = unitOfWork.Query<Booking>()
                            .Where(
                                b => b.Id != excludedBookingId && 
                                b.Status != "Cancelled");
            if (excludedBookingId.HasValue)
                bookings = bookings.Where(b => b.Id != excludedBookingId.Value);
            return bookings;
        }


    }
}
