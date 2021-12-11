using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Sprintr2.Interfaces;
using Sprintr2.Models;

namespace Sprintr2.Repositories
{
  public class SprintsRepository : IRepository<Sprint>
  {
    private readonly IDbConnection _db;

    public SprintsRepository(IDbConnection db)
    {
      _db = db;
    }

    public Sprint Create(Sprint data)
    {
      string sql = "INSERT INTO sprints(name, startDate, endDate, projectId, creatorId, isOpen) VALUES(@Name, @StartDate, @EndDate, @ProjectId, @CreatorId, @IsOpen); SELECT LAST_INSERT_ID();"; 
      var id = _db.ExecuteScalar<int>(sql, data);
      var foundSprint = Get(id);
      return foundSprint;
    }

    public void Delete(int id)
    {
      string sql = "DELETE FROM sprints WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new {id});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Deleting Sprint Failed");
      }
    }

    public Sprint Edit(Sprint sprintData)
    {
      string sql = "UPDATE sprints SET name = @Name, startDate = @StartDate, endDate = @EndDate, creatorId = @CreatorId, isOpen = @IsOpen WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new {sprintData});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Update Sprint Failed");
      }
      var foundSprint = Get(sprintData.Id);
      return foundSprint;
    }

    public List<Sprint> GetProjectsSprints(int ProjectId)
    {
      string sql = "SELECT * FROM sprints WHERE projectId = @ProjectId";
      return _db.Query<Sprint>(sql, new {ProjectId}).ToList();
    }

    public Sprint Get(int id)
    {
      string sql = "SELECT s.*, a.* FROM sprints s JOIN accounts a ON a.id = s.creatorId WHERE id = @id LIMIT 1";
      return _db.Query<Sprint, Profile, Sprint>(sql, (s, a) => {
        s.Creator = a;
        return s;
      }, new{id}).FirstOrDefault();
    }

    public List<Sprint> Get()
    {
      throw new System.NotImplementedException();
    }
  }
}