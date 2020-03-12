using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface ISalary
    {
        Salary AddSalary(Salary _salary);
        Salary GetSalary(Guid Id);
        Salary UpdateSalary(Salary _salary);
        IEnumerable<Salary> GetSalaries();
    }
}
