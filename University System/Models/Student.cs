using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace University_System.Models
{

    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int studentId { get; set; }
        [Required] [MaxLength(100)]
        public string fullName { get; set; }
        [Required]
        [MaxLength(150)]
        //[Index (IsUnique = true)]
        public string email { get; set; }
        [MaxLength(20)]
        public string? phoneNumber { get; set; }
        [Required]
        public DateTime dateOfBirth { get; set; }
        [Required]
        [Range(2000,2023)]
        public int enrollmentYear { get; set; }
        [DefaultValue(0.0)]
        [Range(0.0, 4.0)]
        public decimal gpa { get; set; }

        public List <Course> Courses { get; set; }//navigation
        public List <Enrollment> Enrollments { get; set; }//navigation

    }
}
