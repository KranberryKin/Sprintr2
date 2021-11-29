using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BacklogItemsController : ControllerBase, IController<BacklogItem>
  {
    private readonly BacklogItemsService _bis;

    public BacklogItemsController(BacklogItemsService bis)
    {
      _bis = bis;
    }

    public ActionResult<BacklogItem> Create(BacklogItem data)
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

    public void Delete(int id)
    {
      try
      {
            Ok();
      }
      catch (System.Exception e)
      {
          
           BadRequest(e.Message);
      }
    }

    public ActionResult<BacklogItem> Edit(int id)
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

    public ActionResult<List<BacklogItem>> Get()
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

    public ActionResult<BacklogItem> Get(int id)
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