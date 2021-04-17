using CMDataManager.Models;
using System.Collections.Generic;

namespace CMDataManager.Data
{
    public interface ICreativeManagerRepo
    {
        bool SaveChanges();
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(int id);
        void CreateProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
    }
}
