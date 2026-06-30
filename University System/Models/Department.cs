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
    [Table("Departments")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int departmentId { get; set; }
        [Required]
        //[Index(nameof(departmentName), IsUnique = true)]
        [MaxLength(100)] 
        public string departmentName { get; set; }
        //[Optional]
        [MaxLength(50)]
        public string building { get; set; }
        [Required]
        [Range(0.0,double.MinValue)]
        public decimal budget { get; set; }
        
        [ForeignKey("instructor")]
        public int? headInstructorId { get; set; }//fk
        public Instructor instructor { get; set; }//navigation

        public List <Course> Courses { get; set; }//navigation

    }
}
