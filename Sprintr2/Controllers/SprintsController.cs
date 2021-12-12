using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Models;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/projects/{projectId}/[controller]")]
  public class SprintsController : ControllerBase
  {
    private readonly SprintsService _ss;

    public SprintsController(SprintsService ss)
    {
      _ss = ss;
    }

    [HttpPost]
    public async Task<ActionResult<Sprint>> Create([FromBody] Sprint data, [FromRoute] int projectId)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        data.CreatorId = userInfo.Id;
        data.ProjectId = projectId;
           return Ok(_ss.Create(data));
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpDelete("{sprintId}")]
    public async Task<ActionResult> Delete(int sprintId)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        _ss.Delete(sprintId, userInfo.Id);
            return Ok("Sprint Deleted");
      }
      catch (System.Exception e)
      {
          
           return BadRequest(e.Message);
      }
    }

    [HttpPut("{sprintId}")]
    public async Task<ActionResult<Sprint>> Edit(int sprintId, [FromBody] Sprint sprintData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
           return Ok(_ss.Edit(sprintId, sprintData, userInfo.Id));
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<List<Sprint>> GetProjectsSprints([FromRoute]int projectId)
    {
      try
      {
           return Ok(_ss.GetProjectsSprints(projectId));
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet("{sprintId}")]
    public ActionResult<Sprint> Get(int sprintId)
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