using Code_360.Models;
using System;
using System.Collections.Generic;

namespace Code_360.Interface
{
    public interface IProject
    {
        Project AddProject(Project _project);
        Project GetProject(Guid Id);
        Project UpdateProject(Project _projectUpdate);
        Project RemoveProject(Guid Id);
        IEnumerable<Project> GetProjects();
    }
}
