using System.Collections.Generic;
using AutoMapper;
using CMDataManager.Data;
using CMDataManager.DTOs;
using CMDataManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CMDataManager.Controllers
{
    [Authorize]
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ICreativeManagerRepo _repository;
        private readonly IMapper _mapper;

        public ProjectsController(ICreativeManagerRepo repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

        //GET api/projects
        [HttpGet]
        public ActionResult<IEnumerable<ProjectReadDTO>> GetAllProjects()
        {
            var projectItems = _repository.GetAllProjects();
            return Ok(_mapper.Map<IEnumerable<ProjectReadDTO>>(projectItems));
        }

        //GET api/projects/3
        [HttpGet("{id}", Name = "GetProjectById")]
        public ActionResult<ProjectReadDTO> GetProjectById(int id)
        {
            var projectItem = _repository.GetProjectById(id);
            if (projectItem != null)
            {
                return Ok(_mapper.Map<ProjectReadDTO>(projectItem));
            }
            return NotFound();
        }

        //POST api/projects
        [HttpPost]
        public ActionResult<ProjectReadDTO> CreateProject(ProjectCreateDTO projectCreateDTO)
        {
            Project projectModel = _mapper.Map<Project>(projectCreateDTO);
            _repository.CreateProject(projectModel);
            _repository.SaveChanges();

            var projectReadDTO = _mapper.Map<ProjectReadDTO>(projectModel);

            return CreatedAtRoute(nameof(GetProjectById), new { Id = projectReadDTO.Id }, projectReadDTO);
        }

        //PUT api/projects/3
        [HttpPut("{id}")]
        public ActionResult UpdateProject(int id, ProjectUpdateDTO projectUpdateDTO)
        {
            var projectModelFromRepo = _repository.GetProjectById(id);
            if (projectModelFromRepo == null)
            { return NotFound(); }

            _mapper.Map(projectUpdateDTO, projectModelFromRepo);
            _repository.UpdateProject(projectModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/projects/3
        [HttpPatch("{id}")]
        public ActionResult PartialUpdateProject(int id, JsonPatchDocument<ProjectUpdateDTO> patchDoc)
        {
            var projectModelFromRepo = _repository.GetProjectById(id);
            if (projectModelFromRepo == null)
            { return NotFound(); }

            var projectToPatch = _mapper.Map<ProjectUpdateDTO>(projectModelFromRepo);
            patchDoc.ApplyTo(projectToPatch);

            if (!TryValidateModel(projectToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(projectToPatch, projectModelFromRepo);
            _repository.UpdateProject(projectModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/projects/3
        [HttpDelete("{id}")]
        public ActionResult DeleteProject(int id)
        {
            var projectModelFromRepo = _repository.GetProjectById(id);
            if (projectModelFromRepo == null)
            { return NotFound(); }

            _repository.DeleteProject(projectModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
