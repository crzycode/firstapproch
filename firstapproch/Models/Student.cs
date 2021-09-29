﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace firstapproch.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public string classes { get; set; }
        public int marks { get; set; }
    }
}