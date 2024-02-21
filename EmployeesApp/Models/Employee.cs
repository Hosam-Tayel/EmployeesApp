using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesApp.Models
{
    [Table("Employee",Schema ="dbo")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Employee Id")]
        public int EmployeesId { get; set; }


        [Required]
        [Column(TypeName ="varchar(5)")]
        [Display(Name = "Employee Number")]
        [MaxLength(5)]
        public string EmployeeNumber { get; set; }


        [Required]
        [Column(TypeName = "varchar(150)")]
        [Display(Name = "Employee Name")]
         public string EmployeeName { get; set; }


        //[Required]
        [DataType(DataType.Date)]
        [Display (Name = "Date of Birth")]
        public DateTime DOB { get; set; }



        //[Required]
        [DataType(DataType.Date)]
        [Display(Name = "Hiring Date")]
        public DateTime HiringDate { get; set; }


        [Required]
        [Column(TypeName = "decimal(12,2)")]
        [Display(Name = "Gross Salary")]
        public decimal GrossSalary { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        [Display(Name = "Net Salary")]
        public decimal NetSalary { get; set; }

   
    }
}
