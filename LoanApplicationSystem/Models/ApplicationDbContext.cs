using System.Collections.Generic;
using System.Data.Entity;

namespace LoanApplicationSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<LoanApplication> LoanApplications { get; set; }
    }
}