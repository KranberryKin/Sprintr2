using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
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
    // Connection so Backlog Service
    private readonly BacklogItemsService _bis;

    public BacklogItemsController(BacklogItemsService bis)
    {
      _bis = bis;
    }

    [HttpPost]
    public async Task<ActionResult<BacklogItem>> Create([FromBody] BacklogItem data)
    {
      try
      {
         Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
         data.CreatorId = userInfo.Id;
          var createdBacklog = _bis.Create(data);
           return Ok(createdBacklog);
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpDelete("{backlogitemId}")]
    public async Task<ActionResult> Delete(int backlogitemId)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
            return Ok();
      }
      catch (System.Exception e)
      {
          
           return BadRequest(e.Message);
      }
    }

    [HttpPut("{backlogitemId}")]
    public async Task<ActionResult<BacklogItem>> Edit(int backlogitemId, [FromBody] BacklogItem backlogItemData)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
           return Ok();
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }

    [HttpGet]
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

    [HttpGet("{backlogitemId}")]
    public ActionResult<BacklogItem> Get(int backlogitemId)
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