using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;
using Autoware.Recall.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Autoware.Recall.Infrastructure
{
    public class RecallContext : DbContext, IDbContext
    {
        public RecallContext(DbContextOptions<RecallContext> options) : base(options)
        {
        }

        public DbSet<Chassi> Chassi { get; set; }

        public DbSet<ChassiRecall> ChassiRecall { get; set; }

        public DbSet<Domain.AggregatesModel.RecallAggregate.Models.Recall> Recall{ get; set; }

        public Task<int> SaveChangesAsync() => base.SaveChangesAsync();
    }
}
