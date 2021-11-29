using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sprintr2.Interfaces;
using Sprintr2.Services;

namespace Sprintr2.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class TasksController : IController<Task>
  {
    private readonly TasksService _ts;

    public TasksController(TasksService ts)
    {
      _ts = ts;
    }

    public Task Create(Task data)
    {
      throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new System.NotImplementedException();
    }

    public Task Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    public List<Task> Get()
    {
      throw new System.NotImplementedException();
    }

    public Task Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}