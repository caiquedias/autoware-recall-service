using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Interfaces;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoware.Recall.Infrastructure.Repositories
{
    public class ChassiRepository : GenericRepository<Chassi>, IChassiRepository
    {
        IDbContext _dbContext;
        public ChassiRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
