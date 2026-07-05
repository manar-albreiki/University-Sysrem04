using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Models
{
    [Table("Instructor")]
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int instructorId  { get; set; }
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }
        [Required]
        [MaxLength(150)]
        public string email { get; set; }
        [MaxLength(20)]
        public string officeNumber { get; set; }
        [Required]
        public DateTime hireDate { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, double.MaxValue)]
        public decimal salary { get; set; }
        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; }

        public Department department { get; set; } //navigation 

        public List<Course> Courses { get; set; }//navigation

    }
}
