﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Leave Type")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Default Number of Days")]
        [Range(1, 25, ErrorMessage = "Please Enter a Valid Number!")]
        public int DefaultDays { get; set; }
    }
}
