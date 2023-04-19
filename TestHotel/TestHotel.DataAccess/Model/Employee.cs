﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHotel.DataAccess.Model
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    internal class Employee
    {
        public int EmployeeID{ get; set; }
        
        public int HotelId { get; set; }
        
        public int RoleID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public Gender Gender { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public int Salary { get; set; }


        public Hotel Hotel { get; set; }
        
        public Role Role { get; set; }
    }
}
