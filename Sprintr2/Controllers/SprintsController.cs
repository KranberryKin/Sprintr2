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
  public class SprintsController : ControllerBase, IController<Sprint>
  {
    private readonly SprintsService _ss;

    public SprintsController(SprintsService ss)
    {
      _ss = ss;
    }

    [HttpPost]
    public async Task<ActionResult<Sprint>> Create([FromBody] Sprint data)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        data.CreatorId = userInfo.Id;
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
            return Ok();
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
           return Ok();
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<List<Sprint>> Get()
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