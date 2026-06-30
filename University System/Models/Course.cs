using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int courseId { get; set; }
        [Required]
        //[Index(nameof(courseCode), IsUnique = true)]
        [MaxLength(10)]
        public string courseCode { get; set; }
        [Required]
        [MaxLength(150)]
        public string courseTitle { get; set; }
        [Required]
        [Range(1,6)]
        public int creditHours { get; set; }

        [ForeignKey("department")]
        public int departmentId { get; set; }//fk
        public Department department { get; set; }//navigation

        [ForeignKey("instructor")]
        public int? instructorId { get; set; } //fk
        public Instructor instructor { get; set; }//navigation

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; }

        public List<Student> Students { get; set; }//navigation
        public List <Enrollment> Enrollments { get; set; }//navigation

    }
}
