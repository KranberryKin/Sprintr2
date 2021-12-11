using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Sprintr2.Interfaces;
using Sprintr2.Models;

namespace Sprintr2.Repositories
{
  public class ProjectsRepository : IRepository<Project>
  {
  private readonly IDbConnection _db;

    public ProjectsRepository(IDbConnection db)
    {
      _db = db;
    }

    public Project Create(Project data)
    {
      string sql = "INSERT INTO projects(name, description, creatorId) VALUES(@Name, @Description, @CreatorId); SELECT LAST_INSERT_ID();";
      var id = _db.ExecuteScalar<int>(sql, data);
      data.Id = id;
      var foundProject = Get(id);
      return foundProject;
    }

    public void Delete(int id)
    {
      string sql = "DELETE FROM projects WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new {id});
        if (rowsAffected == 0)
      {
        throw new System.Exception("Deleting Project Failed!");
      }
    }

    public Project Edit(Project data)
    {
      string sql = "UPDATE projects SET name = @Name, description = @Description WHERE id = @Id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, data);
      if (rowsAffected == 0)
      {
        throw new System.Exception("Update Failed");
      }
      var foundProject = Get(data.Id);
      return foundProject;
    }

    public List<Project> Get()
    {
      string sql = "SELECT p.*, a.* FROM projects p JOIN accounts a ON a.id = p.creatorId;";
      return _db.Query<Project, Profile, Project>(sql, (p, a) => {
        p.Creator = a;
        return p;
      }).ToList();

    }

    public Project Get(int id)
    {
      string sql = "SELECT p.*, a.* FROM projects p JOIN accounts a ON a.id = p.creatorId WHERE p.id = @id LIMIT 1;";
      return _db.Query<Project, Profile, Project>(sql, (p, a) => {
        p.Creator = a;
        return p;
      }, new {id}).FirstOrDefault();
    }
  }
}