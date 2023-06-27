using myProtfolio.DataAccess;
using myProtfolio.Models;
using System;

namespace myProtfolio.Repositories
{
    public class ProjectRepository
    {
        private readonly EFCoreDataAccesDbContext _dbContext;

        public ProjectRepository()
        {
            _dbContext = new EFCoreDataAccesDbContext();
        }

        public void AddPerson(Project project)
        {
            _dbContext.projects.Add(project);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Project> GetAllProject()
        {
            return _dbContext.projects.ToList();
        }
    }
}
