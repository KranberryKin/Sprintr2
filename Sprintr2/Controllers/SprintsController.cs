using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SprintsController : IController<Sprint>
  {
    private readonly SprintsService _ss;

    public SprintsController(SprintsService ss)
    {
      _ss = ss;
    }

    public ActionResult<Sprint> Create(Sprint data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public ActionResult<Sprint> Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    public ActionResult<List<Sprint>> Get()
    {
      throw new System.NotImplementedException();
    }

    public ActionResult<Sprint> Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}