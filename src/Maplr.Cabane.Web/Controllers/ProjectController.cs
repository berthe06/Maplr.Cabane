using System.Linq;
using System.Threading.Tasks;
using Maplr.Cabane.Core;
using Maplr.Cabane.Core.ProjectAggregate;
using Maplr.Cabane.Core.ProjectAggregate.Specifications;
using Maplr.Cabane.SharedKernel.Interfaces;
using Maplr.Cabane.Web.ApiModels;
using Maplr.Cabane.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Maplr.Cabane.Web.Controllers;

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
