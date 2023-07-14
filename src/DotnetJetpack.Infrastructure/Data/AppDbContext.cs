//using DotnetJetpack.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotnetJetpack.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
