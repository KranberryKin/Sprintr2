using System.Collections.Generic;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Repositories;

namespace Sprintr2.Services
{
  public class BacklogItemsService : IServices<BacklogItem>
  {
    private readonly BacklogItemsRepository _bir;

    public BacklogItemsService(BacklogItemsRepository bir)
    {
      _bir = bir;
    }

    public BacklogItem Create(BacklogItem data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id, string userId)
    {
      throw new System.NotImplementedException();
    }

    public BacklogItem Edit(int id, string userId)
    {
      throw new System.NotImplementedException();
    }

    public List<BacklogItem> Get()
    {
      throw new System.NotImplementedException();
    }

    public BacklogItem Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}