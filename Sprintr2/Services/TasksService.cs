using System.Collections.Generic;
using System.Threading.Tasks;
using Sprintr2.Interfaces;
using Sprintr2.Repositories;

namespace Sprintr2.Services
{
  public class TasksService : IServices<Task>
  {
    private readonly TasksRepository _tr;

    public TasksService(TasksRepository tr)
    {
      _tr = tr;
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