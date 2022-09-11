﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {
        [Display(Name = "Employee ID")]
        public string Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }

    }
}
