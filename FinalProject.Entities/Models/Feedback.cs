using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Entities.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        // Relationship with ApplicationUser (User who left feedback)
        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }

        // Relationship with Course
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
