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

    [HttpDelete]
    public async Task<ActionResult> Delete(int id)
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

    [HttpPost]
    public async Task<ActionResult<Note>> Create([FromBody] Note noteData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        noteData.CreatorId = userInfo.Id;
           return Ok(_ns.Create(noteData));
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpPut("{noteId}")]
    public async Task<ActionResult<Note>> Edit(int noteId, [FromBody] Note noteData)
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

    [HttpGet("{noteId}")]
    public ActionResult<Note> Get(int noteId)
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