using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ControleEscolar.Models;

namespace ControleEscolar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ControleEscolar.Models.Student> Student { get; set; }
        public DbSet<ControleEscolar.Models.Grade> Grade { get; set; }
    }
}