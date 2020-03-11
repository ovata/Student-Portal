using Code_360.Interface;
using Code_360.Models;
using Code_360.Models.Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Reposotories
{
    public class ProgrammeRepository : IProgramme
    {
        private StudentDbContext dbContext;

        public ProgrammeRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Programme AddProgramme(Programme _programme)
        {
            dbContext.Programmes.Add(_programme);
            dbContext.SaveChanges();
            return _programme;
        }

        public Programme GetProgramme(Guid Id)
        {
            return dbContext.Programmes.Find(Id);
        }

        public IEnumerable<Programme> GetProgrammes()
        {
            return dbContext.Programmes;
        }

        public Programme RemoveProgramme(Guid Id)
        {
            Programme programme = dbContext.Programmes.Find(Id);
            if (programme != null)
            {
                dbContext.Programmes.Remove(programme);
                dbContext.SaveChanges();
            }
            return programme;
        }

        public Programme UpdateProgramme(Programme _programmeUpdate)
        {
            var prog = dbContext.Programmes.Attach(_programmeUpdate);
            prog.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _programmeUpdate;
        }
    }
}
