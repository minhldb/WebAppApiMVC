﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class mvcEmployeeModel
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Position { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Office { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}