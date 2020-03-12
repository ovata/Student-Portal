using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface IProgrammeCourse
    {
        ProgrammeCourse AddProgrammeCourse(ProgrammeCourse _programmeCourse);
        ProgrammeCourse UpdateProgrammeCourse(ProgrammeCourse _programmeCourse);
        ProgrammeCourse RemoveProgrammeCourse(Guid Id);
        ProgrammeCourse GetProgrammeCourse(Guid Id);
        IEnumerable<ProgrammeCourse> GetProgrammeCourses();
    }
}
