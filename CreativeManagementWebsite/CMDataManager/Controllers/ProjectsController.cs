using System.Collections.Generic;
using CMDataManager.Data;
using CMDataManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMDataManager.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ICreativeManagerRepo _repository;

        public ProjectsController(ICreativeManagerRepo repo)
        {
            _repository = repo;
        }

        //GET api/projects
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAllProjects()
        {
            var projectItems = _repository.GetAllProjects();
            return Ok(projectItems);
        }

        //GET api/projects/3
        [HttpGet("{id}")]
        public ActionResult<Project> GetProjectById(int id)
        {
            var projectItem = _repository.GetProjectById(id);
            return Ok(projectItem);
        }
    }
}
