using System.Collections.Generic;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Repositories;

namespace Sprintr2.Services
{
  public class AssessmentsService : IServices<Assessment>
  {
    private readonly AssessmentsRepository _amr;

    public AssessmentsService(AssessmentsRepository amr)
    {
      _amr = amr;
    }

    public Assessment Create(Assessment data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id, string userId)
    {
      throw new System.NotImplementedException();
    }

    public Assessment Edit(int id, string userId)
    {
      throw new System.NotImplementedException();
    }

    public List<Assessment> Get()
    {
      throw new System.NotImplementedException();
    }

    public Assessment Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}