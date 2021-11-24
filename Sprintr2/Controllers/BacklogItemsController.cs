using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BacklogItemsController : IController<BacklogItem>
  {
    public BacklogItem Create(BacklogItem data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public BacklogItem Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    public System.Collections.Generic.List<BacklogItem> Get()
    {
      throw new System.NotImplementedException();
    }

    public BacklogItem Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}