using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
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
    public async Task<ActionResult<Project>> Create([FromBody] Project data)
    {      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        data.CreatorId = userInfo.Id;
        Project project = _ps.Create(data);
           return Ok(project);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpDelete("{projectId}")]
    public async Task<ActionResult> Delete(int projectId)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
          _ps.Delete(projectId, userInfo.Id);
           return Ok("Project deleted");
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpPut("{projectId}")]
    public async Task<ActionResult<Project>> Edit(int projectId, [FromBody] Project projectData)
    {
            try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
           return Ok(_ps.Edit(projectId, projectData, userInfo.Id));
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
           return Ok(_ps.Get());
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet("{projectId}")]
    public ActionResult<Project> Get(int projectId)
    {
            try
      {
           return Ok(_ps.Get(projectId));
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }
  }
}