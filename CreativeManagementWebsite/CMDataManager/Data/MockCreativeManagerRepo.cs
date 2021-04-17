using System.Collections.Generic;
using CMDataManager.Models;

namespace CMDataManager.Data
{
    public class MockCreativeManagerRepo : ICreativeManagerRepo
    {
        public void CreateProject(Project project)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProject(Project project)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Project> GetAllProjects()
        {
            var projects = new List<Project>
            {
                new Project { Id = 0, FinishedProject = false, Name = "Ghost horse sweater", ProjectType = "Knitting" },
                new Project { Id = 1, FinishedProject = false, Name = "Space pants", ProjectType = "Sewing" },
                new Project { Id = 2, FinishedProject = false, Name = "Summer shorts", ProjectType = "Sewing" },
                new Project { Id = 3, FinishedProject = false, Name = "Whimsical shirt", ProjectType = "Sewing" }
            };

            return projects;
        }

        public Project GetProjectById(int id)
        {
            return new Project { Id = 0, FinishedProject = false, Name = "New Project", ProjectType = "Knitting" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProject(Project project)
        {
            throw new System.NotImplementedException();
        }
    }
}
