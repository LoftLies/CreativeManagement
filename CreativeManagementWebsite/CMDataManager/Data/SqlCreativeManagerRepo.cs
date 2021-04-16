using System.Collections.Generic;
using System.Linq;
using CMDataManager.Models;

namespace CMDataManager.Data
{
    public class SqlCreativeManagerRepo : ICreativeManagerRepo
    {
        private readonly CreativeManagerContext _context;

        public SqlCreativeManagerRepo(CreativeManagerContext context)
        {
            _context = context;
        }

        public IEnumerable<Project> GetAllProjects()
        {
           return _context.Projects.ToList();
        }

        public Project GetProjectById(int id)
        {
            return _context.Projects.FirstOrDefault(project => project.Id == id);
        }
    }
}
