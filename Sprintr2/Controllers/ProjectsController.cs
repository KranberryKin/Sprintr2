using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProjectsController : ControllerBase, IController<Project>
  {
    private readonly ProjectsService _ps;

    public ProjectsController(ProjectsService ps)
    {
      _ps = ps;
    }

    [HttpPost]
    public ActionResult<Project> Create([FromBody] Project data)
    {      try
      {
        Project project = _ps.Create(data);
           return Ok(project);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    public void Delete(int id)
    {
      try
      {
           Ok();
      }
      catch (System.Exception e)
      {
          
          BadRequest(e.Message);
      }
    }

    public ActionResult<Project> Edit(int id)
    {
            try
      {
           return Ok();
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<List<Project>> Get()
    {
      try
      {
           return Ok();
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    public ActionResult<Project> Get(int id)
    {
            try
      {
           return Ok();
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }
  }
}