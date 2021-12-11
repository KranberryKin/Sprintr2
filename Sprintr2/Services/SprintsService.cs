using System.Collections.Generic;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Repositories;

namespace Sprintr2.Services
{
  public class SprintsService : IServices<Sprint>
  {
    private readonly SprintsRepository _sr;

    public SprintsService(SprintsRepository sr)
    {
      _sr = sr;
    }

    public Sprint Create(Sprint data)
    {
      return _sr.Create(data);
    }

    public void Delete(int id,string userId)
    {
      var foundSprint = Get(id);
      if (foundSprint.CreatorId != userId)
      {
        throw new System.Exception("Cannot Delete Sprint");
      }
      _sr.Delete(id);
    }

    public Sprint Edit(int id, Sprint editedData, string userId)
    {
      var foundSprint = Get(id);
      if (foundSprint.CreatorId != userId)
      {
        throw new System.Exception("Cannot Edit Sprint");
      }
      foundSprint.Name = editedData.Name ?? foundSprint.Name;
      foundSprint.StartDate = editedData.StartDate ?? foundSprint.StartDate;
      foundSprint.EndDate = editedData.EndDate ?? foundSprint.EndDate;
      foundSprint.IsOpen = editedData.IsOpen ?? foundSprint.IsOpen;
      return _sr.Edit(foundSprint);
    }

    public List<Sprint> Get()
    {
      throw new System.NotImplementedException();
    }

    public Sprint Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}