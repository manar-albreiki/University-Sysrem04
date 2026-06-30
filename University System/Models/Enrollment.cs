using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    [Table("Enrollments")]
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int enrollmentId { get; set; }

        [ForeignKey("student")]
        public int? studentId { get; set; }//fk
        public Student student { get; set; }//navigation

        [ForeignKey("Courses")]
        public int ? courseId { get; set; }//fk
        public Enrollment enrollment { get; set; } //navigation

        [Required]
        public DateTime enrollmentDate { get; set; }
        [MaxLength(2)]
        public string finalGrade { get; set; }
        [DefaultValue("In Progress")]
        [MaxLength(20)]
        public string status { get; set; }



    }
}
