﻿using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Repo
{
    public class BookingRepo : IBookingRepo
    {
        private readonly ApplicationdbContext _dbContext;
        public BookingRepo(ApplicationdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Booking getBookingbyId(int id)
        {
            Booking booking = _dbContext.Bookings.Where(e => e.booking_id == id).FirstOrDefault();
            return booking;
        }
        public bool addBooking(Booking booking)
        {
            _dbContext.Bookings.Add(booking);
            _dbContext.SaveChanges();
            return true;
        }
        
    }

}

