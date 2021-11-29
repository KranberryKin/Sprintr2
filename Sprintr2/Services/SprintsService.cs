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
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public Sprint Edit(int id)
    {
      throw new System.NotImplementedException();
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