using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppFinalProj.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "Date"), Required]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }

        // FK - one to many relationship
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        // FK - many to many relationship
        public virtual ICollection<User> Users { get; set; }
    }
}