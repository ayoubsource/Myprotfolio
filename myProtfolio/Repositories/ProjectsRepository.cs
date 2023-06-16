using Microsoft.EntityFrameworkCore;
using myProtfolio.Models;

namespace myProtfolio.Repositories
{
    public class ProjectsRepository : DbContext
    {

        public DbSet<Project> Projects { get; set; }


       public ProjectsRepository(DbContextOptions<ProjectsRepository> options) : base(options)
    {
            Projects = Set<Project>();
    }

    public bool AddNewProject(Project project)
        {
            if(project == null)
            {
                return false;
            }
            Projects.Add(project);
            return true;
        }
        public DbSet<Project> GetAllProjects()
        {
            return Projects;
        }

        public Project GetProjectById(long id)
        {
            if (id < 0)
                throw new ArgumentException("Id could not be null");
            return Projects.Find(id);
        }
    }
}
