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

    public ActionResult Delete(int id)
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

    public ActionResult<Assessment> Edit(int id)
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

    public ActionResult<Assessment> Get(int id)
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