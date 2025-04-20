using Microsoft.EntityFrameworkCore;
using _32_EmpCRUD.Models;

namespace _32_EmpCRUD.Data
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options) { }

        public DbSet<Emp> Emps { get; set; }
    }
}
