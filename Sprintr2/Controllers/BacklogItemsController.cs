using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BacklogItemsController : IController<BacklogItem>
  {
    private readonly BacklogItemsService _bis;

    public BacklogItemsController(BacklogItemsService bis)
    {
      _bis = bis;
    }

    public ActionResult<BacklogItem> Create(BacklogItem data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public ActionResult<BacklogItem> Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    public ActionResult<List<BacklogItem>> Get()
    {
      throw new System.NotImplementedException();
    }

    public ActionResult<BacklogItem> Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}