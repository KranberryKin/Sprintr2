using System.Collections.Generic;
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

    public ActionResult<Sprint> Create(Sprint data)
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

    public ActionResult<Sprint> Edit(int id)
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

    public ActionResult<Sprint> Get(int id)
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