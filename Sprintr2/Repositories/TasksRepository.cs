using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Sprintr2.Interfaces;

namespace Sprintr2.Repositories
{
  public class TasksRepository : IRepository<Task>
  {
    private readonly IDbConnection _db;

    public TasksRepository(IDbConnection db)
    {
      _db = db;
    }

    public Task Create(Task taskData)
    {
      string sql = "INSERT INTO tasks(name, weight, projectId, backlogitemId, creatorId, isComplete) VALUES(@Name, @Weight, @ProjectId, @BacklogItemId, @CreatorId, @IsComplete); SELECT LAST_INSERT_ID();";
      var id = _db.ExecuteScalar<int>(sql, taskData);
      var foundTask = Get(id);
      return foundTask;
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