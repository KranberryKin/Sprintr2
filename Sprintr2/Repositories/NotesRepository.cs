using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Sprintr2.Interfaces;
using Sprintr2.Models;

namespace Sprintr2.Repositories
{
  public class NotesRepository : IRepository<Note>
  {
    private readonly IDbConnection _db;

    public NotesRepository(IDbConnection db)
    {
      _db = db;
    }

    public Note Create(Note data)
    {
      string sql = "INSERT INTO notes(body, backlogitemId, projectId, creatorId) VALUES(@Body, @BacklogItemId, @ProjectId, @CreatorId); SELECT LAST_INSERT_ID();";
      var id = _db.ExecuteScalar<int>(sql, data);
      data.Id = id;
      var foundNote = Get(data.Id);
      return foundNote;
    }

    public void Delete(int id)
    {
      string sql = "DELETE FROM notes WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new{id});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Delete Note Failed");
      }
    }

    public Note Edit(Note noteData)
    {
      string sql = "UPDATE notes SET body = @Body WHERE id = @id LIMIT 1;";
      var rowsAffected = _db.Execute(sql, new{noteData});
      if (rowsAffected == 0)
      {
        throw new System.Exception("Update Note Failed");
      }
      var foundNote = Get(noteData.Id);
      return foundNote;
    }

    public List<Note> GetBacklogNotes(int id)
    {
      string sql = "SELECT n.*, a.* FROM notes n JOIN accounts a ON a.id = n.creatorId WHERE n.backlogitemId = @id";
      return _db.Query<Note, Profile, Note>(sql, (n, a) => 
      {
        n.Creator = a;
        return n;
      }, new {id}).ToList();
    }

    public Note Get(int id)
    {
      string sql = "SELECT n.*, a.* FROM notes n JOIN accounts a ON a.id = n.creatorId WHERE id = @id";
      return _db.Query<Note, Profile, Note>(sql, (n, a) => 
      {
        n.Creator =a;
        return n;
      }, new {id}).FirstOrDefault();
    }

    public List<Note> Get()
    {
      throw new System.NotImplementedException();
    }
  }
}