using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Sprintr2.Interfaces;
using Sprintr2.Models;

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
      string sql = "DELETE FROM tasks WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new{id});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Delete Task Failed");
      }
    }

    public Task Edit(int id)
    {
      string sql = "UPDATE tasks SET name = @Name, weight = @Weight, isComplete = @IsComplete, completedOn = @CompletedOn WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new {id});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Update Task Failed");
      }
      var foundTask = Get(id);
      return foundTask;
    }

    public List<Task> GetBacklogTasks(int id)
    {
      string sql = "SELECT t.*, a.* FROM tasks t JOIN accounts a ON a.id = t.creatorId WHERE t.backlogitemId = @id;";
      return _db.Query<Task, Profile, Task>(sql, (t, a) => 
      {
        t.Creator = a;
        return t;
      }, new{id}).ToList();

    }

    public Task Get(int id)
    {
      string sql = "SELECT * FROM tasks WHERE id = @id LIMIT 1;";
      return _db.Query<Task>(sql, new {id}).FirstOrDefault();
    }

    public List<Task> Get()
    {
      throw new System.NotImplementedException();
    }
  }
}