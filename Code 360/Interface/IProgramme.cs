using Code_360.Models.Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Interface
{
    public interface IProgramme
    {
        Programme AddProgramme(Programme _programme);
        Programme GetProgramme(Guid Id);
        Programme UpdateProgramme(Programme _programmeUpdate);
        Programme RemoveProgramme(Guid Id);
        IEnumerable<Programme> GetProgrammes();
    }
}
