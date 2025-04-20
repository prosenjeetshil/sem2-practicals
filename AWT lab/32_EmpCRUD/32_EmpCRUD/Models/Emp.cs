using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace _32_EmpCRUD.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        [Precision(18, 2)]
        public decimal Salary { get; set; }
    }
}
