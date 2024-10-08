﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Entities.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public bool? IsCompleted { get; set; }
        // Relationship with Course
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
