using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProjectsController : IController<Project>
  {
    private readonly ProjectsService _ps;

    public ProjectsController(ProjectsService ps)
    {
      _ps = ps;
    }

    public Project Create(Project data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public Project Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    public List<Project> Get()
    {
      throw new System.NotImplementedException();
    }

    public Project Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}