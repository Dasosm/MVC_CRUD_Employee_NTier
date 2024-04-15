using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepoModels
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [Column(TypeName = "int")]
        [Required]
        public int EmployeeCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string EmployeeName { get; set; }
        [Column(TypeName = "DateTime2(7)")]
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [Column(TypeName = "bit")]
        [Required]
        public bool Gender { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Department { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Designation { get; set; }
        [Column(TypeName = "Decimal(18,2)")]
        [Required]
        public decimal BasicSalary { get; set; }
    }
}
