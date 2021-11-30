using System.Collections.Generic;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Repositories;

namespace Sprintr2.Services
{
  public class NotesService : IServices<Note>
  {
    private readonly NotesRepository _nr;

    public NotesService(NotesRepository nr)
    {
      _nr = nr;
    }

    public Note Create(Note data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id, string userId)
    {
      throw new System.NotImplementedException();
    }

    public Note Edit(int id, string userId)
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