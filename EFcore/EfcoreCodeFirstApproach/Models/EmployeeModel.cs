using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfcoreCodeFirstApproach.Models
{
    [Table("Employees")]
    public class EmployeeModel
    {
        [Key]
        public int EmpId { get; set; } 

        public string? Ename{ get; set; }

        public string? Job {  get; set; }

        public int Salary {  get; set; }

    }
}
