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
  public class AssessmentsController : ControllerBase, IController<Assessment>
  {
    private readonly AssessmentsService _ams;

    public AssessmentsController(AssessmentsService ams)
    {
      _ams = ams;
    }
[HttpPost]
    public async Task<ActionResult<Assessment>> Create(Assessment data)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        data.CreatorId = userInfo.Id;
           return Ok(_ams.Create(data));
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpDelete("{assessmentId}")]
    public async Task<ActionResult> Delete(int assessmentId)
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

    [HttpPut("{assessmentId}")]
    public async Task<ActionResult<Assessment>> Edit(int assessmentId, [FromBody] Assessment assessmentData)
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
    public ActionResult<List<Assessment>> Get()
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

    [HttpGet("{assessmentId}")]
    public ActionResult<Assessment> Get(int assessmentId)
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