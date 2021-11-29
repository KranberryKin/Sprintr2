using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class NotesController : IController<Note>
  {
    private readonly NotesService _ns;

    public NotesController(NotesService ns)
    {
      _ns = ns;
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    ActionResult<Note> IController<Note>.Create(Note data)
    {
      throw new System.NotImplementedException();
    }

    ActionResult<Note> IController<Note>.Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    ActionResult<List<Note>> IController<Note>.Get()
    {
      throw new System.NotImplementedException();
    }

    ActionResult<Note> IController<Note>.Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}