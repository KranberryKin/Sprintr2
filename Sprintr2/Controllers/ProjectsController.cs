using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Services;
using System;

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

    public ActionResult<Project> Create(Project data)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public ActionResult<Project> Edit(int id)
    {
      throw new NotImplementedException();
    }

    public ActionResult<List<Project>> Get()
    {
      throw new NotImplementedException();
    }

    public ActionResult<Project> Get(int id)
    {
      throw new NotImplementedException();
    }
  }
}