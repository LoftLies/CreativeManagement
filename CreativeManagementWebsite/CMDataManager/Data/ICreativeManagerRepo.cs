using CMDataManager.Models;
using System.Collections.Generic;

namespace CMDataManager.Data
{
    public interface ICreativeManagerRepo
    {
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(int id);
    }
}
