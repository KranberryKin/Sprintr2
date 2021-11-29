using System.Collections.Generic;
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

    ActionResult<Note> IController<Note>.Create(Note data)
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

    ActionResult<Note> IController<Note>.Edit(int id)
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

    ActionResult<List<Note>> IController<Note>.Get()
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

    ActionResult<Note> IController<Note>.Get(int id)
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