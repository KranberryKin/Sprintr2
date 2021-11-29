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
  public class NotesController : ControllerBase, IController<Note>
  {
    private readonly NotesService _ns;

    public NotesController(NotesService ns)
    {
      _ns = ns;
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

    public async Task<ActionResult<Note>> Create(Note data)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        data.CreatorId = userInfo.Id;
           return Ok(_ns.Create(data));
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    public ActionResult<Note> Edit(int id)
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

    public ActionResult<List<Note>> Get()
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

    public ActionResult<Note> Get(int id)
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