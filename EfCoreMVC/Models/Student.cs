﻿using System;
using System.Collections.Generic;

namespace EfCoreMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? LastName { get; set; }
        public string? FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        
    }
}