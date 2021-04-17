using System;
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

        public void CreateProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }
            _context.Projects.Add(project);
        }

        public void DeleteProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }
            _context.Projects.Remove(project);
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _context.Projects.ToList();
        }

        public Project GetProjectById(int id)
        {
            return _context.Projects.FirstOrDefault(project => project.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public void UpdateProject(Project project)
        {
            //nothing
        }
    }
}
