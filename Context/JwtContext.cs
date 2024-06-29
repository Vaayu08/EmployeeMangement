using EmployeeMangement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangement.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext>options):base(options)
        {
                
        }
        public DbSet<User>Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
