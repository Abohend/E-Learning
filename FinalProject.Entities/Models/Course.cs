using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Learn.Entities.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Image")]
        [ValidateNever]
        public string Img { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        // Relationship with Lesson
        public ICollection<Lesson>? Lessons { get; set; }
        // Relationship with Feedback
        public ICollection<Feedback>? Feedbacks { get; set; }
        // Relationship with Enrollment
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
