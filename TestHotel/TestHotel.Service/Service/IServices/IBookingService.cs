﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHotel.DataAccess.Model;

namespace TestHotel.Service.Service.IServices
{
    internal interface IBookingService
    {
        Task<int> AddBookingAsync(Booking booking);

        Task<int> UpdateBookingAsync(int id);

        Task<int> DeleteBookingAsync(int id);

        Task<Booking> GetBookingByIdAsync(int id);

        Task<List<Booking>> GetAllBookingsAsync();
    }
}