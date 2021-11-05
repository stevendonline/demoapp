using System.Linq;
using System.Threading.Tasks;
using Demoapp.Core;
using Demoapp.Core.ProjectAggregate;
using Demoapp.Core.ProjectAggregate.Specifications;
using Demoapp.SharedKernel.Interfaces;
using Demoapp.Web.ApiModels;
using Demoapp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demoapp.Web.Controllers
{


    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly IRepository<Project> _projectRepository;

        public ProjectController(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        // GET project/{projectId?}
        [HttpGet("{projectId:int}")]
        public async Task<IActionResult> Index(int projectId = 1)
        {
            var spec = new ProjectByIdWithItemsSpec(projectId);
            var project = await _projectRepository.GetBySpecAsync(spec);

            var dto = new ProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                Items = project.Items
                            .Select(item => ToDoItemViewModel.FromToDoItem(item))
                            .ToList()
            };
            return View(dto);
        }
    }
}