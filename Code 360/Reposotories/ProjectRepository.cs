using Code_360.Interface;
using Code_360.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Reposotories
{
    public class ProjectRepository : IProject
    {
        private StudentDbContext dbContext;

        public ProjectRepository(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Project AddProject(Project _project)
        {
            dbContext.Projects.Add(_project);
            dbContext.SaveChanges();
            return _project;
        }

        public Project GetProject(Guid Id)
        {
            return dbContext.Projects.Find(Id);
        }

        public IEnumerable<Project> GetProjects()
        {
            return dbContext.Projects;
        }

        public Project RemoveProject(Guid Id)
        {
            Project project = dbContext.Projects.Find(Id);
            if (project != null)
            {
                dbContext.Projects.Remove(project);
                dbContext.SaveChanges();
            }
            return project;
        }

        public Project UpdateProject(Project _projectUpdate)
        {
            var project = dbContext.Projects.Attach(_projectUpdate);
            project.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return _projectUpdate;
        }
    }
}
