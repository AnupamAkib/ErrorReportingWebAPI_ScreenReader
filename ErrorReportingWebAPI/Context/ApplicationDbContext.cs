using ErrorReportingWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ErrorReportingWebAPI.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ErrorEntity> Errors { get; set; }
    }
}
