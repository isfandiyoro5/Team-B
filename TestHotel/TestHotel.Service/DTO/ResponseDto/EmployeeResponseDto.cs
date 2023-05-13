﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHotel.Service.DTO.ResponseDto
{
    public class EmployeeResponseDto
    {
        public int EmployeeId { get; set; }

        public int HotelId { get; set; }

        public int RoleId { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }
    }
}
