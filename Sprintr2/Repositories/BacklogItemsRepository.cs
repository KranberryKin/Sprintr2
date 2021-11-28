using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Sprintr2.Interfaces;
using Sprintr2.Models;

namespace Sprintr2.Repositories
{
  public class BacklogItemsRepository : IRepository<BacklogItem>
  {
    private readonly IDbConnection _db;

    public BacklogItemsRepository(IDbConnection db)
    {
      _db = db;
    }

    public BacklogItem Create(BacklogItem data)
    {
      string sql = "INSERT INTO backlogitems(name, description, status, projectId, sprintId, creatorId) VALUES(@Name, @Description, @Status, @ProjectId, @SprintId, @CreatorId); SELECT LAST_INSERT_ID();";
      var id = _db.ExecuteScalar<int>(sql, new{data});
      data.Id = id;
      var foundBacklog = Get(id);
      return foundBacklog;
    }

    public void Delete(int id)
    {
      string sql = "DELETE FROM backlogitems WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new {id});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Deleting BacklogItem Failed");
      }
    }

    public BacklogItem Edit(int id)
    {
      string sql = "UPDATE backlogitems SET name = @Name, description = @Description, status = @Status, sprintId = @SprintId WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new {id});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Deleting BacklogItem Failed");
      }
      var foundBacklog = Get(id);
      return foundBacklog;
    }

    public List<BacklogItem> GetProjectsBacklogs(int ProjectId)
    {
      string sql = "SELECT b.*, a.* FROM backlogitems b JOIN accounts a ON a.id = b.creatorId WHERE projectId = @ProjectId";
      return _db.Query<BacklogItem, Profile, BacklogItem>(sql, (b, a) =>
      {
        b.Creator = a;
        return b;
      }, new {ProjectId}).ToList();
    }

    public BacklogItem Get(int id)
    {
      string sql = "SELECT b.*, a.* FROM backlogitems b JOIN accounts a ON a.id = b.creatorId WHERE id = @id LIMIT 1;";
      return _db.Query<BacklogItem, Profile, BacklogItem>(sql, (b, a) => 
      {
        b.Creator = a;
        return b;
      }, new {id}).FirstOrDefault();
    }

    public List<BacklogItem> Get()
    {
      throw new System.NotImplementedException();
    }
  }
}