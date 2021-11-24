using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class NotesController : IController<Note>
  {
    public Note Create(Note data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public Note Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    public List<Note> Get()
    {
      throw new System.NotImplementedException();
    }

    public Note Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}