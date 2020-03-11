using Code_360.Interface;
using Code_360.Models;
using Code_360.Models.Batch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Reposotories
{
    public class BatchRepository : IBatch
    {
        private StudentDbContext dbContext;

        public BatchRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Batch AddBatch(Batch _batch)
        {
            dbContext.Batches.Add(_batch);
            dbContext.SaveChanges();
            return _batch;
        }

        public Batch GetBatch(Guid Id)
        {
            return dbContext.Batches.Find(Id);
        }

        public IEnumerable<Batch> GetBatches()
        {
            return dbContext.Batches;
        }

        public Batch RemoveBatch(Guid Id)
        {
            Batch batch = dbContext.Batches.Find(Id);
            {
                if (batch != null)
                {
                    dbContext.Batches.Remove(batch);
                    dbContext.SaveChanges();
                }
                return batch;
            }
        }

        public Batch UpdateBatch(Batch _batchUpdate)
        {
            var batch = dbContext.Batches.Attach(_batchUpdate);
            batch.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _batchUpdate;
        }
    }
}
